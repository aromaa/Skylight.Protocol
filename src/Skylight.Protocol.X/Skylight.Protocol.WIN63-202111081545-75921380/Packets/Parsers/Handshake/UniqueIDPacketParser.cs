using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Handshake;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Handshake;

[PacketParserId(1542u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class UniqueIDPacketParser : IIncomingPacketParser<UniqueIDPacketParser.UniqueIDIncomingPacket>
{
	public UniqueIDIncomingPacket Parse(ref PacketReader reader)
	{
		return new UniqueIDIncomingPacket
		{
			MachineId = reader.ReadBytes(reader.ReadInt16()),
			Fingerprint = reader.ReadBytes(reader.ReadInt16()),
			FlashVersion = reader.Readable ? reader.ReadBytes(reader.ReadInt16()) : ReadOnlySequence<byte>.Empty
		};
	}

	internal readonly struct UniqueIDIncomingPacket : IUniqueIDIncomingPacket
	{
		public ReadOnlySequence<byte> MachineId { get; init; }
		public ReadOnlySequence<byte> Fingerprint { get; init; }
		public ReadOnlySequence<byte> FlashVersion { get; init; }
	}
}
