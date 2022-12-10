using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Navigator;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Navigator;

[PacketComposerId(2085u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetGuestRoomResultPacketComposer : IOutgoingPacketComposer<GetGuestRoomResultOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in GetGuestRoomResultOutgoingPacket packet)
	{
		writer.WriteBool(packet.EnterRoom);
		writer.WriteInt32(packet.Room.Id);
		writer.WriteFixedUInt16String(packet.Room.Name);
		writer.WriteInt32(1);
		writer.WriteFixedUInt16String(packet.Room.OwnerName);
		writer.WriteInt32(0);
		writer.WriteInt32(packet.Room.UserCount);
		writer.WriteInt32(10);
		writer.WriteFixedUInt16String("Description");
		writer.WriteInt32(0);
		writer.WriteInt32(13);
		writer.WriteInt32(2);
		writer.WriteInt32(1);
		writer.WriteInt32(0);
		writer.WriteInt32(8);
		writer.WriteBool(packet.RoomForward);
		writer.WriteBool(packet.StaffPick);
		writer.WriteBool(packet.GroupMember);
		writer.WriteBool(packet.AllInRoomMuted);
		writer.WriteInt32(packet.RoomModerationSettings.WhoCanMute);
		writer.WriteInt32(packet.RoomModerationSettings.WhoCanKick);
		writer.WriteInt32(packet.RoomModerationSettings.WhoCanBan);
		writer.WriteBool(packet.CanMute);
		writer.WriteInt32(packet.RoomChatSettings.Mode);
		writer.WriteInt32(packet.RoomChatSettings.BubbleWidth);
		writer.WriteInt32(packet.RoomChatSettings.ScrollSpeed);
		writer.WriteInt32(packet.RoomChatSettings.FullHearRange);
		writer.WriteInt32(packet.RoomChatSettings.FloodSensitivity);
	}
}
