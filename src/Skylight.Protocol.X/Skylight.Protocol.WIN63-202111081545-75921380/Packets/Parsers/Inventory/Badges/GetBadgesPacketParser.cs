using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Inventory.Badges;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Inventory.Badges;

[PacketParserId(786u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetBadgesPacketParser : IIncomingPacketParser<GetBadgesPacketParser.GetBadgesIncomingPacket>
{
	public GetBadgesIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetBadgesIncomingPacket();
	}

	internal readonly struct GetBadgesIncomingPacket : IGetBadgesIncomingPacket
	{
	}
}
