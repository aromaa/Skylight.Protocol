using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Inventory.Badges;

namespace Skylight.Protocol.Packets.Outgoing.Inventory.Badges;

public sealed class BadgePointLimitsOutgoingPacket : IGameOutgoingPacket
{
	public required ICollection<BadgePointLimitData> BadgePointLimits { get; init; }

	public BadgePointLimitsOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public BadgePointLimitsOutgoingPacket(ICollection<BadgePointLimitData> badgePointLimits)
	{
		this.BadgePointLimits = badgePointLimits;
	}
}
