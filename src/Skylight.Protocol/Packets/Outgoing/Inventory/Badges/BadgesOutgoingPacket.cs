using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Inventory.Badges;

public sealed class BadgesOutgoingPacket : IGameOutgoingPacket
{
	public required int TotalFragments { get; init; }
	public required int FragmentId { get; init; }
	public required ICollection<(int BadgeId, string BadgeCode)> Fragment { get; init; }

	public BadgesOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public BadgesOutgoingPacket(int totalFragments, int fragmentId, ICollection<(int BadgeId, string BadgeCode)> fragment)
	{
		this.TotalFragments = totalFragments;
		this.FragmentId = fragmentId;
		this.Fragment = fragment;
	}
}
