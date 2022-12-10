using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Parsers.Room.Engine;

[PacketParserId(90u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class PlaceObjectPacketParser : IIncomingPacketParser<PlaceObjectPacketParser.PlaceObjectIncomingPacket>
{
	public PlaceObjectIncomingPacket Parse(ref PacketReader reader)
	{
		return new PlaceObjectIncomingPacket
		{
			Values = reader.ReadBytes(reader.ReadBase64UInt32(2))
		};
	}

	internal readonly struct PlaceObjectIncomingPacket : IPlaceObjectIncomingPacket
	{
		public ReadOnlySequence<byte> Values { get; init; }
	}
}
