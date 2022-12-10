using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Room.Session;

public sealed class OpenConnectionOutgoingPacket : IGameOutgoingPacket
{
	public int RoomId { get; init; }

	public OpenConnectionOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public OpenConnectionOutgoingPacket(int roomId)
	{
		this.RoomId = roomId;
	}
}
