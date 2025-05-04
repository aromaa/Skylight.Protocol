using System.Buffers;
using System.Buffers.Text;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Room.Chat;
using Net.Buffers;
using Net.Buffers.Extensions;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.MOBILES_DISCO.Packets.Parsers.Room.Chat;

[PacketParserId("SHOUT")]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class ShoutPacketParser : IIncomingPacketParser<ShoutPacketParser.ShoutIncomingPacket>
{
	public ShoutIncomingPacket Parse(ref PacketReader reader)
	{
		return new ShoutIncomingPacket
		{
			Text = reader.ReadBytes(reader.Remaining)
		};
	}

	internal readonly struct ShoutIncomingPacket : IShoutIncomingPacket
	{
		public ReadOnlySequence<byte> Text { get; init; }
		public int StyleId => default;
	}
}
