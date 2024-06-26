using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Avatar;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Avatar;

[PacketComposerId(5u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class WardrobePacketComposer : IOutgoingPacketComposer<WardrobeOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in WardrobeOutgoingPacket packet)
	{
		writer.WriteInt32(0);
		writer.WriteInt32(packet.Wardrobe.Count);
		foreach (var wardrobe in packet.Wardrobe)
		{
			writer.WriteInt32(wardrobe.SlotId);
			writer.WriteFixedUInt16String(wardrobe.Figure);
			writer.WriteFixedUInt16String(wardrobe.Gender);
		}
	}
}
