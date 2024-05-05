using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Registration;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE9.Packets.Parsers.Registration;

[PacketParserId(9u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetAvailableSetsPacketParser : IIncomingPacketParser<GetAvailableSetsPacketParser.GetAvailableSetsIncomingPacket>
{
	public GetAvailableSetsIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetAvailableSetsIncomingPacket();
	}

	internal readonly struct GetAvailableSetsIncomingPacket : IGetAvailableSetsIncomingPacket
	{
	}
}
