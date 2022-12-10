using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Attributes;
using Skylight.Protocol.Packets.Data.Game.Lobby;

namespace Skylight.Protocol.Packets.Outgoing.Game.Lobby;

[IntroducedIn("RELEASE63-201211141113-913728051")]
public sealed class GameListOutgoingPacket : IGameOutgoingPacket
{
	public required ICollection<GameData> Games { get; init; }

	public GameListOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public GameListOutgoingPacket(ICollection<GameData> games)
	{
		this.Games = games;
	}
}
