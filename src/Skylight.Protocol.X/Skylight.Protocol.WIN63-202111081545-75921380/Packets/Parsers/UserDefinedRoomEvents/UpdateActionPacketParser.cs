using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.UserDefinedRoomEvents;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.UserDefinedRoomEvents;

[PacketParserId(3643u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class UpdateActionPacketParser : IIncomingPacketParser<UpdateActionPacketParser.UpdateActionIncomingPacket>
{
	public UpdateActionIncomingPacket Parse(ref PacketReader reader)
	{
		return new UpdateActionIncomingPacket
		{
			ItemId = reader.ReadInt32(),
			IntegerParameters = ReadIntegerParameters(ref reader),
			StringParameter = reader.ReadBytes(reader.ReadInt16()),
			SelectedItems = ReadSelectedItems(ref reader),
			ActionDelay = reader.ReadInt32(),
			ItemSelectionType = reader.ReadInt32()
		};

		static List<System.Int32> ReadIntegerParameters(ref PacketReader reader)
		{
			List<System.Int32> list = new();
			int count = reader.ReadInt32();
			for (int i = 0; i < count; i++)
			{
				list.Add(reader.ReadInt32());
			}
			return list;
		};

		static List<System.Int32> ReadSelectedItems(ref PacketReader reader)
		{
			List<System.Int32> list = new();
			int count = reader.ReadInt32();
			for (int i = 0; i < count; i++)
			{
				list.Add(reader.ReadInt32());
			}
			return list;
		};
	}

	internal readonly struct UpdateActionIncomingPacket : IUpdateActionIncomingPacket
	{
		public int ItemId { get; init; }
		public IList<int> SelectedItems { get; init; }
		public int ItemSelectionType { get; init; }
		public int ActionDelay { get; init; }
		public IList<int> IntegerParameters { get; init; }
		public ReadOnlySequence<byte> StringParameter { get; init; }
	}
}
