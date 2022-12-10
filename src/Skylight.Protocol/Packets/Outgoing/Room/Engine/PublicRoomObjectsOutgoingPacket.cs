using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Room.Engine;

namespace Skylight.Protocol.Packets.Outgoing.Room.Engine;

public sealed class PublicRoomObjectsOutgoingPacket : IGameOutgoingPacket
{
	public required ICollection<PublicRoomObjectData> Objects { get; init; }

	public PublicRoomObjectsOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public PublicRoomObjectsOutgoingPacket(ICollection<PublicRoomObjectData> objects)
	{
		this.Objects = objects;
	}
}
