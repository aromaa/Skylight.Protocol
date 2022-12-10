using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Notifications;

public sealed class MOTDNotificationOutgoingPacket : IGameOutgoingPacket
{
	public required ICollection<string> Messages { get; init; }

	public MOTDNotificationOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public MOTDNotificationOutgoingPacket(ICollection<string> messages)
	{
		this.Messages = messages;
	}
}
