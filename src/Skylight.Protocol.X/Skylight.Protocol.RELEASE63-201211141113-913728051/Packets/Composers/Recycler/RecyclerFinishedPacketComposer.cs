using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Recycler;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Composers.Recycler;

[PacketComposerId(1235u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class RecyclerFinishedPacketComposer : IOutgoingPacketComposer<RecyclerFinishedOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in RecyclerFinishedOutgoingPacket packet)
	{
		writer.WriteInt32(packet.Status);
		writer.WriteInt32(packet.PrizeId);
	}
}
