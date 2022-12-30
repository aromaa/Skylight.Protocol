using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Inventory.Badges;

public sealed class BadgeReceivedOutgoingPacket : IGameOutgoingPacket
{
	public required int BadgeId { get; init; }
	public required string BadgeCode { get; init; }

	public BadgeReceivedOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public BadgeReceivedOutgoingPacket(int badgeId, string badgeCode)
	{
		this.BadgeId = badgeId;
		this.BadgeCode = badgeCode;
	}
}
