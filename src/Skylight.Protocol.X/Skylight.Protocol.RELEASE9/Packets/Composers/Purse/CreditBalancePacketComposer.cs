using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Purse;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE9.Packets.Composers.Purse;

[PacketComposerId(6u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class CreditBalancePacketComposer : IOutgoingPacketComposer<CreditBalanceOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in CreditBalanceOutgoingPacket packet)
	{
		writer.WriteDelimiter2BrokenString(packet.Balance.ToString());
	}
}
