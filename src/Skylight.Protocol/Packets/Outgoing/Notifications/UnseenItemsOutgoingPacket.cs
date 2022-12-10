using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Notifications;

namespace Skylight.Protocol.Packets.Outgoing.Notifications;

public sealed class UnseenItemsOutgoingPacket : IGameOutgoingPacket
{
	public required ICollection<UnseenItemData> Items { get; init; }

	public UnseenItemsOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public UnseenItemsOutgoingPacket(ICollection<UnseenItemData> items)
	{
		this.Items = items;
	}
}
