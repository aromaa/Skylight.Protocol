using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Room.Chat;

public sealed class UserTypingOutgoingPacket : IGameOutgoingPacket
{
	public required int UserId { get; init; }

	public required int Typing { get; init; }

	public UserTypingOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public UserTypingOutgoingPacket(int userId, bool typing)
	{
		this.UserId = userId;

		this.Typing = typing ? 1 : 0;
	}
}
