using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Inventory.Achievements;

namespace Skylight.Protocol.Packets.Outgoing.Inventory.Achievements;

public sealed class AchievementsOutgoingPacket : IGameOutgoingPacket
{
	public required ICollection<AchievementData> Achievements { get; init; }

	public required string DefaultCategory { get; init; }

	public AchievementsOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public AchievementsOutgoingPacket(ICollection<AchievementData> achievements, string defaultCategory)
	{
		this.Achievements = achievements;

		this.DefaultCategory = defaultCategory;
	}
}
