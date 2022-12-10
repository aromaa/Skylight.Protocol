using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.Room.Object.Data.Wall;

public readonly struct WallPosition
{
	public required int LocationX { get; init; }
	public required int LocationY { get; init; }

	public required int PositionX { get; init; }
	public required int PositionY { get; init; }

	public WallPosition()
	{
	}

	[SetsRequiredMembers]
	public WallPosition(int locationX, int locationY, int positionX, int positionY)
	{
		this.LocationX = locationX;
		this.LocationY = locationY;

		this.PositionX = positionX;
		this.PositionY = positionY;
	}
}
