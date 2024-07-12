using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Room.Session;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Parsers.Room.Session;

[PacketParserId(1650u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class OpenFlatConnectionPacketParser : IIncomingPacketParser<OpenFlatConnectionPacketParser.OpenFlatConnectionIncomingPacket>
{
	public OpenFlatConnectionIncomingPacket Parse(ref PacketReader reader)
	{
		return new OpenFlatConnectionIncomingPacket
		{
			RoomId = reader.ReadInt32(),
			Password = reader.ReadBytes(reader.ReadInt16()),
			Unused = reader.ReadInt32()
		};
	}

	internal readonly struct OpenFlatConnectionIncomingPacket : IOpenFlatConnectionIncomingPacket
	{
		public int RoomId { get; init; }
		public ReadOnlySequence<byte> Password { get; init; }
		public int Unused { get; init; }
	}
}
