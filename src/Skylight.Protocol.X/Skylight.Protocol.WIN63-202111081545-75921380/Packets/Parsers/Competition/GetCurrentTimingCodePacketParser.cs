using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Competition;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Competition;

[PacketParserId(973u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetCurrentTimingCodePacketParser : IIncomingPacketParser<GetCurrentTimingCodePacketParser.GetCurrentTimingCodeIncomingPacket>
{
	public GetCurrentTimingCodeIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetCurrentTimingCodeIncomingPacket
		{
			SchedulingCode = reader.ReadBytes(reader.ReadInt16())
		};
	}

	internal readonly struct GetCurrentTimingCodeIncomingPacket : IGetCurrentTimingCodeIncomingPacket
	{
		public ReadOnlySequence<byte> SchedulingCode { get; init; }
	}
}
