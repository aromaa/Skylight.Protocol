using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Navigator;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Navigator;

[PacketParserId(879u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class CreateFlatPacketParser : IIncomingPacketParser<CreateFlatPacketParser.CreateFlatIncomingPacket>
{
	public CreateFlatIncomingPacket Parse(ref PacketReader reader)
	{
		return new CreateFlatIncomingPacket
		{
			RoomName = reader.ReadBytes(reader.ReadInt16()),
			Description = reader.ReadBytes(reader.ReadInt16()),
			LayoutId = reader.ReadBytes(reader.ReadInt16()),
			CategoryId = reader.ReadInt32(),
			MaxUserCount = reader.ReadInt32(),
			TradeMode = reader.ReadInt32()
		};
	}

	internal readonly struct CreateFlatIncomingPacket : ICreateFlatIncomingPacket
	{
		public ReadOnlySequence<byte> RoomName { get; init; }
		public ReadOnlySequence<byte> Description { get; init; }
		public ReadOnlySequence<byte> LayoutId { get; init; }
		public int CategoryId { get; init; }
		public int MaxUserCount { get; init; }
		public int TradeMode { get; init; }
	}
}
