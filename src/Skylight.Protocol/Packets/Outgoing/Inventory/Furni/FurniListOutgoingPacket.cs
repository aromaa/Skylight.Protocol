using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Inventory.Furni;

namespace Skylight.Protocol.Packets.Outgoing.Inventory.Furni;

public sealed class FurniListOutgoingPacket : IGameOutgoingPacket
{
	public required int TotalFragments { get; init; }
	public required int FragmentId { get; init; }
	public required ICollection<InventoryItemData> Fragment { get; init; }

	public FurniListOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public FurniListOutgoingPacket(int totalFragments, int fragmentId, ICollection<InventoryItemData> fragment)
	{
		this.TotalFragments = totalFragments;
		this.FragmentId = fragmentId;
		this.Fragment = fragment;
	}
}
