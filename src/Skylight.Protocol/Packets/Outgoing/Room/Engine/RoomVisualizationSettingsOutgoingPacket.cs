using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Room.Engine;

public sealed class RoomVisualizationSettingsOutgoingPacket : IGameOutgoingPacket
{
	public required bool WallsHidden { get; init; }

	public required int WallThicknessMultiplier { get; init; }
	public required int FloorThicknessMultiplier { get; init; }

	public RoomVisualizationSettingsOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public RoomVisualizationSettingsOutgoingPacket(bool wallsHidden, int wallThicknessMultiplier, int floorThicknessMultiplier)
	{
		this.WallsHidden = wallsHidden;

		this.WallThicknessMultiplier = wallThicknessMultiplier;
		this.FloorThicknessMultiplier = floorThicknessMultiplier;
	}
}
