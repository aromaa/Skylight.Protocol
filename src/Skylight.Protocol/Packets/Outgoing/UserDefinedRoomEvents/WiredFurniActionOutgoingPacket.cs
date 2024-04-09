using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.UserDefinedRoomEvents;

public sealed class WiredFurniActionOutgoingPacket : IGameOutgoingPacket
{
	public required int ItemId { get; init; }
	public required string ExtraData { get; init; }

	public WiredFurniActionOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public WiredFurniActionOutgoingPacket(int itemId, string extraData)
	{
		this.ItemId = itemId;
		this.ExtraData = extraData;
	}
}
