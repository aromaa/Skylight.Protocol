using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Navigator;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Composers.Navigator;

[PacketComposerId(54u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetGuestRoomResultPacketComposer : IOutgoingPacketComposer<GetGuestRoomResultOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in GetGuestRoomResultOutgoingPacket packet)
	{
		writer.WriteVL64Int32(0);
		writer.WriteVL64Int32(0);
		writer.WriteVL64Int32(packet.Room.Id);
		writer.WriteDelimiter2BrokenString(packet.Room.OwnerName);
		writer.WriteDelimiter2BrokenString(packet.Room.LayoutId);
		writer.WriteDelimiter2BrokenString(packet.Room.Name);
		writer.WriteDelimiter2BrokenString("Description");
		writer.WriteVL64Int32(1);
		writer.WriteVL64Int32(1);
		writer.WriteVL64Int32(1);
		writer.WriteVL64Int32(10);
		writer.WriteVL64Int32(10);
	}
}
