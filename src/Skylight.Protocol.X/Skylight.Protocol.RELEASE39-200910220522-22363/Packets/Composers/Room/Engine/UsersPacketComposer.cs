using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Composers.Room.Engine;

[PacketComposerId(28u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class UsersPacketComposer : IOutgoingPacketComposer<UsersOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in UsersOutgoingPacket packet)
	{
		writer.WriteVL64Int32(packet.Users.Count);
		foreach (var users in packet.Users)
		{
			writer.WriteVL64Int32(users.IdentifierId);
			writer.WriteDelimiter2BrokenString(users.Name);
			writer.WriteDelimiter2BrokenString(users.Motto);
			writer.WriteDelimiter2BrokenString(users.Figure);
			writer.WriteVL64Int32(users.RoomUnitId);
			writer.WriteVL64Int32(users.X);
			writer.WriteVL64Int32(users.Y);
			writer.WriteDelimiter2BrokenString(users.Z.ToString(CultureInfo.InvariantCulture));
			writer.WriteVL64Int32(users.Direction);
			writer.WriteVL64Int32(users.Type);
			writer.WriteDelimiter2BrokenString(users.Gender);
			writer.WriteVL64Int32(users.AchievementScore);
			writer.WriteVL64Int32(users.GroupId);
			writer.WriteVL64Int32(users.GroupStatus);
			writer.WriteDelimiter2BrokenString(users.SwimSuit);
		}
	}
}
