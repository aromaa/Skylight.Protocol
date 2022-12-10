using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.RoomSettings;

public sealed class NoSuchFlatOutgoingPacket : IGameOutgoingPacket
{
	public required int RoomId { get; init; }

	public NoSuchFlatOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public NoSuchFlatOutgoingPacket(int roomId)
	{
		this.RoomId = roomId;
	}
}
