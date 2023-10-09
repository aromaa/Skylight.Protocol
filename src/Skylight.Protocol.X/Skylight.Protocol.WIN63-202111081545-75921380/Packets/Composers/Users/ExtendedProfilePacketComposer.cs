using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Users;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Users;

[PacketComposerId(2854u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class ExtendedProfilePacketComposer : IOutgoingPacketComposer<ExtendedProfileOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in ExtendedProfileOutgoingPacket packet)
	{
		writer.WriteInt32(packet.Profile.UserId);
		writer.WriteFixedUInt16String(packet.Profile.Username);
		writer.WriteFixedUInt16String(packet.Profile.Figure);
		writer.WriteFixedUInt16String(packet.Profile.Motto);
		writer.WriteFixedUInt16String(packet.Profile.CreationDate);
		writer.WriteInt32(packet.Profile.AchievementScore);
		writer.WriteInt32(packet.Profile.FriendCount);
		writer.WriteBool(packet.Profile.Friends);
		writer.WriteBool(packet.Profile.FriendRequestSent);
		writer.WriteBool(packet.Profile.Online);
		writer.WriteInt32(packet.Profile.Groups.Count);
		foreach (var groups in packet.Profile.Groups)
		{
			writer.WriteFixedUInt16String(groups);
		}
		writer.WriteInt32(packet.Profile.LastAccessSinceInSeconds);
		writer.WriteBool(packet.Profile.OpenProfile);
		writer.WriteBool(packet.Profile.PublicProfile);
		writer.WriteInt32(packet.Profile.AccountLevel);
		writer.WriteInt32(packet.Profile.TotalAccountLevel);
		writer.WriteInt32(packet.Profile.StarGemCount);
		writer.WriteBool(packet.Profile.FriendRequestsEnabled);
		writer.WriteBool(packet.Profile.CloseOthers);
	}
}
