using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.NewNavigator;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.NewNavigator;

[PacketComposerId(3488u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class NavigatorLiftedRoomsPacketComposer : IOutgoingPacketComposer<NavigatorLiftedRoomsOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in NavigatorLiftedRoomsOutgoingPacket packet)
	{
		writer.WriteInt32(packet.LiftedRooms.Count);
		foreach (var liftedRooms in packet.LiftedRooms)
		{
			writer.WriteInt32(liftedRooms.RoomId);
			writer.WriteInt32(liftedRooms.AreaId);
			writer.WriteFixedUInt16String(liftedRooms.Image);
			writer.WriteFixedUInt16String(liftedRooms.Caption);
		}
	}
}
