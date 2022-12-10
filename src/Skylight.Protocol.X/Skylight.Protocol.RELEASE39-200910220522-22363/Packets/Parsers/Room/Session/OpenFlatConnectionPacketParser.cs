using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Room.Session;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Parsers.Room.Session;

[PacketParserId(2u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class OpenFlatConnectionPacketParser : IIncomingPacketParser<OpenFlatConnectionPacketParser.OpenFlatConnectionIncomingPacket>
{
	public OpenFlatConnectionIncomingPacket Parse(ref PacketReader reader)
	{
		return new OpenFlatConnectionIncomingPacket
		{
			IsPublicRoom = reader.ReadBool(),
			RoomId = (int)reader.ReadVL64UInt32()
		};
	}

	internal readonly struct OpenFlatConnectionIncomingPacket : IOpenFlatConnectionIncomingPacket
	{
		public bool IsPublicRoom { get; init; }
		public int RoomId { get; init; }
		public ReadOnlySequence<byte> Password => default;
		public int Unused => default;
	}
}
