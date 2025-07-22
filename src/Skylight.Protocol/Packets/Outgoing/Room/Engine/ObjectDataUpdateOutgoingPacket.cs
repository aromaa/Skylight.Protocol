using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Room.Object.Data;

namespace Skylight.Protocol.Packets.Outgoing.Room.Engine;

[method: SetsRequiredMembers]
public sealed class ObjectDataUpdateOutgoingPacket<TRoomItemId>(TRoomItemId itemId, IItemData data) : IGameOutgoingPacket
{
	public required TRoomItemId ItemId { get; init; } = itemId;
	public required IItemData Data { get; init; } = data;
}
