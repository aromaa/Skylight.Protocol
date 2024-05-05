using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Registration;

namespace Skylight.Protocol.Packets.Outgoing.Registration;

public sealed class ApproveNameReplyOutgoingPacket : IGameOutgoingPacket
{
	public required ApproveNameResult Result { get; init; }

	public ApproveNameReplyOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public ApproveNameReplyOutgoingPacket(ApproveNameResult result)
	{
		this.Result = result;
	}
}
