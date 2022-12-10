using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Room.Engine;

public sealed class HeightMapOutgoingPacket : IGameOutgoingPacket
{
	public required int Width { get; init; }

	public required ICollection<short> HeightMap { get; init; }

	public HeightMapOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public HeightMapOutgoingPacket(int width, ICollection<short> heightMap)
	{
		this.Width = width;

		this.HeightMap = heightMap;
	}
}
