using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Room.Engine;

public sealed class UserChangeOutgoingPacket : IGameOutgoingPacket
{
	public required int RoomUnitId { get; init; }
	public required string Figure { get; init; }
	public required string Gender { get; init; }
	public required string Motto { get; init; }
	public required int AchievementScore { get; init; }

	public UserChangeOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public UserChangeOutgoingPacket(int roomUnitId, string figure, string gender, string motto, int achievementScore)
	{
		this.RoomUnitId = roomUnitId;
		this.Figure = figure;
		this.Gender = gender;
		this.Motto = motto;
		this.AchievementScore = achievementScore;
	}
}
