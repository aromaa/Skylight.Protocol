using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Users;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Users;

[PacketParserId(3346u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetIgnoredUsersPacketParser : IIncomingPacketParser<GetIgnoredUsersPacketParser.GetIgnoredUsersIncomingPacket>
{
	public GetIgnoredUsersIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetIgnoredUsersIncomingPacket
		{
			Username = reader.ReadBytes(reader.ReadInt16())
		};
	}

	internal readonly struct GetIgnoredUsersIncomingPacket : IGetIgnoredUsersIncomingPacket
	{
		public ReadOnlySequence<byte> Username { get; init; }
	}
}
