using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Users;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Users;

[PacketComposerId(2698u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class IgnoredUsersPacketComposer : IOutgoingPacketComposer<IgnoredUsersOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in IgnoredUsersOutgoingPacket packet)
	{
		writer.WriteInt32(packet.IgnoredUsers.Count);
		foreach (var ignoredUsers in packet.IgnoredUsers)
		{
			writer.WriteFixedUInt16String(ignoredUsers);
		}
	}
}
