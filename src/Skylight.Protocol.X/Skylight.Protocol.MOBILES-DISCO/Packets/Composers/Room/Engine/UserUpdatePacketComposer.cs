using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.MOBILES_DISCO.Packets.Composers.Room.Engine;

[PacketComposerId("STATUS")]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class UserUpdatePacketComposer : IOutgoingPacketComposer<UserUpdateOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in UserUpdateOutgoingPacket packet)
	{
		writer.WriteVL64Int32(packet.Updates.Count);
		foreach (var updates in packet.Updates)
		{
			writer.WriteDelimiter2BrokenString($"{updates.Username}{" "}{updates.X}{","}{updates.Y}{","}{updates.Z}{","}{updates.HeadDirection}{","}{updates.BodyDirection}{"/"}{updates.Data}".ToString());
		}
	}
}
