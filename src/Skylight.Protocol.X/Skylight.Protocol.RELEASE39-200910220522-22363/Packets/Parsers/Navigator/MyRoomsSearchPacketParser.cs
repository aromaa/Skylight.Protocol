using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Navigator;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Parsers.Navigator;

[PacketParserId(16u)]
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
