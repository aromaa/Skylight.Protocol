using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Notifications;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Notifications;

[PacketComposerId(3134u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class InfoFeedEnablePacketComposer : IOutgoingPacketComposer<InfoFeedEnableOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in InfoFeedEnableOutgoingPacket packet)
	{
		writer.WriteBool(packet.Enabled);
	}
}
