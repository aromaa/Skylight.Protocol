using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Notifications;

public sealed class ActivityPointNotificationOutgoingPacket : IGameOutgoingPacket
{
	public required int Type { get; init; }
	public required int Balance { get; init; }
	public required int Change { get; init; }

	public ActivityPointNotificationOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public ActivityPointNotificationOutgoingPacket(int type, int balance, int change)
	{
		this.Type = type;
		this.Balance = balance;
		this.Change = change;
	}
}
