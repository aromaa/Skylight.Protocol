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
	public required bool Friends { get; init; }
	public required bool FriendRequestSent { get; init; }
	public required bool Online { get; init; }
	public required List<string> Groups { get; init; }
	public required int LastAccessSinceInSeconds { get; init; }
	public required bool OpenProfile { get; init; }
	public required bool PublicProfile { get; init; }
	public required int AccountLevel { get; init; }
	public required int TotalAccountLevel { get; init; }
	public required int StarGemCount { get; init; }
	public required bool FriendRequestsEnabled { get; init; }
	public required bool CloseOthers { get; init; }

	public ExtendedProfileData()
	{
	}

	[SetsRequiredMembers]
	public ExtendedProfileData(int userId, string username, string figure, string motto, string creationDate, int achievementScore, int friendCount, bool friends, bool friendRequestSent, bool online, List<string> groups, int lastAccessSinceInSeconds, bool openProfile, bool publicProfile, int accountLevel, int totalAccountLevel, int starGemCount, bool friendRequestsEnabled, bool closeOthers)
	{
		this.UserId = userId;
		this.Username = username;
		this.Figure = figure;
		this.Motto = motto;
		this.CreationDate = creationDate;
		this.AchievementScore = achievementScore;
		this.FriendCount = friendCount;
		this.Friends = friends;
		this.FriendRequestSent = friendRequestSent;
		this.Online = online;
		this.Groups = groups;
		this.LastAccessSinceInSeconds = lastAccessSinceInSeconds;
		this.OpenProfile = openProfile;
		this.PublicProfile = publicProfile;
		this.AccountLevel = accountLevel;
		this.TotalAccountLevel = totalAccountLevel;
		this.StarGemCount = starGemCount;
		this.FriendRequestsEnabled = friendRequestsEnabled;
		this.CloseOthers = closeOthers;
	}
}
