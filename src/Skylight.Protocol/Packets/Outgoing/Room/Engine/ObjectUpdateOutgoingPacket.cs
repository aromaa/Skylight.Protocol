using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Room.Engine;

namespace Skylight.Protocol.Packets.Outgoing.Room.Engine;

public sealed class ObjectUpdateOutgoingPacket : IGameOutgoingPacket
{
	public required ObjectData Object { get; init; }

	public ObjectUpdateOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public ObjectUpdateOutgoingPacket(ObjectData objectData)
	{
		this.Object = objectData;
	}
}
