using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.Room.Engine.Unit.Action;

public sealed class RoomUnitLayAction : RoomUnitActionData
{
	public required double OffsetZ { get; init; }

	public RoomUnitLayAction()
	{
	}

	[SetsRequiredMembers]
	public RoomUnitLayAction(double offsetZ)
	{
		this.OffsetZ = offsetZ;
	}
}
