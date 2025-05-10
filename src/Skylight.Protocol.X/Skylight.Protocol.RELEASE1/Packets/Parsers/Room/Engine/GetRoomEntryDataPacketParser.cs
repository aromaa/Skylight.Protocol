using System.Buffers;
using System.Buffers.Text;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Room.Engine;
using Net.Buffers;
using Net.Buffers.Extensions;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE1.Packets.Parsers.Room.Engine;

[PacketParserId("GOTOFLAT")]
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
