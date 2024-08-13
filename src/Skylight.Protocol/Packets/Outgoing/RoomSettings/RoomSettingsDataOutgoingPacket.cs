using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Room.Engine;
using Skylight.Protocol.Packets.Data.RoomSettings;

namespace Skylight.Protocol.Packets.Outgoing.RoomSettings;

public sealed class RoomSettingsDataOutgoingPacket : IGameOutgoingPacket
{
	public required int RoomId { get; init; }

	public required string Name { get; init; }
	public required string Description { get; init; }

	public required int CategoryId { get; init; }
	public required ICollection<string> Tags { get; init; }

	public required RoomEntryType EntryMode { get; init; }
	public required int UsersMax { get; init; }
	public required int UsersMaxLimit { get; init; }

	public required RoomTradeType TradeMode { get; init; }
	public required bool WalkThrough { get; init; }
	public required bool AllowPets { get; init; }
	public required bool AllowPetsToEat { get; init; }
	public required bool AllowNavigatorListing { get; init; }

	public required bool HideWalls { get; init; }
	public required int FloorThickness { get; init; }
	public required int WallThickness { get; init; }

	public required RoomChatSettingsData RoomChatSettings { get; init; }
	public required RoomModerationSettingsData RoomModerationSettings { get; init; }

	public RoomSettingsDataOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public RoomSettingsDataOutgoingPacket(int roomId, string name, string description, int categoryId, ICollection<string> tags, RoomEntryType entryMode, int maxUsers, int maxUsersLimit, RoomTradeType tradeMode,
		bool walkThrough, bool allowPets, bool allowPetsToEat, bool allowNavigatorListing, bool hideWalls, int floorThickness, int wallThickness, RoomChatSettingsData roomChatSettings,
		RoomModerationSettingsData roomModerationSettings)
	{
		this.RoomId = roomId;
		this.Name = name;
		this.Description = description;
		this.CategoryId = categoryId;
		this.Tags = tags;
		this.EntryMode = entryMode;
		this.UsersMax = maxUsers;
		this.UsersMaxLimit = maxUsersLimit;
		this.TradeMode = tradeMode;
		this.WalkThrough = walkThrough;
		this.AllowPets = allowPets;
		this.AllowPetsToEat = allowPetsToEat;
		this.AllowNavigatorListing = allowNavigatorListing;
		this.HideWalls = hideWalls;
		this.FloorThickness = floorThickness;
		this.WallThickness = wallThickness;
		this.RoomChatSettings = roomChatSettings;
		this.RoomModerationSettings = roomModerationSettings;
	}
}
