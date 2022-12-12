using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Sound;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Composers.Sound;

[PacketComposerId(331u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class NewSongPacketComposer : IOutgoingPacketComposer<NewSongOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in NewSongOutgoingPacket packet)
	{
		writer.WriteVL64Int32(packet.Id);
		writer.WriteDelimiter2BrokenString(packet.Name);
	}
}
