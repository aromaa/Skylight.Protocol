﻿using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Catalog;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Composers.Catalog;

[PacketComposerId(2826u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class CatalogPagePacketComposer : IOutgoingPacketComposer<CatalogPageOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in CatalogPageOutgoingPacket packet)
	{
		writer.WriteInt32(packet.PageId);
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
			writer.WriteInt32(offers.PriceInCredits);
			writer.WriteInt32(offers.PriceInActivityPoints);
			writer.WriteInt32(offers.ActivityPointsType);
			writer.WriteBool(offers.Giftable);
			writer.WriteInt32(offers.Products.Count);
			foreach (var products in offers.Products)
			{
				writer.WriteFixedUInt16String(products.Type.ToString());
				writer.WriteInt32(products.FurnitureId);
				writer.WriteFixedUInt16String(products.ExtraData);
				writer.WriteInt32(products.ProductCount);
				writer.WriteInt32(products.Expiration);
				writer.WriteBool(false);
			}
			writer.WriteInt32(offers.ClubLevel);
			writer.WriteBool(offers.BundlePurchaseAllowed);
		}
		writer.WriteInt32(packet.OfferId);
		writer.WriteBool(packet.AcceptSeasonCurrencyAsCredits);
	}
}
