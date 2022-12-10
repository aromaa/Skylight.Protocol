using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Room.Object.Data;
using Skylight.Protocol.Packets.Data.Room.Object.Data.Wall;

namespace Skylight.Protocol.Packets.Data.Room.Engine;

public sealed class ItemData
{
	public required int Id { get; init; }
	public required int FurnitureId { get; init; }

	public required WallPosition Position { get; init; }

	public required IItemData ExtraData { get; init; }

	public ItemData()
	{
	}

	[SetsRequiredMembers]
	public ItemData(int id, int furnitureId, WallPosition position, IItemData extraData)
	{
		this.Id = id;
		this.FurnitureId = furnitureId;

		this.Position = position;

		this.ExtraData = extraData;
	}
}
