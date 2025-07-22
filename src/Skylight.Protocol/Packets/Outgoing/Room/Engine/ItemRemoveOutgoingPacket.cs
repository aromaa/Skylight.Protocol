using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Room.Engine;

public sealed class ItemRemoveOutgoingPacket<TRoomItemId> : IGameOutgoingPacket
{
	public required TRoomItemId ItemId { get; init; }
	public required int PickerId { get; init; }

	public ItemRemoveOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public ItemRemoveOutgoingPacket(TRoomItemId itemId, int pickerId)
	{
		this.ItemId = itemId;
		this.PickerId = pickerId;
	}
}
