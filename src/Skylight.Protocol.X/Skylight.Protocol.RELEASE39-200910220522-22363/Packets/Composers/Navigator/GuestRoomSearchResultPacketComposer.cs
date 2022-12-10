using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Navigator;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Composers.Navigator;

[PacketComposerId(16u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GuestRoomSearchResultPacketComposer : IOutgoingPacketComposer<GuestRoomSearchResultOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in GuestRoomSearchResultOutgoingPacket packet)
	{
		writer.WriteVL64Int32(packet.Rooms.Count);
		foreach (var rooms in packet.Rooms)
		{
			writer.WriteVL64Int32(rooms.Id);
			writer.WriteDelimiter2BrokenString(rooms.Name);
			writer.WriteDelimiter2BrokenString(rooms.OwnerName);
			writer.WriteDelimiter2BrokenString("open");
			writer.WriteVL64Int32(rooms.UserCount);
			writer.WriteVL64Int32(10);
			writer.WriteDelimiter2BrokenString("Description");
		}
	}
}
