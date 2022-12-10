using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Catalog;

namespace Skylight.Protocol.Packets.Outgoing.Catalog;

public sealed class PurchaseOKOutgoingPacket : IGameOutgoingPacket
{
	public required CatalogOfferData Offer { get; init; }

	public PurchaseOKOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public PurchaseOKOutgoingPacket(CatalogOfferData offer)
	{
		this.Offer = offer;
	}
}
