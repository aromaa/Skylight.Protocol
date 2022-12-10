using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Room.Engine;

[PacketParserId(1411u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetFurnitureAliasesPacketParser : IIncomingPacketParser<GetFurnitureAliasesPacketParser.GetFurnitureAliasesIncomingPacket>
{
	public GetFurnitureAliasesIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetFurnitureAliasesIncomingPacket();
	}

	internal readonly struct GetFurnitureAliasesIncomingPacket : IGetFurnitureAliasesIncomingPacket
	{
	}
}
