using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Inventory.Furni;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Inventory.Furni;

[PacketComposerId(432u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class FurniListRemovePacketComposer : IOutgoingPacketComposer<FurniListRemoveOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in FurniListRemoveOutgoingPacket packet)
	{
		writer.WriteInt32(packet.StripId);
	}
}
