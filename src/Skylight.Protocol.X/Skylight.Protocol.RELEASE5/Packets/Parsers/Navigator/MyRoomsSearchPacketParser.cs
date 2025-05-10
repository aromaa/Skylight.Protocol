using System.Buffers;
using System.Buffers.Text;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Navigator;
using Net.Buffers;
using Net.Buffers.Extensions;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE5.Packets.Parsers.Navigator;

[PacketParserId("SEARCHFLATFORUSER")]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class MyRoomsSearchPacketParser : IIncomingPacketParser<MyRoomsSearchPacketParser.MyRoomsSearchIncomingPacket>
{
	public MyRoomsSearchIncomingPacket Parse(ref PacketReader reader)
	{
		return new MyRoomsSearchIncomingPacket();
	}

	internal readonly struct MyRoomsSearchIncomingPacket : IMyRoomsSearchIncomingPacket
	{
	}
}
