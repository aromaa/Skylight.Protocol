using System.CodeDom.Compiler;
using System.Text;
using Skylight.Protocol.Generator.Structure;

namespace Skylight.Protocol.Generator.Writer;

internal static class PacketManagerWriter
{
	internal static void Write(Stream stream, ProtocolStructure protocol)
	{
		using IndentedTextWriter writer = new(new StreamWriter(stream, Encoding.UTF8), "\t");

		Write(writer, protocol);
	}

	internal static void Write(TextWriter stream, ProtocolStructure protocol)
	{
		using IndentedTextWriter writer = new(stream, "\t");

		string revision = protocol.Revision.Replace('-', '_');

		writer.WriteLine($"using Skylight.Protocol.Attributes;");
		writer.WriteLine($"using Skylight.Protocol.Packets.Manager;");
		writer.WriteLine($"using Skylight.Protocol.{revision}.Packets;");
		writer.WriteLine();
		writer.WriteLine($"[assembly: GameProtocol(\"{protocol.Revision}\")]");
		writer.WriteLine($"[assembly: GameProtocolManager<GamePacketManager>]");
		writer.WriteLine();
		writer.WriteLine($"namespace Skylight.Protocol.{revision}.Packets;");
		writer.WriteLine();
		writer.WriteLine($"public class GamePacketManager : AbstractGamePacketManager, IGameProtocol");
		writer.WriteLine($"{{");
		writer.Indent++;
		writer.WriteLine($"public override bool Modern => {(protocol.Protocol is "Modern" ? "true" : "false")};");
		writer.WriteLineNoTabs(string.Empty);
		writer.WriteLine($"public GamePacketManager(IServiceProvider serviceProvider) : base(serviceProvider)");
		writer.WriteLine($"{{");
		writer.WriteLine($"}}");
		writer.WriteLineNoTabs(string.Empty);
		writer.WriteLine($"public static AbstractGamePacketManager CreatePacketManager(IServiceProvider serviceProvider) => new GamePacketManager(serviceProvider);");
		writer.Indent--;
		writer.WriteLine($"}}");
	}
}
