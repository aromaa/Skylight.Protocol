﻿using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Skylight.Protocol.Generator.Parser.Mapping;
using Skylight.Protocol.Generator.Schema;
using Skylight.Protocol.Generator.Schema.Mapping;
using Skylight.Protocol.Generator.Structure;
using Skylight.Protocol.Generator.Structure.Mapping;

namespace Skylight.Protocol.Generator.Parser;

internal static class ProtocolParser
{
	internal static ProtocolStructure Parse(ProtocolSchema protocol, Assembly protocolAssembly)
	{
		Context context = new();

		foreach ((string name, List<AbstractMappingSchema> structure) in protocol.Structures)
		{
			ImmutableArray<(string? FieldName, AbstractMappingSyntax Mapping)>.Builder mappings = ImmutableArray.CreateBuilder<(string?, AbstractMappingSyntax)>(structure.Count);

			Dictionary<string, AbstractMappingSyntax> fields = [];

			bool recursive = false;

			foreach (AbstractMappingSchema mapping in structure)
			{
				AbstractMappingSyntax syntax = MappingParser.Parse(mapping, protocolAssembly.GetType("Skylight.Protocol.Attributes.GameProtocolAttribute")!.BaseType!.Assembly);

				if (mapping is FieldMappingSchema fieldMapping)
				{
					mappings.Add((fieldMapping.Name, syntax));
					fields.TryAdd(fieldMapping.Name, syntax);
				}
				else
				{
					mappings.Add((null, syntax));
				}

				if (syntax is ObjectMappingSyntax objectMapping)
				{
					if (objectMapping.Name == name)
					{
						recursive = true;
					}
				}
				else if (syntax is GenericTypeMappingSyntax genericMapping)
				{
					if (genericMapping.GenericArgument is ObjectMappingSyntax genericArgument && genericArgument.Name == name)
					{
						recursive = true;
					}
				}
			}

			context.AddStructure(new ObjectStructure(name, recursive, mappings.MoveToImmutable(), fields));
		}

		Dictionary<string, PacketStructure> incoming = [];
		foreach ((string name, PacketSchema packet) in protocol.Incoming)
		{
			PacketStructure structure = Parse(ref context, packet, protocolAssembly.GetType("Skylight.Protocol.Packets.Incoming.IGameIncomingPacket")!, name);

			incoming.Add(structure.Name, structure);
		}

		Dictionary<string, PacketStructure> outgoing = [];
		foreach ((string name, PacketSchema packet) in protocol.Outgoing)
		{
			PacketStructure structure = Parse(ref context, packet, protocolAssembly.GetType("Skylight.Protocol.Packets.Outgoing.IGameOutgoingPacket")!, name);

			outgoing.Add(structure.Name, structure);
		}

		return new ProtocolStructure(protocol.Revision, protocol.Protocol, incoming, outgoing, context.Structures, protocol.Interfaces.ToDictionary(i => i.Key, i => i.Value.ToDictionary(o => o.Key, o => o.Value)));
	}

	private static PacketStructure Parse(ref Context context, PacketSchema packet, Type interfaceType, string name)
	{
		int groupIdentifier = name.LastIndexOf('.');

		string packetGroup = name.Substring(0, groupIdentifier);
		string packetName = name.Substring(groupIdentifier + 1);

		Type? packetInterface;
		if (interfaceType == interfaceType.Assembly.GetType("Skylight.Protocol.Packets.Incoming.IGameIncomingPacket"))
		{
			packetInterface = interfaceType.Assembly.GetType($"{interfaceType.Namespace}.{packetGroup}.I{packetName}IncomingPacket");
		}
		else if (interfaceType == interfaceType.Assembly.GetType("Skylight.Protocol.Packets.Outgoing.IGameOutgoingPacket"))
		{
			packetInterface = interfaceType.Assembly.GetType($"{interfaceType.Namespace}.{packetGroup}.{packetName}OutgoingPacket");
			if (packetInterface is null)
			{
				for (int i = 1; i < 10; i++)
				{
					packetInterface = interfaceType.Assembly.GetType($"{interfaceType.Namespace}.{packetGroup}.{packetName}OutgoingPacket`{i}");
					if (packetInterface is not null)
					{
						break;
					}
				}
			}
		}
		else
		{
			throw new Exception($"Unknown interface type {interfaceType}");
		}

		if (packetInterface is null)
		{
			throw new Exception($"No definition for packet {name} with interface {interfaceType}");
		}

		return Parse(ref context, name, packet, packetInterface);
	}

	private static PacketStructure Parse(ref Context context, string name, PacketSchema packet, Type packetType)
	{
		ImmutableArray<MappingStructure>.Builder mappings = ImmutableArray.CreateBuilder<MappingStructure>(packet.Structure!.Count);

		if (packetType.IsGenericType)
		{
			if (packet.Converters is null)
			{
				throw new Exception($"Packet {name} does not have converters defined, but the type {packetType} is generic.");
			}

			Type[] genericArguments = packetType.GetGenericArguments();
			for (int i = 0; i < genericArguments.Length; i++)
			{
				if (!packet.Converters.TryGetValue(genericArguments[i].Name, out string? target))
				{
					throw new Exception($"Packet {name} does not have mapping for generic parameter {genericArguments[i].Name}!");
				}

				int genericIndexOf = target.IndexOf('<');
				if (genericIndexOf > -1)
				{
					if (packetType.Assembly.GetType($"{target.AsSpan(0, genericIndexOf)}`{target.Count(c => c == ',') + 1}") is not { } targetType)
					{
						throw new Exception($"Packet {name} does not have definition for {target}!");
					}

					genericArguments[i] = targetType.GetGenericTypeDefinition().MakeGenericType(genericArguments[i]);
				}
				else if (packetType.Assembly.GetType(target) is not { } targetType)
				{
					throw new Exception($"Packet {name} does not have definition for {target}!");
				}
				else
				{
					genericArguments[i] = targetType;
				}
			}

			packetType = packetType.MakeGenericType(genericArguments);
		}

		Dictionary<string, MappingStructure> fields = [];
		foreach (AbstractMappingSchema mapping in packet.Structure)
		{
			AbstractMappingSyntax syntax = MappingParser.Parse(mapping, packetType.Assembly.GetType("Skylight.Protocol.Attributes.GameProtocolAttribute")!.BaseType!.Assembly);

			if (mapping is FieldMappingSchema fieldMapping)
			{
				MemberInfo target = fieldMapping.Name == "this" ?
					packetType :
					packetType.GetProperty(fieldMapping.Name) ?? throw new Exception($"No definition for field {fieldMapping.Name} in type {packetType}");

				MappingStructure mappingStructure = new(fieldMapping.Name, syntax, target);

				mappings.Add(mappingStructure);
				fields.Add(fieldMapping.Name, mappingStructure);
			}
			else if (syntax is ConstantMappingSyntax { Type: TypeMappingSyntax typeMappingSyntax })
			{
				mappings.Add(new MappingStructure(null, syntax, typeMappingSyntax.Type));
			}
			else if (syntax is ConditionalMappingSyntax conditionalMapping)
			{
				if (conditionalMapping.WhenTrue is TypeMappingSyntax conditionalTypeMapping)
				{
					string fieldName = ((FieldMappingSchema)((ConditionalMappingSchema)mapping).WhenTrue).Name;

					PropertyInfo property = packetType.GetProperty(fieldName) ?? throw new Exception($"No definition for field {fieldName} in type {packetType}");

					MappingStructure mappingStructure = new(null, syntax, property);

					mappings.Add(mappingStructure);
					fields.Add(fieldName, mappingStructure);
				}
			}
			else
			{
				throw new NotSupportedException();
			}
		}

		return new PacketStructure(name, packet.Id!, packetType, mappings.MoveToImmutable(), fields);
	}

	private readonly ref struct Context()
	{
		internal Dictionary<string, ObjectStructure> Structures { get; } = [];

		internal void AddStructure(ObjectStructure structure)
		{
			this.Structures.Add(structure.Name, structure);
		}

		internal bool TryGetStructure(string name, [NotNullWhen(true)] out ObjectStructure? structure) => this.Structures.TryGetValue(name, out structure);
	}
}
