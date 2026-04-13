using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Avatar;

namespace Skylight.Protocol.Packets.Outgoing.Avatar;

public sealed class WardrobeOutgoingPacket<TFigureData> : IGameOutgoingPacket
{
	public required ICollection<WardrobeSlotData<TFigureData>> Wardrobe { get; init; }

	public WardrobeOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public WardrobeOutgoingPacket(ICollection<WardrobeSlotData<TFigureData>> wardrobe)
	{
		this.Wardrobe = wardrobe;
	}
}
