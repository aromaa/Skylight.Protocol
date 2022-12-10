using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Navigator;

public sealed class FlatCreatedOutgoingPacket : IGameOutgoingPacket
{
	public required int RoomId { get; init; }
	public required string RoomName { get; init; }

	public FlatCreatedOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public FlatCreatedOutgoingPacket(int roomId, string roomName)
	{
		this.RoomId = roomId;
		this.RoomName = roomName;
	}
}
