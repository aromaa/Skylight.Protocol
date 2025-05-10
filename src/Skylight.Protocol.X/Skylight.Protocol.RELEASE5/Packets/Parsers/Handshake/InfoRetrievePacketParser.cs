using System.Buffers;
using System.Buffers.Text;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Handshake;
using Net.Buffers;
using Net.Buffers.Extensions;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE5.Packets.Parsers.Handshake;

[PacketParserId("INFORETRIEVE")]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class InfoRetrievePacketParser : IIncomingPacketParser<InfoRetrievePacketParser.InfoRetrieveIncomingPacket>
{
	public InfoRetrieveIncomingPacket Parse(ref PacketReader reader)
	{
		return new InfoRetrieveIncomingPacket
		{
			Username = reader.GetReaderRef().TryReadTo(out ReadOnlySequence<byte> username, (byte)' ') ? username : reader.ReadBytes(reader.Remaining),
			Password = reader.GetReaderRef().TryReadTo(out ReadOnlySequence<byte> password, (byte)' ') ? password : reader.ReadBytes(reader.Remaining)
		};
	}

	internal readonly struct InfoRetrieveIncomingPacket : IInfoRetrieveIncomingPacket
	{
		public ReadOnlySequence<byte> Username { get; init; }
		public ReadOnlySequence<byte> Password { get; init; }
	}
}
