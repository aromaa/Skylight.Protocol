using System.Buffers;
using System.Buffers.Text;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Room.Chat;
using Net.Buffers;
using Net.Buffers.Extensions;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE5.Packets.Parsers.Room.Chat;

[PacketParserId("CHAT")]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class ChatPacketParser : IIncomingPacketParser<ChatPacketParser.ChatIncomingPacket>
{
	public ChatIncomingPacket Parse(ref PacketReader reader)
	{
		return new ChatIncomingPacket
		{
			Text = reader.ReadBytes(reader.Remaining)
		};
	}

	internal readonly struct ChatIncomingPacket : IChatIncomingPacket
	{
		public ReadOnlySequence<byte> Text { get; init; }
		public int StyleId => default;
		public int TrackingId => default;
	}
}
