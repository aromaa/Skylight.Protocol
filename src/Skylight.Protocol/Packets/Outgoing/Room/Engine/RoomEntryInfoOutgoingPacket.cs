using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Room.Engine;

public sealed class RoomEntryInfoOutgoingPacket : IGameOutgoingPacket
{
	public int RoomId { get; init; }
	public bool Owner { get; init; }

	public RoomEntryInfoOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public RoomEntryInfoOutgoingPacket(int roomId, bool owner)
	{
		this.RoomId = roomId;
		this.Owner = owner;
	}
}
