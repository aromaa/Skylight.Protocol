using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Sound;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Composers.Sound;

[PacketComposerId(322u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class SongListPacketComposer : IOutgoingPacketComposer<SongListOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in SongListOutgoingPacket packet)
	{
		writer.WriteVL64Int32(packet.Songs.Count);
		foreach (var songs in packet.Songs)
		{
			writer.WriteVL64Int32(songs.Id);
			writer.WriteVL64Int32(songs.Length);
			writer.WriteDelimiter2BrokenString(songs.Name);
			writer.WriteVL64Int32(songs.Locked ? 1 : 0);
		}
	}
}
