using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Parsers.Room.Engine;

[PacketParserId(60u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetRoomEntryDataPacketParser : IIncomingPacketParser<GetRoomEntryDataPacketParser.GetRoomEntryDataIncomingPacket>
{
	public GetRoomEntryDataIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetRoomEntryDataIncomingPacket();
	}

	internal readonly struct GetRoomEntryDataIncomingPacket : IGetRoomEntryDataIncomingPacket
	{
	}
}
