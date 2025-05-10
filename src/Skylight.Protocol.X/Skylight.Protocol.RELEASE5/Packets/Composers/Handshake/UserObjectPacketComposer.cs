using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Handshake;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE5.Packets.Composers.Handshake;

[PacketComposerId("USEROBJECT")]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class UserObjectPacketComposer : IOutgoingPacketComposer<UserObjectOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in UserObjectOutgoingPacket packet)
	{
		writer.WriteBytes("name="u8);
		writer.WriteText(packet.Username.ToString());
		writer.WriteByte(13);
		writer.WriteBytes("figure="u8);
		writer.WriteText(packet.Figure.ToString());
		writer.WriteByte(13);
		writer.WriteBytes("sex="u8);
		writer.WriteText(packet.Gender.ToString());
		writer.WriteByte(13);
		writer.WriteBytes("customData="u8);
		writer.WriteText(packet.CustomData.ToString());
		writer.WriteByte(13);
		writer.WriteBytes("ph_tickets="u8);
		writer.WriteText(packet.Tickets.ToString());
		writer.WriteByte(13);
		writer.WriteBytes("photo_film="u8);
		writer.WriteText(packet.Film.ToString());
		writer.WriteByte(13);
	}
}
