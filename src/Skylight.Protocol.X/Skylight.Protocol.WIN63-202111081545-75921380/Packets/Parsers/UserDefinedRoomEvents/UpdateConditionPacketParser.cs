using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.UserDefinedRoomEvents;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.UserDefinedRoomEvents;

[PacketParserId(1801u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class UpdateConditionPacketParser : IIncomingPacketParser<UpdateConditionPacketParser.UpdateConditionIncomingPacket>
{
	public UpdateConditionIncomingPacket Parse(ref PacketReader reader)
	{
		return new UpdateConditionIncomingPacket
		{
			ItemId = reader.ReadInt32(),
			IntegerParameters = ReadIntegerParameters(ref reader),
			StringParameter = reader.ReadBytes(reader.ReadInt16()),
			SelectedItems = ReadSelectedItems(ref reader),
			ItemSelectionType = reader.ReadInt32()
		};

		static IList<int> ReadIntegerParameters(ref PacketReader reader)
		{
			List<int> list = new();
			int count = reader.ReadInt32();
			for (int i = 0; i < count; i++)
			{
				list.Add(reader.ReadInt32());
			}
			return list;
		};

		static IList<int> ReadSelectedItems(ref PacketReader reader)
		{
			List<int> list = new();
			int count = reader.ReadInt32();
			for (int i = 0; i < count; i++)
			{
				list.Add(reader.ReadInt32());
			}
			return list;
		};
	}

	internal readonly struct UpdateConditionIncomingPacket : IUpdateConditionIncomingPacket
	{
		public int ItemId { get; init; }
		public IList<int> SelectedItems { get; init; }
		public int ItemSelectionType { get; init; }
		public IList<int> IntegerParameters { get; init; }
		public ReadOnlySequence<byte> StringParameter { get; init; }
	}
}
