using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE5.Packets.Composers.Room.Engine;

[PacketComposerId("LOGOUT")]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class UserRemovePacketComposer : IOutgoingPacketComposer<UserRemoveOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in UserRemoveOutgoingPacket packet)
	{
		writer.WriteDelimiterBrokenString(packet.Username, (byte)'\r');
	}
}
