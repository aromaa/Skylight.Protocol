using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Notifications;

namespace Skylight.Protocol.Packets.Outgoing.Notifications;

public sealed class ActivityPointsOutgoingPacket : IGameOutgoingPacket
{
	public required ICollection<ActivityPointData> ActivityPoints { get; init; }

	public ActivityPointsOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public ActivityPointsOutgoingPacket(ICollection<ActivityPointData> activityPoints)
	{
		this.ActivityPoints = activityPoints;
	}
}
