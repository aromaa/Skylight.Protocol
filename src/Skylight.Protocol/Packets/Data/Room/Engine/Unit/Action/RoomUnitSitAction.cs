using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.Room.Engine.Unit.Action;

public sealed class RoomUnitSitAction : RoomUnitActionData
{
	public required double OffsetZ { get; init; }

	public required bool CanStandUp { get; init; }

	public RoomUnitSitAction()
	{
	}

	[SetsRequiredMembers]
	public RoomUnitSitAction(double offsetZ, bool canStandUp)
	{
		this.OffsetZ = offsetZ;
		this.CanStandUp = canStandUp;
	}
}
