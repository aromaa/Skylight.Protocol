using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Room.Engine;

[PacketComposerId(2435u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class UserRemovePacketComposer : IOutgoingPacketComposer<UserRemoveOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in UserRemoveOutgoingPacket packet)
	{
		writer.WriteFixedUInt16String(packet.RoomUnitId.ToString());
	}
}
