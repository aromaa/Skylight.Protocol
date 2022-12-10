using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Catalog;

namespace Skylight.Protocol.Packets.Outgoing.Catalog;

public sealed class CatalogPageOutgoingPacket : IGameOutgoingPacket
{
	public required string CatalogType { get; init; }

	public required int PageId { get; init; }
	public required int OfferId { get; init; }

	public required string LayoutCode { get; init; }

	public required ICollection<string> Images { get; init; }
	public required ICollection<string> Texts { get; init; }

	public required bool AcceptSeasonCurrencyAsCredits { get; init; }

	public required ICollection<CatalogOfferData> Offers { get; init; }

	public required ICollection<CatalogFrontPageItemData> FrontPageItems { get; init; }

	public CatalogPageOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public CatalogPageOutgoingPacket(string catalogType, int pageId, int offerId, string layoutCode, ICollection<string> images, ICollection<string> texts, bool acceptSeasonCurrencyAsCredits, ICollection<CatalogOfferData> offers, ICollection<CatalogFrontPageItemData> frontPageItems)
	{
		this.CatalogType = catalogType;

		this.PageId = pageId;
		this.OfferId = offerId;

		this.LayoutCode = layoutCode;

		this.Images = images;
		this.Texts = texts;

		this.AcceptSeasonCurrencyAsCredits = acceptSeasonCurrencyAsCredits;

		this.Offers = offers;

		this.FrontPageItems = frontPageItems;
	}
}
