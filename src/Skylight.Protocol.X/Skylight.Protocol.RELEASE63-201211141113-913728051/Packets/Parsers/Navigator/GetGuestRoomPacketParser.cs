using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Navigator;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Parsers.Navigator;

[PacketParserId(858u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetGuestRoomPacketParser : IIncomingPacketParser<GetGuestRoomPacketParser.GetGuestRoomIncomingPacket>
{
	public GetGuestRoomIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetGuestRoomIncomingPacket
		{
			RoomId = reader.ReadInt32(),
			EnterRoom = reader.ReadInt32() != 0,
			RoomForward = reader.ReadInt32() != 0
		};
	}

	internal readonly struct GetGuestRoomIncomingPacket : IGetGuestRoomIncomingPacket
	{
		public int RoomId { get; init; }
		public bool EnterRoom { get; init; }
		public bool RoomForward { get; init; }
	}
}
