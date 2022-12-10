using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Room.Engine;

public sealed class ObjectRemoveOutgoingPacket : IGameOutgoingPacket
{
	public required int ItemId { get; init; }
	public required bool Expired { get; init; }
	public required int PickerId { get; init; }
	public required int Delay { get; init; }

	public ObjectRemoveOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public ObjectRemoveOutgoingPacket(int itemId, bool expired, int pickerId, int delay)
	{
		this.ItemId = itemId;
		this.Expired = expired;
		this.PickerId = pickerId;
		this.Delay = delay;
	}
}
