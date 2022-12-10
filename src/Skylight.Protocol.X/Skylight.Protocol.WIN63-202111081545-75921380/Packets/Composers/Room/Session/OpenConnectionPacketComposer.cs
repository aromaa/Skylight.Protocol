using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Session;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Room.Session;

[PacketComposerId(631u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class OpenConnectionPacketComposer : IOutgoingPacketComposer<OpenConnectionOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in OpenConnectionOutgoingPacket packet)
	{
		writer.WriteInt32(packet.RoomId);
	}
}
