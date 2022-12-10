using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Room.Engine;

public sealed class ItemRemoveOutgoingPacket : IGameOutgoingPacket
{
	public required int ItemId { get; init; }
	public required int PickerId { get; init; }

	public ItemRemoveOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public ItemRemoveOutgoingPacket(int itemId, int pickerId)
	{
		this.ItemId = itemId;
		this.PickerId = pickerId;
	}
}
