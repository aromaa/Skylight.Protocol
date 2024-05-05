using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Registration;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE9.Packets.Parsers.Registration;

[PacketParserId(197u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class ApproveEmailPacketParser : IIncomingPacketParser<ApproveEmailPacketParser.ApproveEmailIncomingPacket>
{
	public ApproveEmailIncomingPacket Parse(ref PacketReader reader)
	{
		return new ApproveEmailIncomingPacket
		{
			Email = reader.ReadBytes(reader.ReadBase64UInt32(2))
		};
	}

	internal readonly struct ApproveEmailIncomingPacket : IApproveEmailIncomingPacket
	{
		public ReadOnlySequence<byte> Email { get; init; }
	}
}
