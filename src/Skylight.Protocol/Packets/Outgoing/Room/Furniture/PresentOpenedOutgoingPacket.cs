using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Room.Object;

namespace Skylight.Protocol.Packets.Outgoing.Room.Furniture;

public sealed class PresentOpenedOutgoingPacket : IGameOutgoingPacket
{
	public required string ProductCode { get; init; }
	public required FurnitureType ItemType { get; init; }
	public required int FurnitureId { get; init; }

	public required bool PlacedInRoom { get; init; }
	public required int PlacedItemId { get; init; }
	public required FurnitureType PlacedItemType { get; init; }

	public required string PetFigure { get; init; }

	public PresentOpenedOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public PresentOpenedOutgoingPacket(string productCode, FurnitureType itemType, int furnitureId, bool placedInRoom, int placedItemId, FurnitureType placedItemType, string petFigure)
	{
		this.ProductCode = productCode;
		this.ItemType = itemType;
		this.FurnitureId = furnitureId;

		this.PlacedInRoom = placedInRoom;
		this.PlacedItemId = placedItemId;
		this.PlacedItemType = placedItemType;

		this.PetFigure = petFigure;
	}
}
