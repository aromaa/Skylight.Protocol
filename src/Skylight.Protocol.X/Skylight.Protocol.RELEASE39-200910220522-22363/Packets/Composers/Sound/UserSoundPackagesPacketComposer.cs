using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Sound;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Composers.Sound;

[PacketComposerId(302u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class UserSoundPackagesPacketComposer : IOutgoingPacketComposer<UserSoundPackagesOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in UserSoundPackagesOutgoingPacket packet)
	{
		writer.WriteVL64Int32(packet.SoundSets.Count);
		foreach (var soundSets in packet.SoundSets)
		{
			writer.WriteVL64Int32(soundSets);
		}
	}
}
