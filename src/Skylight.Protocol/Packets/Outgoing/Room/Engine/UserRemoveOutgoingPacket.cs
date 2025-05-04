using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Room.Engine;

public sealed class UserRemoveOutgoingPacket : IGameOutgoingPacket
{
	public required int RoomUnitId { get; init; }
	public required string Username { get; init; }

	public UserRemoveOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public UserRemoveOutgoingPacket(int roomUnitId, string username)
	{
		this.RoomUnitId = roomUnitId;
		this.Username = username;
	}
}
