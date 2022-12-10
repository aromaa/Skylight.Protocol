using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Attributes;

namespace Skylight.Protocol.Packets.Outgoing.Competition;

[IntroducedIn("RELEASE63-201211141113-913728051")]
public sealed class CurrentTimingCodeOutgoingPacket : IGameOutgoingPacket
{
	public required string SchedulingCode { get; init; }
	public required string Code { get; init; }

	public CurrentTimingCodeOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public CurrentTimingCodeOutgoingPacket(string schedulingCode, string code)
	{
		this.SchedulingCode = schedulingCode;
		this.Code = code;
	}
}
