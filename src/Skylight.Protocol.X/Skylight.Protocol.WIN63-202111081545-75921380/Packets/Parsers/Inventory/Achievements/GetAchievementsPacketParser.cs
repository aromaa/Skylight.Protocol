using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Inventory.Achievements;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Inventory.Achievements;

[PacketParserId(1292u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetAchievementsPacketParser : IIncomingPacketParser<GetAchievementsPacketParser.GetAchievementsIncomingPacket>
{
	public GetAchievementsIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetAchievementsIncomingPacket();
	}

	internal readonly struct GetAchievementsIncomingPacket : IGetAchievementsIncomingPacket
	{
	}
}
