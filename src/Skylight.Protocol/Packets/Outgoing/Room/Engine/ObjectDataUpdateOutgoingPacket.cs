using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Room.Object.Data;

namespace Skylight.Protocol.Packets.Outgoing.Room.Engine;

public sealed class ObjectDataUpdateOutgoingPacket : IGameOutgoingPacket
{
	public required int ItemId { get; init; }
	public required IItemData Data { get; init; }

	[SetsRequiredMembers]
	public ObjectDataUpdateOutgoingPacket(int itemId, IItemData data)
	{
		this.ItemId = itemId;
		this.Data = data;
	}
}
