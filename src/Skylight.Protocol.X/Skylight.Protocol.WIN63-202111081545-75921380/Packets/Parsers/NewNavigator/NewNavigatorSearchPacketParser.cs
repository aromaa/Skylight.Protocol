using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.NewNavigator;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.NewNavigator;

[PacketParserId(1693u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class NewNavigatorSearchPacketParser : IIncomingPacketParser<NewNavigatorSearchPacketParser.NewNavigatorSearchIncomingPacket>
{
	public NewNavigatorSearchIncomingPacket Parse(ref PacketReader reader)
	{
		return new NewNavigatorSearchIncomingPacket
		{
			SearchCode = reader.ReadBytes(reader.ReadInt16()),
			Filtering = reader.ReadBytes(reader.ReadInt16())
		};
	}

	internal readonly struct NewNavigatorSearchIncomingPacket : INewNavigatorSearchIncomingPacket
	{
		public ReadOnlySequence<byte> SearchCode { get; init; }
		public ReadOnlySequence<byte> Filtering { get; init; }
	}
}
