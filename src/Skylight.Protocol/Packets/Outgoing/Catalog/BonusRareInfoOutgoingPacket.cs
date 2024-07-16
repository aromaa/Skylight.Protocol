using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Catalog;

public sealed class BonusRareInfoOutgoingPacket : IGameOutgoingPacket
{
	public required string ProductType { get; init; }
	public required int ProductClassId { get; init; }
	public required int TotalCoinsForBonus { get; init; }
	public required int CoinsStillRequiredToBuy { get; init; }

	public BonusRareInfoOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public BonusRareInfoOutgoingPacket(string productType, int productClassId, int totalCoinsForBonus, int coinsStillRequiredToBuy)
	{
		this.ProductType = productType;
		this.ProductClassId = productClassId;
		this.TotalCoinsForBonus = totalCoinsForBonus;
		this.CoinsStillRequiredToBuy = coinsStillRequiredToBuy;
	}
}
