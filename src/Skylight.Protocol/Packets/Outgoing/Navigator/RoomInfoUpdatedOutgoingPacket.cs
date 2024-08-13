using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Navigator;

public sealed class RoomInfoUpdatedOutgoingPacket : IGameOutgoingPacket
{
	public required int RoomId { get; init; }

	public RoomInfoUpdatedOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public RoomInfoUpdatedOutgoingPacket(int roomId)
	{
		this.RoomId = roomId;
	}
}
