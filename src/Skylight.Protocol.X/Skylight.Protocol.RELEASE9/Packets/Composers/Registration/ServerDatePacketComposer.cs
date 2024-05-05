using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Registration;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE9.Packets.Composers.Registration;

[PacketComposerId(163u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class ServerDatePacketComposer : IOutgoingPacketComposer<ServerDateOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in ServerDateOutgoingPacket packet)
	{
		writer.WriteText(packet.Time.ToString("d-M-yyyy"));
	}
}
