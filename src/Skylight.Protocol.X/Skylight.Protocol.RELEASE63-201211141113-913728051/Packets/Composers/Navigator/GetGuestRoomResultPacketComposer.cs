using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Navigator;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Composers.Navigator;

[PacketComposerId(3116u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetGuestRoomResultPacketComposer : IOutgoingPacketComposer<GetGuestRoomResultOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in GetGuestRoomResultOutgoingPacket packet)
	{
		writer.WriteBool(packet.EnterRoom);
		writer.WriteInt32(packet.Room.Id);
		writer.WriteFixedUInt16String(packet.Room.Name);
		writer.WriteBool(true);
		writer.WriteInt32(0);
		writer.WriteFixedUInt16String(packet.Room.OwnerName);
		writer.WriteInt32(0);
		writer.WriteInt32(packet.Room.UserCount);
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
		writer.WriteBool(packet.RoomForward);
		writer.WriteBool(packet.StaffPick);
		writer.WriteBool(packet.GroupMember);
	}
}
