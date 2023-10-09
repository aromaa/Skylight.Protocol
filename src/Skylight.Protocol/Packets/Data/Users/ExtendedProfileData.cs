using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.Users;
public sealed class ExtendedProfileData
{
	public required int UserId { get; init; }
	public required string Username { get; init; }
	public required string Figure { get; init; }
	public required string Motto { get; init; }
	public required string CreationDate { get; init; }
	public required int AchievementScore { get; init; }
	public required int FriendCount { get; init; }
	public required bool IsFriend { get; init; }
	public required bool IsFriendRequestSent { get; init; }
	public required bool IsOnline { get; init; }
	public required List<string> Groups { get; init; }
	public required int LastAccessSinceInSeconds { get; init; }
	public required bool OpenProfile { get; init; }
	public required bool SafeStr_1848 { get; init; }
	public required int AccountLevel { get; init; }
	public required int SafeStr_1849 { get; init; }
	public required int StarGemCount { get; init; }
	public required bool SafeStr_1850 { get; init; }
	public required bool SafeStr_1851 { get; init; }

	public ExtendedProfileData()
	{
	}

	[SetsRequiredMembers]
	public ExtendedProfileData(int userId, string username, string figure, string motto, string creationDate, int achievementScore, int friendCount, bool isFriend, bool isFriendRequestSent, bool isOnline, List<string> groups, int lastAccessSinceInSeconds, bool openProfile, bool safeStr_1848, int accountLevel, int safeStr_1849, int starGemCount, bool safeStr_1850, bool safeStr_1851)
	{
		this.UserId = userId;
		this.Username = username;
		this.Figure = figure;
		this.Motto = motto;
		this.CreationDate = creationDate;
		this.AchievementScore = achievementScore;
		this.FriendCount = friendCount;
		this.IsFriend = isFriend;
		this.IsFriendRequestSent = isFriendRequestSent;
		this.IsOnline = isOnline;
		this.Groups = groups;
		this.LastAccessSinceInSeconds = lastAccessSinceInSeconds;
		this.OpenProfile = openProfile;
		this.SafeStr_1848 = safeStr_1848;
		this.AccountLevel = accountLevel;
		this.SafeStr_1849 = safeStr_1849;
		this.StarGemCount = starGemCount;
		this.SafeStr_1850 = safeStr_1850;
		this.SafeStr_1851 = safeStr_1851;
	}
}
