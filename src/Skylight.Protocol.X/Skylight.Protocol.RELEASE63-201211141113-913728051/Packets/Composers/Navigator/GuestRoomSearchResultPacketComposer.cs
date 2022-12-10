using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Navigator;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Composers.Navigator;

[PacketComposerId(2160u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GuestRoomSearchResultPacketComposer : IOutgoingPacketComposer<GuestRoomSearchResultOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in GuestRoomSearchResultOutgoingPacket packet)
	{
		writer.WriteInt32(packet.SearchType);
		writer.WriteFixedUInt16String(packet.Text);
		writer.WriteInt32(packet.Rooms.Count);
		foreach (var rooms in packet.Rooms)
		{
			writer.WriteInt32(rooms.Id);
			writer.WriteFixedUInt16String(rooms.Name);
			writer.WriteBool(true);
			writer.WriteInt32(0);
			writer.WriteFixedUInt16String(rooms.OwnerName);
			writer.WriteInt32(0);
			writer.WriteInt32(rooms.UserCount);
			writer.WriteInt32(10);
			writer.WriteFixedUInt16String("Description");
			writer.WriteInt32(0);
			writer.WriteInt32(0);
			writer.WriteInt32(13);
			writer.WriteInt32(2);
			writer.WriteInt32(1);
			writer.WriteInt32(0);
			writer.WriteFixedUInt16String("");
			writer.WriteFixedUInt16String("");
			writer.WriteFixedUInt16String("");
			writer.WriteInt32(0);
			writer.WriteInt32(0);
			writer.WriteInt32(0);
			writer.WriteInt32(0);
			writer.WriteBool(false);
			writer.WriteBool(false);
			writer.WriteFixedUInt16String("");
			writer.WriteFixedUInt16String("");
			writer.WriteInt32(0);
		}
		writer.WriteBool(false);
	}
}
