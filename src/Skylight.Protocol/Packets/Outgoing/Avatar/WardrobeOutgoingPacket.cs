using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Avatar;

namespace Skylight.Protocol.Packets.Outgoing.Avatar;

public sealed class WardrobeOutgoingPacket : IGameOutgoingPacket
{
	public required ICollection<WardrobeSlotData> Wardrobe { get; init; }

	public WardrobeOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public WardrobeOutgoingPacket(ICollection<WardrobeSlotData> wardrobe)
	{
		this.Wardrobe = wardrobe;
	}
}
