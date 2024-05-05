using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Registration;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE9.Packets.Composers.Registration;

[PacketComposerId(8u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class AvailableSetsPacketComposer : IOutgoingPacketComposer<AvailableSetsOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in AvailableSetsOutgoingPacket packet)
	{
		writer.WriteText('[' + string.Join(',', packet.Sets) + ']');
	}
}
