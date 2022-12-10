using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Perk;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Perk;

[PacketComposerId(592u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class PerkAllowancesPacketComposer : IOutgoingPacketComposer<PerkAllowancesOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in PerkAllowancesOutgoingPacket packet)
	{
		writer.WriteInt32(packet.Perks.Count);
		foreach (var perks in packet.Perks)
		{
			writer.WriteFixedUInt16String(perks.Code);
			writer.WriteFixedUInt16String(perks.ErrorMessage);
			writer.WriteBool(perks.IsAllowed);
		}
	}
}
