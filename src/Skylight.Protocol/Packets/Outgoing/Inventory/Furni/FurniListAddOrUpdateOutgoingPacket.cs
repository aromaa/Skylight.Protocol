using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Inventory.Furni;

namespace Skylight.Protocol.Packets.Outgoing.Inventory.Furni;

public sealed class FurniListAddOrUpdateOutgoingPacket : IGameOutgoingPacket
{
	public required ICollection<InventoryItemData> Furni { get; init; }

	public FurniListAddOrUpdateOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public FurniListAddOrUpdateOutgoingPacket(ICollection<InventoryItemData> furni)
	{
		this.Furni = furni;
	}
}
