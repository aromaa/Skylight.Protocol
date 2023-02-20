using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Chat;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Composers.Room.Chat;

[PacketComposerId(2119u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class ChatPacketComposer : IOutgoingPacketComposer<ChatOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in ChatOutgoingPacket packet)
	{
		writer.WriteInt32(packet.UserId);
		writer.WriteFixedUInt16String(packet.Text);
		writer.WriteInt32(packet.Gesture);
		writer.WriteInt32(packet.StyleId);
		writer.WriteInt32(packet.Links.Count);
		foreach (var links in packet.Links)
		{
			writer.WriteFixedUInt16String(links.Location);
			writer.WriteFixedUInt16String(links.Text);
			writer.WriteBool(links.Trusted);
		}
		writer.WriteInt32(packet.TrackingId);
	}
}
