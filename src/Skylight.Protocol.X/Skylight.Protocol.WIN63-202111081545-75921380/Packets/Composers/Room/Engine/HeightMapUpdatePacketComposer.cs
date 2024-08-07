using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Room.Engine;

[PacketComposerId(2337u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class HeightMapUpdatePacketComposer : IOutgoingPacketComposer<HeightMapUpdateOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in HeightMapUpdateOutgoingPacket packet)
	{
		writer.WriteByte((byte)packet.Updates.Count);
		foreach (var updates in packet.Updates)
		{
			writer.WriteByte((byte)updates.X);
			writer.WriteByte((byte)updates.Y);
			writer.WriteInt16((short)updates.Data.ModernFormat);
		}
	}
}
