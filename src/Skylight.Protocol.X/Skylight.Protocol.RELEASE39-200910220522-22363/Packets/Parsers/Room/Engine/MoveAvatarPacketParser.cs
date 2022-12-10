using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Parsers.Room.Engine;

[PacketParserId(75u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class MoveAvatarPacketParser : IIncomingPacketParser<MoveAvatarPacketParser.MoveAvatarIncomingPacket>
{
	public MoveAvatarIncomingPacket Parse(ref PacketReader reader)
	{
		return new MoveAvatarIncomingPacket
		{
			X = (int)reader.ReadVL64UInt32(),
			Y = (int)reader.ReadVL64UInt32()
		};
	}

	internal readonly struct MoveAvatarIncomingPacket : IMoveAvatarIncomingPacket
	{
		public int X { get; init; }
		public int Y { get; init; }
	}
}
