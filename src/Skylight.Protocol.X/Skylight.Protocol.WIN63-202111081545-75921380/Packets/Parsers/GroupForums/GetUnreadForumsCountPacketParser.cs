using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.GroupForums;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.GroupForums;

[PacketParserId(1282u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetUnreadForumsCountPacketParser : IIncomingPacketParser<GetUnreadForumsCountPacketParser.GetUnreadForumsCountIncomingPacket>
{
	public GetUnreadForumsCountIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetUnreadForumsCountIncomingPacket();
	}

	internal readonly struct GetUnreadForumsCountIncomingPacket : IGetUnreadForumsCountIncomingPacket
	{
	}
}
