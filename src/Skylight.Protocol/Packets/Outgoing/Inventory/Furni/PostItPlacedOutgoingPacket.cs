using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Inventory.Furni;

public sealed class PostItPlacedOutgoingPacket : IGameOutgoingPacket
{
	public required int StripId { get; init; }
	public required int ItemsLeft { get; init; }

	public PostItPlacedOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public PostItPlacedOutgoingPacket(int stripId, int itemsLeft)
	{
		this.StripId = stripId;
		this.ItemsLeft = itemsLeft;
	}
}
