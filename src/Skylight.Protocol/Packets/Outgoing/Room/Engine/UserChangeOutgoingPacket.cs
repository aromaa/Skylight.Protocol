using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Room.Engine;

public sealed class UserChangeOutgoingPacket : IGameOutgoingPacket
{
	public required int Id { get; init; }
	public required string Figure { get; init; }
	public required string Sex { get; init; }
	public required string CustomInfo { get; init; }
	public required int AchievementScore { get; init; }

	public UserChangeOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public UserChangeOutgoingPacket(int id, string figure, string sex, string custominfo, int achievementScore)
	{
		this.Id = id;
		this.Figure = figure;
		this.Sex = sex;
		this.CustomInfo = custominfo;
		this.AchievementScore = achievementScore;
	}
}
