using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Game.Lobby;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Composers.Game.Lobby;

[PacketComposerId(2079u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GameListPacketComposer : IOutgoingPacketComposer<GameListOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in GameListOutgoingPacket packet)
	{
		writer.WriteInt32(packet.Games.Count);
		foreach (var games in packet.Games)
		{
			writer.WriteInt32(games.Id);
			writer.WriteFixedUInt16String(games.Name);
			writer.WriteFixedUInt16String(games.BackgroundColor);
			writer.WriteFixedUInt16String(games.TextColor);
			writer.WriteFixedUInt16String(games.Icon);
		}
	}
}
