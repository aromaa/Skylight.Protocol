using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Room.Engine;

namespace Skylight.Protocol.Packets.Outgoing.Room.Engine;

public sealed class ObjectAddOutgoingPacket<TRoomItemId> : IGameOutgoingPacket
{
	public required ObjectData<TRoomItemId> Object { get; init; }

	public required string OwnerName { get; init; }

	public ObjectAddOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public ObjectAddOutgoingPacket(ObjectData<TRoomItemId> objectData, string ownerName)
	{
		this.Object = objectData;

		this.OwnerName = ownerName;
	}
}
