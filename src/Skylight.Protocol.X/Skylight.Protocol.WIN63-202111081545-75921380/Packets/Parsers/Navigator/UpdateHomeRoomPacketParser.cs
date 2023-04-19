using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Navigator;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Navigator;

[PacketParserId(2116u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class UpdateHomeRoomPacketParser : IIncomingPacketParser<UpdateHomeRoomPacketParser.UpdateHomeRoomIncomingPacket>
{
	public UpdateHomeRoomIncomingPacket Parse(ref PacketReader reader)
	{
		return new UpdateHomeRoomIncomingPacket
		{
			FlatId = reader.ReadInt32()
		};
	}

	internal readonly struct UpdateHomeRoomIncomingPacket : IUpdateHomeRoomIncomingPacket
	{
		public int FlatId { get; init; }
	}
}
