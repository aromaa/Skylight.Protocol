using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Notifications;

public sealed class InfoFeedEnableOutgoingPacket : IGameOutgoingPacket
{
	public required bool Enabled { get; init; }

	public InfoFeedEnableOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public InfoFeedEnableOutgoingPacket(bool enabled)
	{
		this.Enabled = enabled;
	}
}
