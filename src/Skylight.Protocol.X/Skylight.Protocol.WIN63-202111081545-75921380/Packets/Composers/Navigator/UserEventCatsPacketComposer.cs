using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Navigator;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Navigator;

[PacketComposerId(2083u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class UserEventCatsPacketComposer : IOutgoingPacketComposer<UserEventCatsOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in UserEventCatsOutgoingPacket packet)
	{
		writer.WriteInt32(packet.EventCategories.Count);
		foreach (var eventCategories in packet.EventCategories)
		{
			writer.WriteInt32(eventCategories.Id);
			writer.WriteFixedUInt16String(eventCategories.Name);
			writer.WriteBool(eventCategories.Visible);
		}
	}
}
