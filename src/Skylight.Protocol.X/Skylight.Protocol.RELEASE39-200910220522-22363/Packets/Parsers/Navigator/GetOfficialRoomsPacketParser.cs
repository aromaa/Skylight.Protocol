using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Navigator;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Parsers.Navigator;

[PacketParserId(150u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetOfficialRoomsPacketParser : IIncomingPacketParser<GetOfficialRoomsPacketParser.GetOfficialRoomsIncomingPacket>
{
	public GetOfficialRoomsIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetOfficialRoomsIncomingPacket
		{
			NodeMask = (int)reader.ReadVL64UInt32(),
			NodeId = (int)reader.ReadVL64UInt32(),
			Depth = (int)reader.ReadVL64UInt32()
		};
	}

	internal readonly struct GetOfficialRoomsIncomingPacket : IGetOfficialRoomsIncomingPacket
	{
		public int NodeMask { get; init; }
		public int NodeId { get; init; }
		public int Depth { get; init; }
	}
}
