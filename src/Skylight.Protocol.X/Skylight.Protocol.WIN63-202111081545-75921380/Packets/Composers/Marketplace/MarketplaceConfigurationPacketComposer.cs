using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Marketplace;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Marketplace;

[PacketComposerId(3958u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class MarketplaceConfigurationPacketComposer : IOutgoingPacketComposer<MarketplaceConfigurationOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in MarketplaceConfigurationOutgoingPacket packet)
	{
		writer.WriteBool(packet.Enabled);
		writer.WriteInt32(packet.Commission);
		writer.WriteInt32(packet.TokenOfferPrice);
		writer.WriteInt32(packet.TokenOfferAmount);
		writer.WriteInt32(packet.OfferMinPrice);
		writer.WriteInt32(packet.OfferMaxPrice);
		writer.WriteInt32(packet.OfferExpirationHours);
		writer.WriteInt32(packet.ItemPricePeriod);
		writer.WriteInt32(packet.SellingFeePercentage);
		writer.WriteInt32(packet.RevenueLimit);
		writer.WriteInt32(packet.HalfTaxLimit);
	}
}
