using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Room.Object;

namespace Skylight.Protocol.Packets.Data.Recycler;

public readonly struct RecyclerItemData
{
	public required FurnitureType Type { get; init; }
	public required int FurnitureId { get; init; }

	public RecyclerItemData()
	{
	}

	[SetsRequiredMembers]
	public RecyclerItemData(FurnitureType type, int furnitureId)
	{
		this.Type = type;

		this.FurnitureId = furnitureId;
	}
}
