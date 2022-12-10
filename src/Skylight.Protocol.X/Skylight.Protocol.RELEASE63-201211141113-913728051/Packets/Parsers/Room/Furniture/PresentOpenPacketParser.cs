using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Room.Furniture;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Parsers.Room.Furniture;

[PacketParserId(225u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class PresentOpenPacketParser : IIncomingPacketParser<PresentOpenPacketParser.PresentOpenIncomingPacket>
{
	public PresentOpenIncomingPacket Parse(ref PacketReader reader)
	{
		return new PresentOpenIncomingPacket
		{
			ItemId = reader.ReadInt32()
		};
	}

	internal readonly struct PresentOpenIncomingPacket : IPresentOpenIncomingPacket
	{
		public int ItemId { get; init; }
	}
}
