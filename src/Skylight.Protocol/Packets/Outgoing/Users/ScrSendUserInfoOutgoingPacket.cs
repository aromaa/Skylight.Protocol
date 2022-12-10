using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Users;

public sealed class ScrSendUserInfoOutgoingPacket : IGameOutgoingPacket
{
	public required string ProductName { get; init; }

	public required int DaysToPeriodEnd { get; init; }
	public required int MemberPeriods { get; init; }
	public required int PeriodsSubscribedAhead { get; init; }
	public required int ResponseType { get; init; }

	public required bool HasEverBeenMember { get; init; }
	public required bool IsVIP { get; init; }

	public required int PastClubDays { get; init; }
	public required int PastVipDays { get; init; }

	public required int MinutesUntilExpiration { get; init; }
	public required int MinutesSinceLastModified { get; init; }

	public ScrSendUserInfoOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public ScrSendUserInfoOutgoingPacket(string productName, int daysToPeriodEnd, int memberPeriods, int periodsSubscribedAhead, int responseType, bool hasEverBeenMember, bool isVIP, int pastClubDays, int pastVipDays, int minutesUntilExpiration, int minutesSinceLastModified)
	{
		this.ProductName = productName;

		this.DaysToPeriodEnd = daysToPeriodEnd;
		this.MemberPeriods = memberPeriods;
		this.PeriodsSubscribedAhead = periodsSubscribedAhead;
		this.ResponseType = responseType;

		this.HasEverBeenMember = hasEverBeenMember;
		this.IsVIP = isVIP;

		this.PastClubDays = pastClubDays;
		this.PastVipDays = pastVipDays;

		this.MinutesUntilExpiration = minutesUntilExpiration;
		this.MinutesSinceLastModified = minutesSinceLastModified;
	}
}
