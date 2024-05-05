using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Registration;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE9.Packets.Parsers.Registration;

[PacketParserId(203u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class ApprovePasswordPacketParser : IIncomingPacketParser<ApprovePasswordPacketParser.ApprovePasswordIncomingPacket>
{
	public ApprovePasswordIncomingPacket Parse(ref PacketReader reader)
	{
		return new ApprovePasswordIncomingPacket
		{
			Username = reader.ReadBytes(reader.ReadBase64UInt32(2)),
			Password = reader.ReadBytes(reader.ReadBase64UInt32(2))
		};
	}

	internal readonly struct ApprovePasswordIncomingPacket : IApprovePasswordIncomingPacket
	{
		public ReadOnlySequence<byte> Username { get; init; }
		public ReadOnlySequence<byte> Password { get; init; }
	}
}
