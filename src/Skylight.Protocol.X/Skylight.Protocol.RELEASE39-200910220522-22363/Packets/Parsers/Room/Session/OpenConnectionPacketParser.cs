using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Room.Session;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Parsers.Room.Session;

[PacketParserId(2u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class OpenConnectionPacketParser : IIncomingPacketParser<OpenConnectionPacketParser.OpenConnectionIncomingPacket>
{
	public OpenConnectionIncomingPacket Parse(ref PacketReader reader)
	{
		return new OpenConnectionIncomingPacket
		{
			InstanceType = (int)reader.ReadVL64UInt32(),
			InstanceId = (int)reader.ReadVL64UInt32(),
			WorldId = (int)reader.ReadVL64UInt32()
		};
	}

	internal readonly struct OpenConnectionIncomingPacket : IOpenConnectionIncomingPacket
	{
		public int InstanceType { get; init; }
		public int InstanceId { get; init; }
		public int WorldId { get; init; }
	}
}
