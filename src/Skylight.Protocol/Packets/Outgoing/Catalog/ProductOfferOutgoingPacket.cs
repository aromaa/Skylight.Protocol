using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Catalog;

namespace Skylight.Protocol.Packets.Outgoing.Catalog;

public sealed class ProductOfferOutgoingPacket : IGameOutgoingPacket
{
	public required CatalogOfferData Offer { get; init; }

	public ProductOfferOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public ProductOfferOutgoingPacket(CatalogOfferData offer)
	{
		this.Offer = offer;
	}
}
