using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Room.Engine;

namespace Skylight.Protocol.Packets.Outgoing.Room.Engine;

public sealed class ItemsOutgoingPacket<TRoomItemId> : IGameOutgoingPacket
{
	public required ICollection<ItemData<TRoomItemId>> Items { get; init; }

	public required ICollection<(int UserId, string Username)> OwnerNames { get; init; }

	public ItemsOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public ItemsOutgoingPacket(ICollection<ItemData<TRoomItemId>> items, ICollection<(int UserId, string Username)> ownerNames)
	{
		this.Items = items;

		this.OwnerNames = ownerNames;
	}
}
