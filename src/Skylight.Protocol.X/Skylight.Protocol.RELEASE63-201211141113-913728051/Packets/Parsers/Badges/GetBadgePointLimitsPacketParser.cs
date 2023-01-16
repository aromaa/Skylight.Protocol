using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Badges;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Parsers.Badges;

[PacketParserId(2384u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetBadgePointLimitsPacketParser : IIncomingPacketParser<GetBadgePointLimitsPacketParser.GetBadgePointLimitsIncomingPacket>
{
	public GetBadgePointLimitsIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetBadgePointLimitsIncomingPacket();
	}

	internal readonly struct GetBadgePointLimitsIncomingPacket : IGetBadgePointLimitsIncomingPacket
	{
	}
}
