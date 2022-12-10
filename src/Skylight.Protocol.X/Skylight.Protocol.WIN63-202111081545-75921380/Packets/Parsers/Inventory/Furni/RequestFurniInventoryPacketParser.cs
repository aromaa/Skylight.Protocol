using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Inventory.Furni;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Inventory.Furni;

[PacketParserId(1680u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class RequestFurniInventoryPacketParser : IIncomingPacketParser<RequestFurniInventoryPacketParser.RequestFurniInventoryIncomingPacket>
{
	public RequestFurniInventoryIncomingPacket Parse(ref PacketReader reader)
	{
		return new RequestFurniInventoryIncomingPacket();
	}

	internal readonly struct RequestFurniInventoryIncomingPacket : IRequestFurniInventoryIncomingPacket
	{
	}
}
