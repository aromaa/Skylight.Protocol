using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Room.Layout;

public sealed class RoomEntryTileOutgoingPacket : IGameOutgoingPacket
{
	public required int X { get; init; }
	public required int Y { get; init; }
	public required int Direction { get; init; }

	public RoomEntryTileOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public RoomEntryTileOutgoingPacket(int x, int y, int direction)
	{
		this.X = x;
		this.Y = y;
		this.Direction = direction;
	}
}
