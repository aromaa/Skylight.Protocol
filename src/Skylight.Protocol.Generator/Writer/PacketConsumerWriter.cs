using System.CodeDom.Compiler;
using System.Text;
using Skylight.Protocol.Generator.Parser.Mapping;
using Skylight.Protocol.Generator.Structure;
using Skylight.Protocol.Generator.Structure.Mapping;
using Skylight.Protocol.Generator.Writer.Handlers;

namespace Skylight.Protocol.Generator.Writer;

internal static class PacketConsumerWriter
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
		if (packet.Id is int packetId)
		{
			writer.WriteLine($"[PacketComposerId({packetId}u)]");
		}
		else
		{
			writer.WriteLine($"[PacketComposerId(\"{packet.Id}\")]");
		}

		writer.WriteLine($"[PacketManagerRegister(typeof(GamePacketManager))]");
		writer.WriteLine($"internal sealed class {packetName}PacketComposer : IOutgoingPacketComposer<{packetName}OutgoingPacket>");
		writer.WriteLine($"{{");
		writer.Indent++;
		writer.WriteLine($"public void Compose(ref PacketWriter writer, in {packetName}OutgoingPacket packet)");
		writer.WriteLine($"{{");
		writer.Indent++;

		WriterContext context = new(handlers);

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
}
