using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Sound;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Sound;

[PacketParserId(1713u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetSoundSettingsPacketParser : IIncomingPacketParser<GetSoundSettingsPacketParser.GetSoundSettingsIncomingPacket>
{
	public GetSoundSettingsIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetSoundSettingsIncomingPacket();
	}

	internal readonly struct GetSoundSettingsIncomingPacket : IGetSoundSettingsIncomingPacket
	{
	}
}
