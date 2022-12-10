using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Room.Object;
using Skylight.Protocol.Packets.Data.Room.Object.Data;

namespace Skylight.Protocol.Packets.Data.Inventory.Furni;

//TODO: Abstract actually?
public sealed class InventoryItemData
{
	public required int StripId { get; init; }
	public required int ItemId { get; init; }
	public required int FurnitureId { get; init; }

	public required FurnitureType Type { get; init; }
	public required int Category { get; init; }

	public required IItemData ExtraData { get; init; }

	public InventoryItemData()
	{
	}

	[SetsRequiredMembers]
	public InventoryItemData(int stripId, int itemId, int furnitureId, FurnitureType type, int category, IItemData extraData)
	{
		this.StripId = stripId;
		this.ItemId = itemId;
		this.FurnitureId = furnitureId;

		this.Type = type;
		this.Category = category;

		this.ExtraData = extraData;
	}
}
