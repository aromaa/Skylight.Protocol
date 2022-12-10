using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Purse;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Purse;

[PacketComposerId(1791u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class CreditBalancePacketComposer : IOutgoingPacketComposer<CreditBalanceOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in CreditBalanceOutgoingPacket packet)
	{
		writer.WriteFixedUInt16String(packet.Balance.ToString());
	}
}
