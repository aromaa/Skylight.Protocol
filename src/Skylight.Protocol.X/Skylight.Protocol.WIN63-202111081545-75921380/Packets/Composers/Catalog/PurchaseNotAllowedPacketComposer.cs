using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Catalog;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Catalog;

[PacketComposerId(86u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class PurchaseNotAllowedPacketComposer : IOutgoingPacketComposer<PurchaseNotAllowedOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in PurchaseNotAllowedOutgoingPacket packet)
	{
		writer.WriteInt32((int)packet.Reason);
	}
}
