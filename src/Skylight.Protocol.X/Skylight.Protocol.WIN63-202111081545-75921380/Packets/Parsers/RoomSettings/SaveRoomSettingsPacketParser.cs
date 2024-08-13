using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.RoomSettings;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.RoomSettings;

[PacketParserId(3595u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class SaveRoomSettingsPacketParser : IIncomingPacketParser<SaveRoomSettingsPacketParser.SaveRoomSettingsIncomingPacket>
{
	public SaveRoomSettingsIncomingPacket Parse(ref PacketReader reader)
	{
		return new SaveRoomSettingsIncomingPacket
		{
			RoomId = reader.ReadInt32(),
			Name = reader.ReadBytes(reader.ReadInt16()),
			Description = reader.ReadBytes(reader.ReadInt16()),
			EntryMode = (Skylight.Protocol.Packets.Data.Room.Engine.RoomEntryType)reader.ReadInt32(),
			Password = reader.ReadBytes(reader.ReadInt16()),
			UsersMax = reader.ReadInt32(),
			CategoryId = reader.ReadInt32(),
			Tags = ReadTags(ref reader),
			TradeMode = (Skylight.Protocol.Packets.Data.Room.Engine.RoomTradeType)reader.ReadInt32(),
			AllowPets = reader.ReadBool(),
			AllowPetsToEat = reader.ReadBool(),
			WalkThrough = reader.ReadBool(),
			HideWalls = reader.ReadBool(),
			WallThickness = reader.ReadInt32(),
			FloorThickness = reader.ReadInt32(),
			WhoCanMute = reader.ReadInt32(),
			WhoCanKick = reader.ReadInt32(),
			WhoCanBan = reader.ReadInt32(),
			ChatMode = reader.ReadInt32(),
			ChatBubbleSize = reader.ReadInt32(),
			ChatScrollSpeed = reader.ReadInt32(),
			ChatHearRange = reader.ReadInt32(),
			ChatFloodSensitivity = reader.ReadInt32(),
			AllowNavigatorListing = reader.ReadBool()
		};

		static IList<ReadOnlySequence<byte>> ReadTags(ref PacketReader reader)
		{
			List<ReadOnlySequence<byte>> list = new();
			int count = reader.ReadInt32();
			for (int i = 0; i < count; i++)
			{
				list.Add(reader.ReadBytes(reader.ReadInt16()));
			}
			return list;
		};
	}

	internal readonly struct SaveRoomSettingsIncomingPacket : ISaveRoomSettingsIncomingPacket
	{
		public int RoomId { get; init; }
		public ReadOnlySequence<byte> Name { get; init; }
		public ReadOnlySequence<byte> Description { get; init; }
		public int CategoryId { get; init; }
		public IList<ReadOnlySequence<byte>> Tags { get; init; }
		public Skylight.Protocol.Packets.Data.Room.Engine.RoomEntryType EntryMode { get; init; }
		public ReadOnlySequence<byte> Password { get; init; }
		public int UsersMax { get; init; }
		public Skylight.Protocol.Packets.Data.Room.Engine.RoomTradeType TradeMode { get; init; }
		public bool WalkThrough { get; init; }
		public bool AllowPets { get; init; }
		public bool AllowPetsToEat { get; init; }
		public bool AllowNavigatorListing { get; init; }
		public bool HideWalls { get; init; }
		public int FloorThickness { get; init; }
		public int WallThickness { get; init; }
		public int WhoCanMute { get; init; }
		public int WhoCanKick { get; init; }
		public int WhoCanBan { get; init; }
		public int ChatMode { get; init; }
		public int ChatBubbleSize { get; init; }
		public int ChatScrollSpeed { get; init; }
		public int ChatHearRange { get; init; }
		public int ChatFloodSensitivity { get; init; }
	}
}
