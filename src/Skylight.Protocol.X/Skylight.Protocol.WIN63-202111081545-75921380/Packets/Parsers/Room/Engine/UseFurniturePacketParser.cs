using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Room.Engine;

[PacketParserId(3226u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class UseFurniturePacketParser : IIncomingPacketParser<UseFurniturePacketParser.UseFurnitureIncomingPacket>
{
	public UseFurnitureIncomingPacket Parse(ref PacketReader reader)
	{
		return new UseFurnitureIncomingPacket
		{
			Id = reader.ReadInt32(),
			State = reader.ReadInt32()
		};
	}

	internal readonly struct UseFurnitureIncomingPacket : IUseFurnitureIncomingPacket
	{
		public int Id { get; init; }
		public int State { get; init; }
	}
}
