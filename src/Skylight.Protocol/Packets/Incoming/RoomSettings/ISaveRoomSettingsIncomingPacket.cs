using System.Buffers;
using Skylight.Protocol.Packets.Data.Room.Engine;

namespace Skylight.Protocol.Packets.Incoming.RoomSettings;

public interface ISaveRoomSettingsIncomingPacket : IGameIncomingPacket
{
	public int RoomId { get; }

	public ReadOnlySequence<byte> Name { get; }
	public ReadOnlySequence<byte> Description { get; }

	public int CategoryId { get; }
	public IList<ReadOnlySequence<byte>> Tags { get; }

	public RoomEntryType EntryMode { get; }
	public ReadOnlySequence<byte> Password { get; }
	public int UsersMax { get; }

	public RoomTradeType TradeMode { get; }
	public bool WalkThrough { get; }
	public bool AllowPets { get; }
	public bool AllowPetsToEat { get; }
	public bool AllowNavigatorListing { get; }

	public bool HideWalls { get; }
	public int FloorThickness { get; }
	public int WallThickness { get; }

	public int WhoCanMute { get; }
	public int WhoCanKick { get; }
	public int WhoCanBan { get; }

	public int ChatMode { get; }
	public int ChatBubbleSize { get; }
	public int ChatScrollSpeed { get; }
	public int ChatHearRange { get; }
	public int ChatFloodSensitivity { get; }
}
