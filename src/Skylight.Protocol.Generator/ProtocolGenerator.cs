using System.Reflection;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using Skylight.Protocol.Generator.Parser;
using Skylight.Protocol.Generator.Schema;
using Skylight.Protocol.Generator.Structure;
using Skylight.Protocol.Generator.Writer;

namespace Skylight.Protocol.Generator;

public static class ProtocolGenerator
{
	public static JsonSerializerOptions JsonSerializerOptions { get; set; } = new()
	{
		Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
		WriteIndented = true,
		DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
	};

	public static void Run(string directory, ProtocolSchema schema, Assembly protocolAssembly)
	{
		string packetsDir = Path.Join(directory, "Packets");
		if (Directory.Exists(packetsDir))
		{
			Directory.Delete(packetsDir, true);
		}

		Directory.CreateDirectory(packetsDir);

		ProtocolStructure protocol = ProtocolParser.Parse(schema, protocolAssembly);

		{
			StringWriter writer = new();

			PacketManagerWriter.Write(writer, protocol);

			_ = File.WriteAllTextAsync(Path.Join(packetsDir, "GamePacketManager.cs"), writer.ToString(), Encoding.UTF8);
		}

		foreach (PacketStructure packet in protocol.Incoming.Values)
		{
			if (protocol.Protocol is "Fuse")
			{
				if (packet.Id is not string)
				{
					continue;
				}
			}
			else
			{
				if (packet.Id is not int)
				{
					continue;
				}
			}

			int groupIdentifier = packet.Name.LastIndexOf('.');

			string packetGroup = packet.Name.Substring(0, groupIdentifier);
			string packetName = packet.Name.Substring(groupIdentifier + 1);

			string dir = Path.Join(packetsDir, "Parsers", Path.Join(packetGroup.Split('.')));
			if (!Directory.Exists(dir))
			{
				Directory.CreateDirectory(dir);
			}

			StringWriter writer = new();

			PacketParserWriter.Write(writer, protocol, packet);

			_ = File.WriteAllTextAsync(Path.Join(dir, $"{packetName}PacketParser.cs"), writer.ToString(), Encoding.UTF8);
		}

		foreach (PacketStructure packet in protocol.Outgoing.Values)
		{
			if (protocol.Protocol is "Fuse")
			{
				if (packet.Id is not string)
				{
					continue;
				}
			}
			else
			{
				if (packet.Id is not int)
				{
					continue;
				}
			}

			int groupIdentifier = packet.Name.LastIndexOf('.');

			string packetGroup = packet.Name.Substring(0, groupIdentifier);
			string packetName = packet.Name.Substring(groupIdentifier + 1);

			string dir = Path.Join(packetsDir, "Composers", Path.Join(packetGroup.Split('.')));
			if (!Directory.Exists(dir))
			{
				Directory.CreateDirectory(dir);
			}

			StringWriter writer = new();

			PacketConsumerWriter.Write(writer, protocol, packet);

			_ = File.WriteAllTextAsync(Path.Join(dir, $"{packetName}PacketComposer.cs"), writer.ToString(), Encoding.UTF8);
		}
	}
}
