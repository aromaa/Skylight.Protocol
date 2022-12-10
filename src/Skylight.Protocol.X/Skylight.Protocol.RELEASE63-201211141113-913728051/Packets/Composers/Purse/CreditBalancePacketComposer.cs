using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Purse;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Composers.Purse;

[PacketComposerId(2995u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class CreditBalancePacketComposer : IOutgoingPacketComposer<CreditBalanceOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in CreditBalanceOutgoingPacket packet)
	{
		writer.WriteFixedUInt16String(packet.Balance.ToString());
	}
}
