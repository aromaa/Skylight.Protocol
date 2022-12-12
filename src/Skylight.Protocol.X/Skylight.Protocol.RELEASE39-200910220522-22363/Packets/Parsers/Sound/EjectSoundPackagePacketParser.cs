using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Sound;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Parsers.Sound;

[PacketParserId(220u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class EjectSoundPackagePacketParser : IIncomingPacketParser<EjectSoundPackagePacketParser.EjectSoundPackageIncomingPacket>
{
	public EjectSoundPackageIncomingPacket Parse(ref PacketReader reader)
	{
		return new EjectSoundPackageIncomingPacket
		{
			Slot = (int)reader.ReadVL64UInt32()
		};
	}

	internal readonly struct EjectSoundPackageIncomingPacket : IEjectSoundPackageIncomingPacket
	{
		public int Slot { get; init; }
	}
}
