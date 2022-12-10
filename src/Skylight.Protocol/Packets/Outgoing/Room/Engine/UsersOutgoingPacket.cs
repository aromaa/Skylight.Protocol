using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Room.Engine;

namespace Skylight.Protocol.Packets.Outgoing.Room.Engine;

public sealed class UsersOutgoingPacket : IGameOutgoingPacket
{
	public required ICollection<RoomUnitData> Users { get; init; }

	public UsersOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public UsersOutgoingPacket(ICollection<RoomUnitData> users)
	{
		this.Users = users;
	}
}
