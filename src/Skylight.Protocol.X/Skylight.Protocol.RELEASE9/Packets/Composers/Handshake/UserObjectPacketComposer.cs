using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Handshake;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE9.Packets.Composers.Handshake;

[PacketComposerId(5u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class UserObjectPacketComposer : IOutgoingPacketComposer<UserObjectOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in UserObjectOutgoingPacket packet)
	{
		writer.WriteText("name");
		writer.WriteText("=");
		writer.WriteText(packet.Username.ToString());
		writer.WriteByte(13);
		writer.WriteText("figure");
		writer.WriteText("=");
		writer.WriteText(packet.Figure.ToString());
		writer.WriteByte(13);
		writer.WriteText("sex");
		writer.WriteText("=");
		writer.WriteText(packet.Gender.ToString());
		writer.WriteByte(13);
		writer.WriteText("customData");
		writer.WriteText("=");
		writer.WriteText(packet.CustomData.ToString());
		writer.WriteByte(13);
		writer.WriteText("ph_tickets");
		writer.WriteText("=");
		writer.WriteText(packet.Tickets.ToString());
		writer.WriteByte(13);
		writer.WriteText("photo_film");
		writer.WriteText("=");
		writer.WriteText(packet.Film.ToString());
		writer.WriteByte(13);
	}
}
