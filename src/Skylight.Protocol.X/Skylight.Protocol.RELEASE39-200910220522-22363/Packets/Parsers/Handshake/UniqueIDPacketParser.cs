using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Handshake;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Parsers.Handshake;

[PacketParserId(813u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class UniqueIDPacketParser : IIncomingPacketParser<UniqueIDPacketParser.UniqueIDIncomingPacket>
{
	public UniqueIDIncomingPacket Parse(ref PacketReader reader)
	{
		return new UniqueIDIncomingPacket
		{
			MachineId = reader.ReadBytes(reader.ReadBase64UInt32(2))
		};
	}

	internal readonly struct UniqueIDIncomingPacket : IUniqueIDIncomingPacket
	{
		public ReadOnlySequence<byte> MachineId { get; init; }
		public ReadOnlySequence<byte> Fingerprint => default;
		public ReadOnlySequence<byte> FlashVersion => default;
	}
}
