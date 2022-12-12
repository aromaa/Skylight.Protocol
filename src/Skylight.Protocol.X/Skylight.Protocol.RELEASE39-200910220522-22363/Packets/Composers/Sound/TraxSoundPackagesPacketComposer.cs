using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Sound;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Composers.Sound;

[PacketComposerId(301u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class TraxSoundPackagesPacketComposer : IOutgoingPacketComposer<TraxSoundPackagesOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in TraxSoundPackagesOutgoingPacket packet)
	{
		writer.WriteVL64Int32(packet.SlotCount);
		writer.WriteVL64Int32(packet.FilledSlots.Count);
		foreach (var filledSlots in packet.FilledSlots)
		{
			writer.WriteVL64Int32(filledSlots.Slot);
			writer.WriteVL64Int32(filledSlots.SoundSetId);
			writer.WriteVL64Int32(filledSlots.Samples.Count);
			foreach (var samples in filledSlots.Samples)
			{
				writer.WriteVL64Int32(samples);
			}
		}
	}
}
