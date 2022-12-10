using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Room.Permissions;

public sealed class YouAreOwnerOutgoingPacket : IGameOutgoingPacket
{
	public required int RoomId { get; init; }

	public YouAreOwnerOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public YouAreOwnerOutgoingPacket(int roomId)
	{
		this.RoomId = roomId;
	}
}
