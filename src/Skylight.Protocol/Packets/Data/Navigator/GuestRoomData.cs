using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Room.Engine;

namespace Skylight.Protocol.Packets.Data.Navigator;

public sealed class GuestRoomData
{
	public required int Id { get; init; }

	public required int OwnerId { get; init; }
	public required string OwnerName { get; init; }

	public required string LayoutId { get; init; }

	public required string Name { get; init; }
	public required string Description { get; init; }

	public required int CategoryId { get; init; }
	public required ICollection<string> Tags { get; init; }

	public required RoomEntryType EntryMode { get; init; }
	public required int UserCount { get; init; }
	public required int UsersMax { get; init; }

	public required RoomTradeType TradeMode { get; init; }

	public required int Score { get; init; }
	public required int Ranking { get; init; }

	public GuestRoomData()
	{
	}

	[SetsRequiredMembers]
	public GuestRoomData(int id, int ownerId, string ownerName, string layoutId, string name, string description, int categoryId, ICollection<string> tags, RoomEntryType entryMode, int userCount, int usersMax, RoomTradeType tradeMde, int score, int ranking)
	{
		this.Id = id;
		this.OwnerId = ownerId;
		this.OwnerName = ownerName;
		this.LayoutId = layoutId;
		this.Name = name;
		this.Description = description;
		this.CategoryId = categoryId;
		this.Tags = tags;
		this.EntryMode = entryMode;
		this.UserCount = userCount;
		this.UsersMax = usersMax;
		this.TradeMode = tradeMde;
		this.Score = score;
		this.Ranking = ranking;
	}
}
