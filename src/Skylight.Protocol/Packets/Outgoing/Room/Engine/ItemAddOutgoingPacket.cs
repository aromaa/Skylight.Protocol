using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Room.Engine;

namespace Skylight.Protocol.Packets.Outgoing.Room.Engine;

public sealed class ItemAddOutgoingPacket<TRoomItemId> : IGameOutgoingPacket
{
	public required ItemData<TRoomItemId> Item { get; init; }

	public required string OwnerName { get; init; }

	public ItemAddOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public ItemAddOutgoingPacket(ItemData<TRoomItemId> item, string ownerName)
	{
		this.Item = item;

		this.OwnerName = ownerName;
	}
}
