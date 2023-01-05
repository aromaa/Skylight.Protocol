using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.Inventory.Achievements;

public sealed class AchievementData
{
	public required int Id { get; init; }

	public required string Category { get; init; }

	public required int NextLevel { get; init; }
	public required string NextLevelBadgeCode { get; init; }

	public required int MaximumLevel { get; init; }
	public required bool Completed { get; init; }

	public required int CurrentProgress { get; init; }
	public required int PreviousProgressRequirement { get; init; }
	public required int CurrentProgressRequirement { get; init; }

	public required int NextLevelRewardPoints { get; init; }
	public required int NextLevelRewardPointsType { get; init; }

	public required int DisplayMode { get; init; }
	public required int State { get; init; }

	public AchievementData()
	{
	}

	[SetsRequiredMembers]
	public AchievementData(int id, string category, int nextLevel, string nextLevelBadgeCode, int maximumLevel, bool completed, int currentProgress, int previousProgressRequirement, int currentProgressRequirement, int nextLevelRewardPoints, int nextLevelRewardPointsType, int displayMode, int state)
	{
		this.Id = id;

		this.Category = category;

		this.NextLevel = nextLevel;
		this.NextLevelBadgeCode = nextLevelBadgeCode;

		this.MaximumLevel = maximumLevel;
		this.Completed = completed;

		this.CurrentProgress = currentProgress;
		this.PreviousProgressRequirement = previousProgressRequirement;
		this.CurrentProgressRequirement = currentProgressRequirement;

		this.NextLevelRewardPoints = nextLevelRewardPoints;
		this.NextLevelRewardPointsType = nextLevelRewardPointsType;

		this.DisplayMode = displayMode;
		this.State = state;
	}
}
