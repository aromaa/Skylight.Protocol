using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Room.Furniture;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Room.Furniture;

[PacketParserId(245u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class PlacePostItPacketParser : IIncomingPacketParser<PlacePostItPacketParser.PlacePostItIncomingPacket>
{
	public PlacePostItIncomingPacket Parse(ref PacketReader reader)
	{
		return new PlacePostItIncomingPacket
		{
			StripId = reader.ReadInt32(),
			Location = reader.ReadBytes(reader.ReadInt16())
		};
	}

	internal readonly struct PlacePostItIncomingPacket : IPlacePostItIncomingPacket
	{
		public int StripId { get; init; }
		public ReadOnlySequence<byte> Location { get; init; }
	}
}
