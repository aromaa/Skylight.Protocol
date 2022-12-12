using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.Sound;

public sealed class SoundSetData
{
	public required int Slot { get; init; }
	public required int SoundSetId { get; init; }

	public required ICollection<int> Samples { get; init; }

	public SoundSetData()
	{
	}

	[SetsRequiredMembers]
	public SoundSetData(int slot, int soundSetId, ICollection<int> samples)
	{
		this.Slot = slot;
		this.SoundSetId = soundSetId;

		this.Samples = samples;
	}
}
