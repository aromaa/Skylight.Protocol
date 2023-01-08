using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Room.Chat;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Room.Chat;

[PacketParserId(1067u)]
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
