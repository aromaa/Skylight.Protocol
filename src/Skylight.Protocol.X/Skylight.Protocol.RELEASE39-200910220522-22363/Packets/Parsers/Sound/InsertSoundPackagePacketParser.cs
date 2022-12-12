using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Sound;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Parsers.Sound;

[PacketParserId(219u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class InsertSoundPackagePacketParser : IIncomingPacketParser<InsertSoundPackagePacketParser.InsertSoundPackageIncomingPacket>
{
	public InsertSoundPackageIncomingPacket Parse(ref PacketReader reader)
	{
		return new InsertSoundPackageIncomingPacket
		{
			SoundSetId = (int)reader.ReadVL64UInt32(),
			Slot = (int)reader.ReadVL64UInt32()
		};
	}

	internal readonly struct InsertSoundPackageIncomingPacket : IInsertSoundPackageIncomingPacket
	{
		public int SoundSetId { get; init; }
		public int Slot { get; init; }
	}
}
