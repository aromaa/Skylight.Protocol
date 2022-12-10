using System.Buffers;
using Skylight.Protocol.Attributes;

namespace Skylight.Protocol.Packets.Incoming.Competition;

[IntroducedIn("RELEASE63-201211141113-913728051")]
public interface IGetCurrentTimingCodeIncomingPacket : IGameIncomingPacket
{
	public ReadOnlySequence<byte> SchedulingCode { get; }
}
