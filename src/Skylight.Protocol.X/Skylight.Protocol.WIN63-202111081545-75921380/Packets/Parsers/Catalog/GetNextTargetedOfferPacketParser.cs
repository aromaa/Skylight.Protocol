using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Catalog;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Catalog;

[PacketParserId(3050u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetNextTargetedOfferPacketParser : IIncomingPacketParser<GetNextTargetedOfferPacketParser.GetNextTargetedOfferIncomingPacket>
{
	public GetNextTargetedOfferIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetNextTargetedOfferIncomingPacket();
	}

	internal readonly struct GetNextTargetedOfferIncomingPacket : IGetNextTargetedOfferIncomingPacket
	{
	}
}
