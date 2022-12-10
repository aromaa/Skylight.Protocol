using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Room.Engine;

namespace Skylight.Protocol.Packets.Outgoing.Room.Engine;

public sealed class UserUpdateOutgoingPacket : IGameOutgoingPacket
{
	public required ICollection<RoomUnitUpdateData> Updates { get; init; }

	public UserUpdateOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public UserUpdateOutgoingPacket(ICollection<RoomUnitUpdateData> updates)
	{
		this.Updates = updates;
	}
}
