using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Room.Engine;

[PacketComposerId(2471u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class UsersPacketComposer : IOutgoingPacketComposer<UsersOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in UsersOutgoingPacket packet)
	{
		writer.WriteInt32(packet.Users.Count);
		foreach (var users in packet.Users)
		{
			writer.WriteInt32(users.IdentifierId);
			writer.WriteFixedUInt16String(users.Name);
			writer.WriteFixedUInt16String(users.Motto);
			writer.WriteFixedUInt16String(users.Figure);
			writer.WriteInt32(users.RoomUnitId);
			writer.WriteInt32(users.X);
			writer.WriteInt32(users.Y);
			writer.WriteFixedUInt16String(users.Z.ToString(CultureInfo.InvariantCulture));
			writer.WriteInt32(users.Direction);
			writer.WriteInt32(users.Type);
			writer.WriteFixedUInt16String(users.Gender);
			writer.WriteInt32(users.GroupId);
			writer.WriteInt32(users.GroupStatus);
			writer.WriteFixedUInt16String(users.GroupName);
			writer.WriteFixedUInt16String(users.SwimSuit);
			writer.WriteInt32(users.AchievementScore);
			writer.WriteBool(users.IsModerator);
		}
	}
}
