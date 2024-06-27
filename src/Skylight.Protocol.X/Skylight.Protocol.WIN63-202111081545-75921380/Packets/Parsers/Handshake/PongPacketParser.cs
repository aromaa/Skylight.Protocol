using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Handshake;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Handshake;

[PacketParserId(182u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class PongPacketParser : IIncomingPacketParser<PongPacketParser.PongIncomingPacket>
{
	public PongIncomingPacket Parse(ref PacketReader reader)
	{
		return new PongIncomingPacket();
	}

	internal readonly struct PongIncomingPacket : IPongIncomingPacket
	{
	}
}
