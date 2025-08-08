using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Room.Engine;

namespace Skylight.Protocol.Packets.Outgoing.Room.Engine;

public sealed class ObjectUpdateOutgoingPacket<TRoomItemId> : IGameOutgoingPacket
{
	public required ObjectData<TRoomItemId> Object { get; init; }

	public ObjectUpdateOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public ObjectUpdateOutgoingPacket(ObjectData<TRoomItemId> objectData)
	{
		this.Object = objectData;
	}
}
