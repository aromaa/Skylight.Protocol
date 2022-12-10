using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Help;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Help;

[PacketParserId(1424u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetCfhStatusPacketParser : IIncomingPacketParser<GetCfhStatusPacketParser.GetCfhStatusIncomingPacket>
{
	public GetCfhStatusIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetCfhStatusIncomingPacket
		{
			Display = reader.ReadBool()
		};
	}

	internal readonly struct GetCfhStatusIncomingPacket : IGetCfhStatusIncomingPacket
	{
		public bool Display { get; init; }
	}
}
