using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Room.Permissions;

public sealed class YouAreControllerOutgoingPacket : IGameOutgoingPacket
{
	public int RoomId { get; init; }
	public int RoomControllerLevel { get; init; }

	public YouAreControllerOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public YouAreControllerOutgoingPacket(int roomId, int roomControllerLevel)
	{
		this.RoomId = roomId;
		this.RoomControllerLevel = roomControllerLevel;
	}
}
