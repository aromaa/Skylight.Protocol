using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Room.Session;

public sealed class RoomReadyOutgoingPacket : IGameOutgoingPacket
{
	public required string LayoutId { get; init; }
	public required int RoomId { get; init; }

	public RoomReadyOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public RoomReadyOutgoingPacket(string layoutId, int roomId)
	{
		this.LayoutId = layoutId;
		this.RoomId = roomId;
	}
}
