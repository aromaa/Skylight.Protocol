using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Registration;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE9.Packets.Parsers.Registration;

[PacketParserId(42u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class ApproveNamePacketParser : IIncomingPacketParser<ApproveNamePacketParser.ApproveNameIncomingPacket>
{
	public ApproveNameIncomingPacket Parse(ref PacketReader reader)
	{
		return new ApproveNameIncomingPacket
		{
			Name = reader.ReadBytes(reader.ReadBase64UInt32(2)),
			Type = (int)reader.ReadVL64UInt32()
		};
	}

	internal readonly struct ApproveNameIncomingPacket : IApproveNameIncomingPacket
	{
		public ReadOnlySequence<byte> Name { get; init; }
		public int Type { get; init; }
	}
}
