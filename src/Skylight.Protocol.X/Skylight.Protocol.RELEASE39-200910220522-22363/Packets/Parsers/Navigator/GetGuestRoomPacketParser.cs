using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Navigator;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Parsers.Navigator;

[PacketParserId(21u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetGuestRoomPacketParser : IIncomingPacketParser<GetGuestRoomPacketParser.GetGuestRoomIncomingPacket>
{
	public GetGuestRoomIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetGuestRoomIncomingPacket
		{
			RoomId = (int)reader.ReadVL64UInt32()
		};
	}

	internal readonly struct GetGuestRoomIncomingPacket : IGetGuestRoomIncomingPacket
	{
		public int RoomId { get; init; }
		public bool EnterRoom => default;
		public bool RoomForward => default;
	}
}
