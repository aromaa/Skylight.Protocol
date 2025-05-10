using System.Buffers;
using System.Buffers.Text;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Handshake;
using Net.Buffers;
using Net.Buffers.Extensions;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE1.Packets.Parsers.Handshake;

[PacketParserId("STATUSOK")]
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
