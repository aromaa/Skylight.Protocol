using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Room.Engine;

namespace Skylight.Protocol.Packets.Outgoing.Room.Engine;

public sealed class ObjectsOutgoingPacket<TRoomItemId> : IGameOutgoingPacket
{
	public required ICollection<ObjectData<TRoomItemId>> Objects { get; init; }

	public required ICollection<(int UserId, string Username)> OwnerNames { get; init; }

	public ObjectsOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public ObjectsOutgoingPacket(ICollection<ObjectData<TRoomItemId>> objects, ICollection<(int UserId, string Username)> ownerNames)
	{
		this.OwnerNames = ownerNames;

		this.Objects = objects;
	}
}
