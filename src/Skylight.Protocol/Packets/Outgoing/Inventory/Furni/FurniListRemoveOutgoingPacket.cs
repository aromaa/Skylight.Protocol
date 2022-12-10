using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Inventory.Furni;

public sealed class FurniListRemoveOutgoingPacket : IGameOutgoingPacket
{
	public required int StripId { get; init; }

	public FurniListRemoveOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public FurniListRemoveOutgoingPacket(int stripId)
	{
		this.StripId = stripId;
	}
}
