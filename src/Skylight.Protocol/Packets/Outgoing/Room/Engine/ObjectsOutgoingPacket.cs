using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Room.Engine;

namespace Skylight.Protocol.Packets.Outgoing.Room.Engine;

public sealed class ObjectsOutgoingPacket : IGameOutgoingPacket
{
	public required ICollection<ObjectData> Objects { get; init; }

	public required ICollection<(int UserId, string Username)> OwnerNames { get; init; }

	public ObjectsOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public ObjectsOutgoingPacket(ICollection<ObjectData> objects, ICollection<(int UserId, string Username)> ownerNames)
	{
		this.OwnerNames = ownerNames;

		this.Objects = objects;
	}
}
