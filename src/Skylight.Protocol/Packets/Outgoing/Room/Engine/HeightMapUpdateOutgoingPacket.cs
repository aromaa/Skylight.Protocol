using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Room.Engine;

namespace Skylight.Protocol.Packets.Outgoing.Room.Engine;

public sealed class HeightMapUpdateOutgoingPacket : IGameOutgoingPacket
{
	public required ICollection<(int X, int Y, TileHeightMap Data)> Updates { get; init; }

	public HeightMapUpdateOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public HeightMapUpdateOutgoingPacket(ICollection<(int X, int Y, TileHeightMap Data)> updates)
	{
		this.Updates = updates;
	}
}
