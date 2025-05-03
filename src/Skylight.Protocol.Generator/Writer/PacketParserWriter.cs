using System.Buffers;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Text;
using Skylight.Protocol.Generator.Extensions;
using Skylight.Protocol.Generator.Parser.Mapping;
using Skylight.Protocol.Generator.Structure;
using Skylight.Protocol.Generator.Structure.Mapping;
using Skylight.Protocol.Generator.Writer.Handlers;

namespace Skylight.Protocol.Generator.Writer;

internal static class PacketParserWriter
{
	internal static void Write(Stream stream, ProtocolStructure protocol, PacketStructure packet)
	{
		using IndentedTextWriter writer = new(new StreamWriter(stream, Encoding.UTF8), "\t");

		Write(writer, protocol, packet);
	}

	internal static void Write(TextWriter stream, ProtocolStructure protocol, PacketStructure packet)
	{
		Dictionary<Type, MappingWriterHandler> handlers = new()
		{
			{ typeof(TypeMappingSyntax), new TypeMappingWriteHandler() },
			{ typeof(ConditionalMappingSyntax), new ConditionalMappingWriteHandler() },
			{ typeof(GenericTypeMappingSyntax), new GenericTypeMappingWriteHandler() }
		};

		using IndentedTextWriter writer = new(stream, "\t");

		string revision = protocol.Revision.Replace('-', '_');

		string name = packet.Name;

		int groupIdentifier = name.LastIndexOf('.');

		string packetGroup = name.Substring(0, groupIdentifier);
		string packetName = name.Substring(groupIdentifier + 1);

		writer.WriteLine($"using System.Buffers;");
		if (protocol.Protocol is "Fuse")
		{
			writer.WriteLine($"using System.Buffers.Text;");
		}

		writer.WriteLine($"using Skylight.Protocol.Extensions;");
		writer.WriteLine($"using Skylight.Protocol.Packets.Incoming.{packetGroup};");
		writer.WriteLine($"using Net.Buffers;");
		if (protocol.Protocol is "Fuse")
		{
			writer.WriteLine($"using Net.Buffers.Extensions;");
		}

		writer.WriteLine($"using Net.Communication.Attributes;");
		writer.WriteLine($"using Net.Communication.Incoming.Parser;");
		writer.WriteLine();
		writer.WriteLine($"namespace Skylight.Protocol.{revision}.Packets.Parsers.{packetGroup};");
		writer.WriteLine();
		if (packet.Id is int packetId)
		{
			writer.WriteLine($"[PacketParserId({packet.Id}u)]");
		}
		else
		{
			writer.WriteLine($"[PacketParserId(\"{packet.Id}\")]");
		}

		writer.WriteLine($"[PacketManagerRegister(typeof(GamePacketManager))]");
		writer.WriteLine($"internal sealed class {packetName}PacketParser : IIncomingPacketParser<{packetName}PacketParser.{packetName}IncomingPacket>");
		writer.WriteLine($"{{");
		writer.Indent++;
		writer.WriteLine($"public {packetName}IncomingPacket Parse(ref PacketReader reader)");
		writer.WriteLine($"{{");
		writer.Indent++;

		WriterContext context = new(handlers);

		if (packet.Mapping.Length > 0)
		{
			writer.WriteLine($"return new {packetName}IncomingPacket");
			writer.WriteLine($"{{");
			writer.Indent++;

			bool first = true;

			foreach ((string field, MappingStructure mapping) in packet.Fields)
			{
				if (first)
				{
					first = false;
				}
				else
				{
					writer.WriteLine(',');
				}

				writer.Write($"{field} = ");

				using (context.PushScope(field))
				{
					context.Read(protocol, writer, mapping.Syntax, mapping.Type);
				}
			}

			writer.WriteLine();
			writer.Indent--;
			writer.WriteLine($"}};");

			foreach ((string field, MappingStructure mapping) in packet.Fields)
			{
				using (context.PushScope(field))
				{
					context.ReadPost(protocol, writer, mapping.Syntax, mapping.Type);
				}
			}
		}
		else
		{
			writer.WriteLine($"return new {packetName}IncomingPacket();");
		}

		writer.Indent--;
		writer.WriteLine($"}}");
		writer.Indent--;
		writer.WriteLine();
		writer.Indent++;
		writer.WriteLine($"internal readonly struct {packetName}IncomingPacket : I{packetName}IncomingPacket");
		writer.WriteLine($"{{");
		writer.Indent++;
		foreach (PropertyInfo property in packet.Type.GetProperties())
		{
			if (packet.Fields.ContainsKey(property.Name))
			{
				writer.WriteLine($"public {GetTypeName(property.PropertyType)} {property.Name} {{ get; init; }}");
			}
			else
			{
				writer.WriteLine($"public {GetTypeName(property.PropertyType)} {property.Name} => default;");
			}
		}

		writer.Indent--;
		writer.WriteLine($"}}");
		writer.Indent--;
		writer.WriteLine($"}}");
	}

	internal static string GetTypeName(Type type)
	{
		if (type == typeof(uint).FromAssembly(type))
		{
			return "uint";
		}
		else if (type == typeof(int).FromAssembly(type))
		{
			return "int";
		}
		else if (type == typeof(bool).FromAssembly(type))
		{
			return "bool";
		}
		else if (type == typeof(ReadOnlySequence<byte>).FromAssembly(type))
		{
			return "ReadOnlySequence<byte>";
		}
		else if (type == typeof(IList<int>).FromAssembly(type))
		{
			return "IList<int>";
		}
		else if (type == typeof(IList<ReadOnlySequence<byte>>).FromAssembly(type))
		{
			return "IList<ReadOnlySequence<byte>>";
		}
		else if (type.IsGenericType)
		{
			throw new NotSupportedException(type.ToString());
		}

		return $"{type.Namespace}.{type.Name}";
	}
}
