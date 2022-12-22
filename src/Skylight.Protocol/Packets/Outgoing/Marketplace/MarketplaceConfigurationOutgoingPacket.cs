using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Marketplace;

public sealed class MarketplaceConfigurationOutgoingPacket : IGameOutgoingPacket
{
	public required bool Enabled { get; init; }
	public required int Commission { get; init; }
	public required int TokenOfferPrice { get; init; }
	public required int TokenOfferAmount { get; init; }
	public required int OfferMinPrice { get; init; }
	public required int OfferMaxPrice { get; init; }
	public required int OfferExpirationHours { get; init; }
	public required int ItemPricePeriod { get; init; }
	public required int SellingFeePercentage { get; init; }
	public required int RevenueLimit { get; init; }
	public required int HalfTaxLimit { get; init; }

	public MarketplaceConfigurationOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public MarketplaceConfigurationOutgoingPacket(bool enabled, int commission, int tokenOfferPrice, int tokenOfferAmount, int offerMinPrice, int offerMaxPrice, int offerExpirationHours, int itemPricePeriod, int sellingFeePercentage, int revenueLimit, int halfTaxLimit)
	{
		this.Enabled = enabled;
		this.Commission = commission;
		this.TokenOfferPrice = tokenOfferPrice;
		this.TokenOfferAmount = tokenOfferAmount;
		this.OfferMinPrice = offerMinPrice;
		this.OfferMaxPrice = offerMaxPrice;
		this.OfferExpirationHours = offerExpirationHours;
		this.ItemPricePeriod = itemPricePeriod;
		this.SellingFeePercentage = sellingFeePercentage;
		this.RevenueLimit = revenueLimit;
		this.HalfTaxLimit = halfTaxLimit;
	}
}
