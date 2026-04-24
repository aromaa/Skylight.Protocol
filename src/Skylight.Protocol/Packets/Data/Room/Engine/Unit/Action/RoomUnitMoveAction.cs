using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.Room.Engine.Unit.Action;

public sealed class RoomUnitMoveAction : RoomUnitActionData
{
	public required int TargetX { get; init; }
	public required int TargetY { get; init; }
	public required double TargetZ { get; init; }

	public RoomUnitMoveAction()
	{
	}

	[SetsRequiredMembers]
	public RoomUnitMoveAction(int targetX, int targetY, double targetZ)
	{
		this.TargetX = targetX;
		this.TargetY = targetY;
		this.TargetZ = targetZ;
	}
}
