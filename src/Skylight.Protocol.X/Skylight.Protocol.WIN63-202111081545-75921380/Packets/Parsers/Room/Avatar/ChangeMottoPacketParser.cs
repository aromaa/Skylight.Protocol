using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Room.Avatar;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Room.Avatar;

[PacketParserId(2994u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class ChangeMottoPacketParser : IIncomingPacketParser<ChangeMottoPacketParser.ChangeMottoIncomingPacket>
{
	public ChangeMottoIncomingPacket Parse(ref PacketReader reader)
	{
		return new ChangeMottoIncomingPacket
		{
			Motto = reader.ReadBytes(reader.ReadInt16())
		};
	}

	internal readonly struct ChangeMottoIncomingPacket : IChangeMottoIncomingPacket
	{
		public ReadOnlySequence<byte> Motto { get; init; }
	}
}
