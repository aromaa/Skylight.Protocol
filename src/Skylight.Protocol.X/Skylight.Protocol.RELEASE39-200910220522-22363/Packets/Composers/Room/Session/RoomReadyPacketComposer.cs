using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Session;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Composers.Room.Session;

[PacketComposerId(69u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class RoomReadyPacketComposer : IOutgoingPacketComposer<RoomReadyOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in RoomReadyOutgoingPacket packet)
	{
		writer.WriteDelimiter2BrokenString(packet.LayoutId);
		writer.WriteVL64Int32(packet.RoomId);
	}
}
