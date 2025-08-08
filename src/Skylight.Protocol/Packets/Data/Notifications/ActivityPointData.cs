using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.Notifications;

public sealed class ActivityPointData
{
	public required int Type { get; init; }
	public required int Balance { get; init; }

	public ActivityPointData()
	{
	}

	[SetsRequiredMembers]
	public ActivityPointData(int type, int balance)
	{
		this.Type = type;
		this.Balance = balance;
	}
}
