using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Room.Engine;

namespace Skylight.Protocol.Packets.Outgoing.Room.Engine;

public sealed class UsersOutgoingPacket<TFigureData> : IGameOutgoingPacket
{
	public required ICollection<RoomUnitData<TFigureData>> Users { get; init; }

	public UsersOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public UsersOutgoingPacket(ICollection<RoomUnitData<TFigureData>> users)
	{
		this.Users = users;
	}
}
