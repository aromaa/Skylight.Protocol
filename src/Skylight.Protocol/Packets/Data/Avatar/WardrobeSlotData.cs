using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.Avatar;

public sealed class WardrobeSlotData
{
	public required int SlotId { get; init; }

	public required string Gender { get; init; }
	public required string Figure { get; init; }

	public WardrobeSlotData()
	{
	}

	[SetsRequiredMembers]
	public WardrobeSlotData(int slotId, string gender, string figure)
	{
		this.SlotId = slotId;
		this.Gender = gender;
		this.Figure = figure;
	}
}
