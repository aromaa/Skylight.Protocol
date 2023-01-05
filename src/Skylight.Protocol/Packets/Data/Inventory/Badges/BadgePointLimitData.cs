using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.Inventory.Badges;

public sealed class BadgePointLimitData
{
	public required string BadgeCode { get; init; }

	public required ICollection<(int Level, int Limit)> Limits { get; init; }

	public BadgePointLimitData()
	{
	}

	[SetsRequiredMembers]
	public BadgePointLimitData(string badgeCode, ICollection<(int Level, int Limit)> limits)
	{
		this.BadgeCode = badgeCode;
		this.Limits = limits;
	}
}
