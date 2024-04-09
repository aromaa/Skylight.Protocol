using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.UserDefinedRoomEvents;

public sealed class WiredFurniTriggerOutgoingPacket : IGameOutgoingPacket
{
	public required int ItemId { get; init; }
	public required string ExtraData { get; init; }

	public WiredFurniTriggerOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public WiredFurniTriggerOutgoingPacket(int itemId, string extraData)
	{
		this.ItemId = itemId;
		this.ExtraData = extraData;
	}
}
