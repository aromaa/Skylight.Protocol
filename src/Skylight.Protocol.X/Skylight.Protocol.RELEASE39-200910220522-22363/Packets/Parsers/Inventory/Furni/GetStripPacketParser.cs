using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Inventory.Furni;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Parsers.Inventory.Furni;

[PacketParserId(65u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetStripPacketParser : IIncomingPacketParser<GetStripPacketParser.GetStripIncomingPacket>
{
	public GetStripIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetStripIncomingPacket
		{
			Action = (int)reader.ReadVL64UInt32()
		};
	}

	internal readonly struct GetStripIncomingPacket : IGetStripIncomingPacket
	{
		public int Action { get; init; }
	}
}
