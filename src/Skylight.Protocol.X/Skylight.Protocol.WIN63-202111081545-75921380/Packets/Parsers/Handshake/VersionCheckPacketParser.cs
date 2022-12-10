using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Handshake;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Handshake;

[PacketParserId(2522u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class VersionCheckPacketParser : IIncomingPacketParser<VersionCheckPacketParser.VersionCheckIncomingPacket>
{
	public VersionCheckIncomingPacket Parse(ref PacketReader reader)
	{
		return new VersionCheckIncomingPacket
		{
			VersionId = reader.ReadInt32(),
			ClientUrl = reader.ReadBytes(reader.ReadInt16()),
			ExternalVariablesUrl = reader.ReadBytes(reader.ReadInt16())
		};
	}

	internal readonly struct VersionCheckIncomingPacket : IVersionCheckIncomingPacket
	{
		public int VersionId { get; init; }
		public ReadOnlySequence<byte> ClientUrl { get; init; }
		public ReadOnlySequence<byte> ExternalVariablesUrl { get; init; }
	}
}
