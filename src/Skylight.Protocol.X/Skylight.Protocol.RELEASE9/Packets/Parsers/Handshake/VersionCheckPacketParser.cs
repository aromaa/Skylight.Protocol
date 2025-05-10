using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Handshake;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE9.Packets.Parsers.Handshake;

[PacketParserId(5u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class VersionCheckPacketParser : IIncomingPacketParser<VersionCheckPacketParser.VersionCheckIncomingPacket>
{
	public VersionCheckIncomingPacket Parse(ref PacketReader reader)
	{
		return new VersionCheckIncomingPacket
		{
			VersionId = reader.ReadBytes(((reader.ReadByte() >> 3) & 0x7) - 1),
			ClientUrl = reader.ReadBytes(reader.ReadBase64UInt32(2)),
			ExternalVariablesUrl = reader.ReadBytes(reader.ReadBase64UInt32(2))
		};
	}

	internal readonly struct VersionCheckIncomingPacket : IVersionCheckIncomingPacket
	{
		public ReadOnlySequence<byte> VersionId { get; init; }
		public ReadOnlySequence<byte> ClientUrl { get; init; }
		public ReadOnlySequence<byte> ExternalVariablesUrl { get; init; }
	}
}
