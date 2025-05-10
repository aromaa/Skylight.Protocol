using System.Buffers;
using System.Buffers.Text;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Handshake;
using Net.Buffers;
using Net.Buffers.Extensions;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE1.Packets.Parsers.Handshake;

[PacketParserId("VERSIONCHECK")]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class VersionCheckPacketParser : IIncomingPacketParser<VersionCheckPacketParser.VersionCheckIncomingPacket>
{
	public VersionCheckIncomingPacket Parse(ref PacketReader reader)
	{
		return new VersionCheckIncomingPacket
		{
			VersionId = reader.GetReaderRef().TryReadTo(out ReadOnlySequence<byte> versionid, (byte)' ') ? versionid : reader.ReadBytes(reader.Remaining)
		};
	}

	internal readonly struct VersionCheckIncomingPacket : IVersionCheckIncomingPacket
	{
		public ReadOnlySequence<byte> VersionId { get; init; }
		public ReadOnlySequence<byte> ClientUrl => default;
		public ReadOnlySequence<byte> ExternalVariablesUrl => default;
	}
}
