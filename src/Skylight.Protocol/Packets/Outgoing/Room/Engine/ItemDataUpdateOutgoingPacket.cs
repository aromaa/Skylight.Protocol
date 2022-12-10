using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Room.Object.Data;

namespace Skylight.Protocol.Packets.Outgoing.Room.Engine;

public sealed class ItemDataUpdateOutgoingPacket : IGameOutgoingPacket
{
	public required int ItemId { get; init; }
	public required IItemData ItemData { get; init; }

	public ItemDataUpdateOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public ItemDataUpdateOutgoingPacket(int itemId, IItemData itemData)
	{
		this.ItemId = itemId;
		this.ItemData = itemData;
	}
}
