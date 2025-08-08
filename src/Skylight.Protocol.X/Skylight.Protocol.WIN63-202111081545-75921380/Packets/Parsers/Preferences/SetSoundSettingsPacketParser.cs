using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Preferences;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Preferences;

[PacketParserId(1450u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class SetSoundSettingsPacketParser : IIncomingPacketParser<SetSoundSettingsPacketParser.SetSoundSettingsIncomingPacket>
{
	public SetSoundSettingsIncomingPacket Parse(ref PacketReader reader)
	{
		return new SetSoundSettingsIncomingPacket
		{
			UiVolume = reader.ReadInt32(),
			FurniVolume = reader.ReadInt32(),
			TraxVolume = reader.ReadInt32()
		};
	}

	internal readonly struct SetSoundSettingsIncomingPacket : ISetSoundSettingsIncomingPacket
	{
		public int UiVolume { get; init; }
		public int FurniVolume { get; init; }
		public int TraxVolume { get; init; }
	}
}
