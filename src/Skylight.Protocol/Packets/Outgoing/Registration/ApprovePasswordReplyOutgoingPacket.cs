using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Registration;

namespace Skylight.Protocol.Packets.Outgoing.Registration;

public sealed class ApprovePasswordReplyOutgoingPacket : IGameOutgoingPacket
{
	public required ApprovePasswordResult Result { get; init; }

	public ApprovePasswordReplyOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public ApprovePasswordReplyOutgoingPacket(ApprovePasswordResult result)
	{
		this.Result = result;
	}
}
