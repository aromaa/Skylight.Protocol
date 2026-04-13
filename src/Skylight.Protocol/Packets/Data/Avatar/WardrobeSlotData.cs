using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.Avatar;

public sealed class WardrobeSlotData<TFigureData>
{
	public required int SlotId { get; init; }

	public required string Gender { get; init; }
	public required TFigureData Figure { get; init; }

	public WardrobeSlotData()
	{
	}

	[SetsRequiredMembers]
	public WardrobeSlotData(int slotId, string gender, TFigureData figure)
	{
		this.SlotId = slotId;
		this.Gender = gender;
		this.Figure = figure;
	}
}
