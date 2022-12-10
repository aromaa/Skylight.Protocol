using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Room.Engine;

namespace Skylight.Protocol.Packets.Outgoing.Room.Engine;

public sealed class ItemAddOutgoingPacket : IGameOutgoingPacket
{
	public required ItemData Item { get; init; }

	public required string OwnerName { get; init; }

	public ItemAddOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public ItemAddOutgoingPacket(ItemData item, string ownerName)
	{
		this.Item = item;

		this.OwnerName = ownerName;
	}
}
