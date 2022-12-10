using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Room.Furniture;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Room.Furniture;

[PacketParserId(2883u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class AddSpamWallPostItPacketParser : IIncomingPacketParser<AddSpamWallPostItPacketParser.AddSpamWallPostItIncomingPacket>
{
	public AddSpamWallPostItIncomingPacket Parse(ref PacketReader reader)
	{
		return new AddSpamWallPostItIncomingPacket
		{
			Id = reader.ReadInt32(),
			Location = reader.ReadBytes(reader.ReadInt16()),
			Color = reader.ReadBytes(reader.ReadInt16()),
			Text = reader.ReadBytes(reader.ReadInt16())
		};
	}

	internal readonly struct AddSpamWallPostItIncomingPacket : IAddSpamWallPostItIncomingPacket
	{
		public int Id { get; init; }
		public ReadOnlySequence<byte> Location { get; init; }
		public ReadOnlySequence<byte> Color { get; init; }
		public ReadOnlySequence<byte> Text { get; init; }
	}
}
