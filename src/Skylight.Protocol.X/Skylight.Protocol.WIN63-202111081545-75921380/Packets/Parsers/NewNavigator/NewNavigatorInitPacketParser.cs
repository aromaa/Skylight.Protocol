using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.NewNavigator;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.NewNavigator;

[PacketParserId(2283u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class NewNavigatorInitPacketParser : IIncomingPacketParser<NewNavigatorInitPacketParser.NewNavigatorInitIncomingPacket>
{
	public NewNavigatorInitIncomingPacket Parse(ref PacketReader reader)
	{
		return new NewNavigatorInitIncomingPacket();
	}

	internal readonly struct NewNavigatorInitIncomingPacket : INewNavigatorInitIncomingPacket
	{
	}
}
