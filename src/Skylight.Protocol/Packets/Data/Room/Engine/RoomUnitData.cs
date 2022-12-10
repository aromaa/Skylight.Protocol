using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.Room.Engine;

//TODO: Abstract
public sealed class RoomUnitData
{
	public required int IdentifierId { get; set; }
	public required int RoomUnitId { get; set; }

	public required string Name { get; init; }
	public required string Motto { get; init; }

	public required string Figure { get; init; }
	public required string Gender { get; init; }
	public required string SwimSuit { get; init; }

	public required int X { get; init; }
	public required int Y { get; init; }
	public required double Z { get; init; }

	public required int Direction { get; init; }

	public required int Type { get; init; }

	public required int GroupId { get; init; }
	public required int GroupStatus { get; init; }
	public required string GroupName { get; init; }

	public required int AchievementScore { get; init; }

	public required bool IsModerator { get; init; }

	public RoomUnitData()
	{
	}

	[SetsRequiredMembers]
	public RoomUnitData(int identifierId, int roomUnitId, string name, string motto, string figure, string gender, string swimSuit, int x, int y, double z, int direction, int type, int groupId, int groupStatus, string groupName, int achievementScore, bool isModerator)
	{
		this.IdentifierId = identifierId;
		this.RoomUnitId = roomUnitId;

		this.Name = name;
		this.Motto = motto;

		this.Figure = figure;
		this.Gender = gender;
		this.SwimSuit = swimSuit;

		this.X = x;
		this.Y = y;
		this.Z = z;

		this.Direction = direction;

		this.Type = type;

		this.GroupId = groupId;
		this.GroupStatus = groupStatus;
		this.GroupName = groupName;

		this.AchievementScore = achievementScore;

		this.IsModerator = isModerator;
	}
}
