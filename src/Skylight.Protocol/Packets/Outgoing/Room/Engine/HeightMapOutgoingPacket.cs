using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Room.Engine;

namespace Skylight.Protocol.Packets.Outgoing.Room.Engine;

public sealed class HeightMapOutgoingPacket : IGameOutgoingPacket
{
	public required int Width { get; init; }

	public required ICollection<TileHeightMap> HeightMap { get; init; }

	public HeightMapOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public HeightMapOutgoingPacket(int width, ICollection<TileHeightMap> heightMap)
	{
		this.Width = width;

		this.HeightMap = heightMap;
	}
}
