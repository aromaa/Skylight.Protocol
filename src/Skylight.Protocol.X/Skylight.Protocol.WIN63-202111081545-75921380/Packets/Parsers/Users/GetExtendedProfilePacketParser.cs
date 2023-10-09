using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Users;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Users;

[PacketParserId(792u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetExtendedProfilePacketParser : IIncomingPacketParser<GetExtendedProfilePacketParser.GetExtendedProfileIncomingPacket>
{
	public GetExtendedProfileIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetExtendedProfileIncomingPacket
		{
			UserId = reader.ReadInt32(),
			Open = reader.ReadBool()
		};
	}

	internal readonly struct GetExtendedProfileIncomingPacket : IGetExtendedProfileIncomingPacket
	{
		public int UserId { get; init; }
		public bool Open { get; init; }
	}
}
