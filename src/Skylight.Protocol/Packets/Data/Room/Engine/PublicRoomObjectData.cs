using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.Room.Engine;

public sealed class PublicRoomObjectData
{
	public required string Id { get; init; }
	public required string SpriteId { get; init; }

	public required int X { get; init; }
	public required int Y { get; init; }
	public required int Z { get; init; }

	public required int Direction { get; init; }

	public PublicRoomObjectData()
	{
	}

	[SetsRequiredMembers]
	public PublicRoomObjectData(string id, string spriteId, int x, int y, int z, int direction)
	{
		this.Id = id;

		this.SpriteId = spriteId;

		this.X = x;
		this.Y = y;
		this.Z = z;

		this.Direction = direction;
	}
}
