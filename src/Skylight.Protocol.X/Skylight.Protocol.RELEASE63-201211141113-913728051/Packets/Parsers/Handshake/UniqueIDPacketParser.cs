using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Handshake;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Parsers.Handshake;

[PacketParserId(3570u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class UniqueIDPacketParser : IIncomingPacketParser<UniqueIDPacketParser.UniqueIDIncomingPacket>
{
	public UniqueIDIncomingPacket Parse(ref PacketReader reader)
	{
		return new UniqueIDIncomingPacket
		{
			MachineId = reader.ReadBytes(reader.ReadInt16()),
			Fingerprint = reader.ReadBytes(reader.ReadInt16())
		};
	}

	internal readonly struct UniqueIDIncomingPacket : IUniqueIDIncomingPacket
	{
		public ReadOnlySequence<byte> MachineId { get; init; }
		public ReadOnlySequence<byte> Fingerprint { get; init; }
		public ReadOnlySequence<byte> FlashVersion => default;
	}
}
