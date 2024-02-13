using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Room.Chat;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Parsers.Room.Chat;

[PacketParserId(52u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class ChatPacketParser : IIncomingPacketParser<ChatPacketParser.ChatIncomingPacket>
{
	public ChatIncomingPacket Parse(ref PacketReader reader)
	{
		return new ChatIncomingPacket
		{
			Text = reader.ReadBytes(reader.ReadBase64UInt32(2))
		};
	}

	internal readonly struct ChatIncomingPacket : IChatIncomingPacket
	{
		public ReadOnlySequence<byte> Text { get; init; }
		public int StyleId => default;
		public int TrackingId => default;
	}
}
