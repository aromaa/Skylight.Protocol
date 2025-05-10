using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Purse;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE5.Packets.Composers.Purse;

[PacketComposerId("WALLETBALANCE")]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class CreditBalancePacketComposer : IOutgoingPacketComposer<CreditBalanceOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in CreditBalanceOutgoingPacket packet)
	{
		writer.WriteDelimiterBrokenString(packet.Balance.ToString(), (byte)'\r');
	}
}
