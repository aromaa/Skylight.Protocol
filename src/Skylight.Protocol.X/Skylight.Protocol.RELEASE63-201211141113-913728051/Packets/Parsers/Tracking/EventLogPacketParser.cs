using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Tracking;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Parsers.Tracking;

[PacketParserId(3870u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class EventLogPacketParser : IIncomingPacketParser<EventLogPacketParser.EventLogIncomingPacket>
{
	public EventLogIncomingPacket Parse(ref PacketReader reader)
	{
		return new EventLogIncomingPacket
		{
			Category = reader.ReadBytes(reader.ReadInt16()),
			Type = reader.ReadBytes(reader.ReadInt16()),
			Action = reader.ReadBytes(reader.ReadInt16()),
			ExtraString = reader.ReadBytes(reader.ReadInt16()),
			ExtraInt = reader.ReadInt32()
		};
	}

	internal readonly struct EventLogIncomingPacket : IEventLogIncomingPacket
	{
		public ReadOnlySequence<byte> Category { get; init; }
		public ReadOnlySequence<byte> Type { get; init; }
		public ReadOnlySequence<byte> Action { get; init; }
		public ReadOnlySequence<byte> ExtraString { get; init; }
		public int ExtraInt { get; init; }
	}
}
