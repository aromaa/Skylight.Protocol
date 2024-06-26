using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Avatar;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Avatar;

[PacketParserId(3198u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class SaveWardrobeOutfitPacketParser : IIncomingPacketParser<SaveWardrobeOutfitPacketParser.SaveWardrobeOutfitIncomingPacket>
{
	public SaveWardrobeOutfitIncomingPacket Parse(ref PacketReader reader)
	{
		return new SaveWardrobeOutfitIncomingPacket
		{
			SlotId = reader.ReadInt32(),
			Figure = reader.ReadBytes(reader.ReadInt16()),
			Gender = reader.ReadBytes(reader.ReadInt16())
		};
	}

	internal readonly struct SaveWardrobeOutfitIncomingPacket : ISaveWardrobeOutfitIncomingPacket
	{
		public int SlotId { get; init; }
		public ReadOnlySequence<byte> Gender { get; init; }
		public ReadOnlySequence<byte> Figure { get; init; }
	}
}
