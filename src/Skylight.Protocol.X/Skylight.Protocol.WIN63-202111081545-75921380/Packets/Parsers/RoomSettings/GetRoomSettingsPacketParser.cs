using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.RoomSettings;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.RoomSettings;

[PacketParserId(2467u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetRoomSettingsPacketParser : IIncomingPacketParser<GetRoomSettingsPacketParser.GetRoomSettingsIncomingPacket>
{
	public GetRoomSettingsIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetRoomSettingsIncomingPacket
		{
			RoomId = reader.ReadInt32()
		};
	}

	internal readonly struct GetRoomSettingsIncomingPacket : IGetRoomSettingsIncomingPacket
	{
		public int RoomId { get; init; }
	}
}
