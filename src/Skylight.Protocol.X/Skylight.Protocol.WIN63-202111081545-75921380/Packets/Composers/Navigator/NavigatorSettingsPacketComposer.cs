using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Navigator;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Navigator;

[PacketComposerId(2312u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class NavigatorSettingsPacketComposer : IOutgoingPacketComposer<NavigatorSettingsOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in NavigatorSettingsOutgoingPacket packet)
	{
		writer.WriteInt32(packet.HomeRoomId);
		writer.WriteInt32(packet.RoomIdToEnter);
	}
}
