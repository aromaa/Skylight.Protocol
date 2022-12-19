using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Catalog;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Catalog;

[PacketComposerId(3314u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class CatalogPagePacketComposer : IOutgoingPacketComposer<CatalogPageOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in CatalogPageOutgoingPacket packet)
	{
		writer.WriteInt32(packet.PageId);
		writer.WriteFixedUInt16String(packet.CatalogType);
		writer.WriteFixedUInt16String(packet.LayoutCode);
		writer.WriteInt32(packet.Images.Count);
		foreach (var images in packet.Images)
		{
			writer.WriteFixedUInt16String(images);
		}
		writer.WriteInt32(packet.Texts.Count);
		foreach (var texts in packet.Texts)
		{
			writer.WriteFixedUInt16String(texts);
		}
		writer.WriteInt32(packet.Offers.Count);
		foreach (var offers in packet.Offers)
		{
			writer.WriteInt32(offers.Id);
			writer.WriteFixedUInt16String(offers.LocalizationId);
			writer.WriteBool(offers.IsRent);
			writer.WriteInt32(offers.PriceInCredits);
			writer.WriteInt32(offers.PriceInActivityPoints);
			writer.WriteInt32(offers.ActivityPointsType);
			writer.WriteBool(offers.Giftable);
			writer.WriteInt32(offers.Products.Count);
			foreach (var products in offers.Products)
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
			writer.WriteInt32(offers.ClubLevel);
			writer.WriteBool(offers.BundlePurchaseAllowed);
			writer.WriteBool(false);
			writer.WriteFixedUInt16String(offers.PreviewImage);
		}
		writer.WriteInt32(packet.OfferId);
		writer.WriteBool(packet.AcceptSeasonCurrencyAsCredits);
		writer.WriteInt32(packet.FrontPageItems.Count);
		foreach (var frontPageItems in packet.FrontPageItems)
		{
		}
	}
}
