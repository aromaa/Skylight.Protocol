using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Navigator;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Composers.Navigator;

[PacketComposerId(220u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class OfficialRoomsPacketComposer : IOutgoingPacketComposer<OfficialRoomsOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in OfficialRoomsOutgoingPacket packet)
	{
		writer.WriteVL64Int32(packet.NodeMask);
		writer.WriteVL64Int32(3);
		writer.WriteVL64Int32(0);
		writer.WriteDelimiter2BrokenString("Publics");
		writer.WriteVL64Int32(0);
		writer.WriteVL64Int32(1000);
		writer.WriteVL64Int32(0);
		writer.WriteVL64Int32(4);
		writer.WriteVL64Int32(1);
		writer.WriteDelimiter2BrokenString("Test Name");
		writer.WriteVL64Int32(0);
		writer.WriteVL64Int32(10);
		writer.WriteVL64Int32(3);
		writer.WriteDelimiter2BrokenString("Desc");
		writer.WriteVL64Int32(4);
		writer.WriteVL64Int32(0);
		writer.WriteDelimiter2BrokenString("hh_room_terrace,hh_paalu,hh_people_pool,hh_people_paalu");
		writer.WriteVL64Int32(0);
		writer.WriteVL64Int32(1);
	}
}
