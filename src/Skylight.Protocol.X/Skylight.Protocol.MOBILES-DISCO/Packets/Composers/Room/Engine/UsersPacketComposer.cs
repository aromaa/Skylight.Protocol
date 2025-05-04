using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.MOBILES_DISCO.Packets.Composers.Room.Engine;

[PacketComposerId("USERS")]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class UsersPacketComposer : IOutgoingPacketComposer<UsersOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in UsersOutgoingPacket packet)
	{
		writer.WriteVL64Int32(packet.Users.Count);
		foreach (var users in packet.Users)
		{
			writer.WriteDelimiter2BrokenString($"{users.Name}{" "}{users.Figure}{" "}{users.X}{" "}{users.Y}{" "}{users.Z}{" "}{users.Motto}".ToString());
		}
	}
}
