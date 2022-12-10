using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Recycler;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Parsers.Recycler;

[PacketParserId(3781u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class RecycleItemsPacketParser : IIncomingPacketParser<RecycleItemsPacketParser.RecycleItemsIncomingPacket>
{
	public RecycleItemsIncomingPacket Parse(ref PacketReader reader)
	{
		return new RecycleItemsIncomingPacket
		{
			StripIds = ReadStripIds(ref reader)
		};

		static List<System.Int32> ReadStripIds(ref PacketReader reader)
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

	internal readonly struct RecycleItemsIncomingPacket : IRecycleItemsIncomingPacket
	{
		public IList<int> StripIds { get; init; }
	}
}
