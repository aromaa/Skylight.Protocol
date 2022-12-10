using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Room.Object.Data;

namespace Skylight.Protocol.Packets.Data.Room.Engine;

public sealed class ObjectData
{
	public required int Id { get; init; }
	public required int FurnitureId { get; init; }

	public required int X { get; init; }
	public required int Y { get; init; }
	public required double Z { get; init; }

	public required int Direction { get; init; }

	public required double SizeZ { get; init; }

	public required int Extra { get; init; }

	public required IItemData ExtraData { get; init; }

	public ObjectData()
	{
	}

	[SetsRequiredMembers]
	public ObjectData(int id, int furnitureId, int x, int y, double z, int direction, double sizeZ, int extra, IItemData extraData)
	{
		this.Id = id;
		this.FurnitureId = furnitureId;

		this.X = x;
		this.Y = y;
		this.Z = z;

		this.Direction = direction;

		this.SizeZ = sizeZ;

		this.Extra = extra;

		this.ExtraData = extraData;
	}
}
