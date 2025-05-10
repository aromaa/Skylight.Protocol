using System.Buffers;
using System.Buffers.Text;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Navigator;
using Net.Buffers;
using Net.Buffers.Extensions;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE1.Packets.Parsers.Navigator;

[PacketParserId("INITUNITLISTENER")]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class ListenOfficialRoomsPacketParser : IIncomingPacketParser<ListenOfficialRoomsPacketParser.ListenOfficialRoomsIncomingPacket>
{
	public ListenOfficialRoomsIncomingPacket Parse(ref PacketReader reader)
	{
		return new ListenOfficialRoomsIncomingPacket();
	}

	internal readonly struct ListenOfficialRoomsIncomingPacket : IListenOfficialRoomsIncomingPacket
	{
	}
}
