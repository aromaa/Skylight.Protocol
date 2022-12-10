using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Skylight.Protocol.Generator.Parser.Mapping;
using Skylight.Protocol.Generator.Schema;
using Skylight.Protocol.Generator.Schema.Mapping;
using Skylight.Protocol.Generator.Structure;
using Skylight.Protocol.Generator.Structure.Mapping;
using Skylight.Protocol.Packets.Incoming;
using Skylight.Protocol.Packets.Outgoing;

namespace Skylight.Protocol.Generator.Parser;

internal static class ProtocolParser
{
	internal static ProtocolStructure Parse(ProtocolSchema protocol)
	{
		Context context = new();

		foreach ((string name, List<AbstractMappingSchema> structure) in protocol.Structures)
		{
			ImmutableArray<(string? FieldName, AbstractMappingSyntax Mapping)>.Builder mappings = ImmutableArray.CreateBuilder<(string?, AbstractMappingSyntax)>(structure.Count);

			Dictionary<string, AbstractMappingSyntax> fields = new();

			bool recursive = false;

			foreach (AbstractMappingSchema mapping in structure)
			{
				AbstractMappingSyntax syntax = MappingParser.Parse(mapping);

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

		Dictionary<string, PacketStructure> incoming = new();
		foreach ((string name, PacketSchema packet) in protocol.Incoming)
		{
			PacketStructure structure = Parse(ref context, packet, typeof(IGameIncomingPacket), name);

			incoming.Add(structure.Name, structure);
		}

		Dictionary<string, PacketStructure> outgoing = new();
		foreach ((string name, PacketSchema packet) in protocol.Outgoing)
		{
			PacketStructure structure = Parse(ref context, packet, typeof(IGameOutgoingPacket), name);

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
		if (interfaceType == typeof(IGameIncomingPacket))
		{
			packetInterface = interfaceType.Assembly.GetType($"{interfaceType.Namespace}.{packetGroup}.I{packetName}IncomingPacket");
		}
		else if (interfaceType == typeof(IGameOutgoingPacket))
		{
			packetInterface = interfaceType.Assembly.GetType($"{interfaceType.Namespace}.{packetGroup}.{packetName}OutgoingPacket");
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
		ImmutableArray<MappingStructure>.Builder mappings = ImmutableArray.CreateBuilder<MappingStructure>(packet.Structure.Count);

		Dictionary<string, MappingStructure> fields = new();

		foreach (AbstractMappingSchema mapping in packet.Structure)
		{
			AbstractMappingSyntax syntax = MappingParser.Parse(mapping);

			if (mapping is FieldMappingSchema fieldMapping)
			{
				PropertyInfo? property = packetType.GetProperty(fieldMapping.Name);
				if (property is null)
				{
					throw new Exception($"No definition for field {fieldMapping.Name} in type {packetType}");
				}

				MappingStructure mappingStructure = new(fieldMapping.Name, syntax, property);

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

					PropertyInfo? property = packetType.GetProperty(fieldName);
					if (property is null)
					{
						throw new Exception($"No definition for field {fieldName} in type {packetType}");
					}

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

		return new PacketStructure(name, packet.Id, packetType, mappings.MoveToImmutable(), fields);
	}

	private readonly ref struct Context
	{
		public Context()
		{
			this.Structures = new Dictionary<string, ObjectStructure>();
		}

		internal Dictionary<string, ObjectStructure> Structures { get; }

		internal void AddStructure(ObjectStructure structure)
		{
			this.Structures.Add(structure.Name, structure);
		}

		internal bool TryGetStructure(string name, [NotNullWhen(true)] out ObjectStructure? structure) => this.Structures.TryGetValue(name, out structure);
	}
}
