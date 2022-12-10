using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Handshake;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Parsers.Handshake;

[PacketParserId(2996u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class InitDiffieHandshakePacketParser : IIncomingPacketParser<InitDiffieHandshakePacketParser.InitDiffieHandshakeIncomingPacket>
{
	public InitDiffieHandshakeIncomingPacket Parse(ref PacketReader reader)
	{
		return new InitDiffieHandshakeIncomingPacket();
	}

	internal readonly struct InitDiffieHandshakeIncomingPacket : IInitDiffieHandshakeIncomingPacket
	{
	}
}
