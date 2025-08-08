using System.CodeDom.Compiler;
using System.Text;
using System.Text.RegularExpressions;
using Skylight.Protocol.Generator.Parser.Mapping;
using Skylight.Protocol.Generator.Structure;
using Skylight.Protocol.Generator.Structure.Mapping;
using Skylight.Protocol.Generator.Writer.Handlers;

namespace Skylight.Protocol.Generator.Writer;

internal static partial class PacketConsumerWriter
{
	internal static void Write(Stream stream, ProtocolStructure protocol, PacketStructure packet)
	{
		using IndentedTextWriter writer = new(new StreamWriter(stream, Encoding.UTF8), "\t");

		Write(writer, protocol, packet);

		writer.Flush();
	}

	internal static void Write(TextWriter stream, ProtocolStructure protocol, PacketStructure packet)
	{
		Dictionary<Type, MappingWriterHandler> handlers = new()
		{
			{ typeof(TypeMappingSyntax), new TypeMappingWriteHandler() },
			{ typeof(GenericTypeMappingSyntax), new GenericTypeMappingWriteHandler() },
			{ typeof(ObjectMappingSyntax), new ObjectMappingWriteHandler() },
			{ typeof(ConstantMappingSyntax), new ConstantMappingWriteHandler() },
			{ typeof(ConditionalMappingSyntax), new ConditionalMappingWriteHandler() },
			{ typeof(CombineMappingSyntax), new CombineMappingWriteHandler() }
		};

		using IndentedTextWriter writer = new(stream, "\t");

		string revision = protocol.Revision.Replace('-', '_');

		string name = packet.Name;

		int groupIdentifier = name.LastIndexOf('.');

		string packetGroup = name.Substring(0, groupIdentifier);
		string packetName = name.Substring(groupIdentifier + 1);

		writer.WriteLine($"using System.Globalization;");
		writer.WriteLine($"using Skylight.Protocol.Extensions;");
		writer.WriteLine($"using Skylight.Protocol.Packets.Outgoing.{packetGroup};");
		writer.WriteLine($"using Net.Buffers;");
		writer.WriteLine($"using Net.Communication.Attributes;");
		writer.WriteLine($"using Net.Communication.Outgoing;");
		writer.WriteLine();
		writer.WriteLine($"namespace Skylight.Protocol.{revision}.Packets.Composers.{packetGroup};");
		writer.WriteLine();

		string? appendHeader = null;
		if (packet.Id is int packetId)
		{
			writer.WriteLine($"[PacketComposerId({packetId}u)]");
		}
		else if (packet.Id is string stringPacketId)
		{
			Regex.ValueMatchEnumerator enumerator = PacketConsumerWriter.ParseDynamicVariablePlaceholder().EnumerateMatches(stringPacketId);
			if (!enumerator.MoveNext())
			{
				writer.WriteLine($"[PacketComposerId(\"{stringPacketId}\")]");
			}
			else
			{
				writer.WriteLine($"[PacketComposerId(\"{stringPacketId.AsSpan(0, enumerator.Current.Index)}\")]");

				ValueMatch match = enumerator.Current;

				//Matching the whole string, remove the brackets
				appendHeader = stringPacketId.AsSpan(match.Index + 1, match.Length - 2).ToString();
			}
		}

		StringBuilder composerGenerics = new();
		StringBuilder packetGenerics = new();
		List<string> genericConstraints = [];
		if (packet.Type.IsGenericType)
		{
			composerGenerics.Append('<');
			packetGenerics.Append('<');

			Type[] originalGenericArguments = packet.Type.GetGenericTypeDefinition().GetGenericArguments();
			for (int i = 0; i < originalGenericArguments.Length; i++)
			{
				if (i > 0)
				{
					composerGenerics.Append(", ");
					packetGenerics.Append(", ");
				}

				Type genericArgument = originalGenericArguments[i];

				composerGenerics.Append(genericArgument.Name);
				composerGenerics.Append(", ");
				composerGenerics.Append($"{genericArgument.Name}Converter");

				packetGenerics.Append(genericArgument.Name);
			}

			composerGenerics.Append('>');
			packetGenerics.Append('>');

			Type[] genericArguments = packet.Type.GetGenericArguments();
			for (int i = 0; i < genericArguments.Length; i++)
			{
				Type genericArgument = genericArguments[i];

				string genericArgumentName = genericArgument.ToString();
				StringBuilder constraintGenericArguments = new();
				if (genericArgument.IsGenericType)
				{
					constraintGenericArguments.Append('<');

					Type[] constraintGenericArgumentTypes = genericArgument.GetGenericArguments();
					for (int j = 0; j < constraintGenericArgumentTypes.Length; j++)
					{
						if (j > 0)
						{
							constraintGenericArguments.Append(", ");
						}

						constraintGenericArguments.Append(constraintGenericArgumentTypes[j].Name);
					}

					constraintGenericArguments.Append('>');

					genericArgumentName = genericArgumentName[..genericArgumentName.IndexOf('`')];
				}

				genericConstraints.Add($"{originalGenericArguments[i]}Converter : {genericArgumentName}{constraintGenericArguments}");
			}
		}

		writer.WriteLine($"[PacketManagerRegister(typeof(GamePacketManager))]");
		writer.WriteLine($"internal sealed class {packetName}PacketComposer{composerGenerics} : {(appendHeader is not null
			? $"Skylight.Protocol.Packets.Outgoing.IGameOutgoingPacketComposer<{packetName}OutgoingPacket{packetGenerics}>"
			: $"IOutgoingPacketComposer<{packetName}OutgoingPacket{packetGenerics}>")}");

		writer.Indent++;
		foreach (string genericConstraint in genericConstraints)
		{
			writer.WriteLine($"where {genericConstraint}");
		}

		writer.Indent--;

		writer.WriteLine($"{{");
		writer.Indent++;
		if (appendHeader is not null)
		{
			writer.WriteLine($"public void AppendHeader(ref PacketWriter writer, in {packetName}OutgoingPacket{packetGenerics} packet)");
			writer.WriteLine($"{{");
			writer.Indent++;
			writer.WriteLine($"writer.WriteBytes(System.Text.Encoding.ASCII.GetBytes(packet.{appendHeader}.ToString()));");
			writer.Indent--;
			writer.WriteLine($"}}");
			writer.WriteLine();
		}

		writer.WriteLine($"public void Compose(ref PacketWriter writer, in {packetName}OutgoingPacket{packetGenerics} packet)");
		writer.WriteLine($"{{");
		writer.Indent++;

		WriterContext context = new(packet, handlers);

		using (context.PushScope("packet"))
		{
			foreach (MappingStructure mapping in packet.Mapping)
			{
				if (mapping.Name == "this")
				{
					context.Write(protocol, writer, mapping.Syntax, mapping.Type);

					continue;
				}

				using (context.PushScope(mapping.Name))
				{
					context.Write(protocol, writer, mapping.Syntax, mapping.Type);
				}
			}
		}

		writer.Indent--;
		writer.WriteLine($"}}");
		writer.Indent--;
		writer.WriteLine($"}}");
	}

	[GeneratedRegex("{[^}]+}", RegexOptions.CultureInvariant)]
	private static partial Regex ParseDynamicVariablePlaceholder();
}
