using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Room.Session;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Room.Session;

[PacketParserId(46u)]
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
		public bool IsPublicRoom => default;
		public int RoomId { get; init; }
		public ReadOnlySequence<byte> Password { get; init; }
		public int Unused { get; init; }
	}
}
