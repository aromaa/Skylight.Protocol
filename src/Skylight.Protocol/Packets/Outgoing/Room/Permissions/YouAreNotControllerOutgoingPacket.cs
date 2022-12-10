using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Room.Permissions;

public sealed class YouAreNotControllerOutgoingPacket : IGameOutgoingPacket
{
	public int RoomId { get; init; }

	public YouAreNotControllerOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public YouAreNotControllerOutgoingPacket(int roomId)
	{
		this.RoomId = roomId;
	}
}
