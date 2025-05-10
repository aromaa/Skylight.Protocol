using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Room.Engine;

namespace Skylight.Protocol.Packets.Outgoing.Room.Engine;

public sealed class PublicRoomObjectsOutgoingPacket : IGameOutgoingPacket
{
	public required string LayoutId { get; init; }
	public required ICollection<PublicRoomObjectData> Objects { get; init; }

	public PublicRoomObjectsOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public PublicRoomObjectsOutgoingPacket(string layoutId, ICollection<PublicRoomObjectData> objects)
	{
		this.LayoutId = layoutId;
		this.Objects = objects;
	}
}
