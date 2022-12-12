using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Sound;

namespace Skylight.Protocol.Packets.Outgoing.Sound;

public sealed class TraxSoundPackagesOutgoingPacket : IGameOutgoingPacket
{
	public required int SlotCount { get; init; }

	public required ICollection<SoundSetData> FilledSlots { get; init; }

	public TraxSoundPackagesOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public TraxSoundPackagesOutgoingPacket(int slotCount, ICollection<SoundSetData> filledSlots)
	{
		this.SlotCount = slotCount;

		this.FilledSlots = filledSlots;
	}
}
