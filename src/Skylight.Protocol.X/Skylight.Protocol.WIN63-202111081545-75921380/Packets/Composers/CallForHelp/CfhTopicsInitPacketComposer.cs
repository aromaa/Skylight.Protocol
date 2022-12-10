using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.CallForHelp;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.CallForHelp;

[PacketComposerId(3089u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class CfhTopicsInitPacketComposer : IOutgoingPacketComposer<CfhTopicsInitOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in CfhTopicsInitOutgoingPacket packet)
	{
		writer.WriteInt32(packet.Categories.Count);
		foreach (var categories in packet.Categories)
		{
			writer.WriteFixedUInt16String(categories.Name);
			writer.WriteInt32(categories.Topics.Count);
			foreach (var topics in categories.Topics)
			{
				writer.WriteFixedUInt16String(topics.Name);
				writer.WriteInt32(topics.Id);
				writer.WriteFixedUInt16String(topics.Consequence);
			}
		}
	}
}
