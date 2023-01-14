using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Room.Chat;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Parsers.Room.Chat;

[PacketParserId(3916u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class CancelTypingPacketParser : IIncomingPacketParser<CancelTypingPacketParser.CancelTypingIncomingPacket>
{
	public CancelTypingIncomingPacket Parse(ref PacketReader reader)
	{
		return new CancelTypingIncomingPacket();
	}

	internal readonly struct CancelTypingIncomingPacket : ICancelTypingIncomingPacket
	{
	}
}
