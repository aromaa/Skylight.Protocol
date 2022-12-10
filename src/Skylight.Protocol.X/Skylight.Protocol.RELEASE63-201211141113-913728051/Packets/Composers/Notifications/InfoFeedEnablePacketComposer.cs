using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Notifications;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Composers.Notifications;

[PacketComposerId(2017u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class InfoFeedEnablePacketComposer : IOutgoingPacketComposer<InfoFeedEnableOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in InfoFeedEnableOutgoingPacket packet)
	{
		writer.WriteBool(packet.Enabled);
	}
}
