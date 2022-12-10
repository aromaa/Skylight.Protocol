using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Room.Engine;

public sealed class FloorHeightMapOutgoingPacket : IGameOutgoingPacket
{
	public required bool Scale { get; init; }
	public required int FixedWallsHeight { get; init; }
	public required string HeightMap { get; init; }

	public FloorHeightMapOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public FloorHeightMapOutgoingPacket(bool scale, int fixedWallsHeight, string heightMap)
	{
		this.Scale = scale;
		this.FixedWallsHeight = fixedWallsHeight;
		this.HeightMap = heightMap;
	}
}
