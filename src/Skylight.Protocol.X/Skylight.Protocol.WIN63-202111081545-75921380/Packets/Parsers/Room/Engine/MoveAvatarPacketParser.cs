using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Room.Engine;

[PacketParserId(778u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class MoveAvatarPacketParser : IIncomingPacketParser<MoveAvatarPacketParser.MoveAvatarIncomingPacket>
{
	public MoveAvatarIncomingPacket Parse(ref PacketReader reader)
	{
		return new MoveAvatarIncomingPacket
		{
			X = reader.ReadInt32(),
			Y = reader.ReadInt32()
		};
	}

	internal readonly struct MoveAvatarIncomingPacket : IMoveAvatarIncomingPacket
	{
		public int X { get; init; }
		public int Y { get; init; }
	}
}
