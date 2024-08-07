using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Catalog;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Catalog;

[PacketComposerId(2783u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class ProductOfferPacketComposer : IOutgoingPacketComposer<ProductOfferOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in ProductOfferOutgoingPacket packet)
	{
		writer.WriteInt32(packet.Offer.Id);
		writer.WriteFixedUInt16String(packet.Offer.LocalizationId);
		writer.WriteBool(packet.Offer.IsRent);
		writer.WriteInt32(packet.Offer.PriceInCredits);
		writer.WriteInt32(packet.Offer.PriceInActivityPoints);
		writer.WriteInt32(packet.Offer.ActivityPointsType);
		writer.WriteBool(packet.Offer.Giftable);
		writer.WriteInt32(packet.Offer.Products.Count);
		foreach (var products in packet.Offer.Products)
		{
			if (products.Type is Skylight.Protocol.Packets.Data.Room.Object.FurnitureType.Badge)
			{
				writer.WriteFixedUInt16String("b");
				writer.WriteFixedUInt16String(products.ExtraData);
			}
			else if (products.Type is Skylight.Protocol.Packets.Data.Room.Object.FurnitureType.Floor)
			{
				writer.WriteFixedUInt16String("s");
				writer.WriteInt32(products.FurnitureId);
				writer.WriteFixedUInt16String(products.ExtraData);
				writer.WriteInt32(products.ProductCount);
				writer.WriteBool(false);
			}
			else if (products.Type is Skylight.Protocol.Packets.Data.Room.Object.FurnitureType.Wall)
			{
				writer.WriteFixedUInt16String("i");
				writer.WriteInt32(products.FurnitureId);
				writer.WriteFixedUInt16String(products.ExtraData);
				writer.WriteInt32(products.ProductCount);
				writer.WriteBool(false);
			}
			else
			{
				throw new NotSupportedException();
			}
		}
		writer.WriteInt32(packet.Offer.ClubLevel);
		writer.WriteBool(packet.Offer.BundlePurchaseAllowed);
		writer.WriteBool(false);
		writer.WriteFixedUInt16String(packet.Offer.PreviewImage);
	}
}
