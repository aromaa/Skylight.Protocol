using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Inventory.Trading;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Inventory.Trading;

[PacketComposerId(1710u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class TradingOpenPacketComposer : IOutgoingPacketComposer<TradingOpenOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in TradingOpenOutgoingPacket packet)
	{
		writer.WriteInt32(packet.FirstUserId);
		writer.WriteInt32(packet.FirstUserCanTrade ? 1 : 0);
		writer.WriteInt32(packet.SecondUserId);
		writer.WriteInt32(packet.SecondUserCanTrade ? 1 : 0);
	}
}
