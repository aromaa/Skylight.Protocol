using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Users;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Users;

[PacketComposerId(2857u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class ScrSendUserInfoPacketComposer : IOutgoingPacketComposer<ScrSendUserInfoOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in ScrSendUserInfoOutgoingPacket packet)
	{
		writer.WriteFixedUInt16String(packet.ProductName);
		writer.WriteInt32(packet.DaysToPeriodEnd);
		writer.WriteInt32(packet.MemberPeriods);
		writer.WriteInt32(packet.PeriodsSubscribedAhead);
		writer.WriteInt32(packet.ResponseType);
		writer.WriteBool(packet.HasEverBeenMember);
		writer.WriteBool(packet.IsVIP);
		writer.WriteInt32(packet.PastClubDays);
		writer.WriteInt32(packet.PastVipDays);
		writer.WriteInt32(packet.MinutesUntilExpiration);
		writer.WriteInt32(packet.MinutesSinceLastModified);
	}
}
