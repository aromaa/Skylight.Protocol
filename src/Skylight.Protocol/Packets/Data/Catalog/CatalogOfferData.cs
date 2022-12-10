using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.Catalog;

public sealed class CatalogOfferData
{
	public required int Id { get; init; }

	public required string LocalizationId { get; init; }

	public required bool IsRent { get; init; }
	public required bool Giftable { get; init; }
	public required bool BundlePurchaseAllowed { get; init; }

	public required int ClubLevel { get; init; }

	public required int PriceInCredits { get; init; }
	public required int PriceInActivityPoints { get; init; }
	public required int ActivityPointsType { get; init; }

	public required ICollection<CatalogProductData> Products { get; init; }

	public required string PreviewImage { get; init; }

	public CatalogOfferData()
	{
	}

	[SetsRequiredMembers]
	public CatalogOfferData(int id, string localizationId, bool isRent, bool giftable, bool bundlePurchaseAllowed, int clubLevel, int priceInCredits, int priceInActivityPoints, int activityPointsType, ICollection<CatalogProductData> products, string previewImage)
	{
		this.Id = id;

		this.LocalizationId = localizationId;

		this.IsRent = isRent;
		this.Giftable = giftable;
		this.BundlePurchaseAllowed = bundlePurchaseAllowed;

		this.ClubLevel = clubLevel;

		this.PriceInCredits = priceInCredits;
		this.PriceInActivityPoints = priceInActivityPoints;
		this.ActivityPointsType = activityPointsType;

		this.Products = products;

		this.PreviewImage = previewImage;
	}
}
