using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Room.Engine;

[PacketParserId(2165u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetItemDataPacketParser : IIncomingPacketParser<GetItemDataPacketParser.GetItemDataIncomingPacket>
{
	public GetItemDataIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetItemDataIncomingPacket
		{
			ItemId = reader.ReadInt32()
		};
	}

	internal readonly struct GetItemDataIncomingPacket : IGetItemDataIncomingPacket
	{
		public int ItemId { get; init; }
	}
}
