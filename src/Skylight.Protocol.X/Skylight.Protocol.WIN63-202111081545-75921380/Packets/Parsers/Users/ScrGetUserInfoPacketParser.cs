using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Users;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Users;

[PacketParserId(1914u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class ScrGetUserInfoPacketParser : IIncomingPacketParser<ScrGetUserInfoPacketParser.ScrGetUserInfoIncomingPacket>
{
	public ScrGetUserInfoIncomingPacket Parse(ref PacketReader reader)
	{
		return new ScrGetUserInfoIncomingPacket
		{
			ProductName = reader.ReadBytes(reader.ReadInt16())
		};
	}

	internal readonly struct ScrGetUserInfoIncomingPacket : IScrGetUserInfoIncomingPacket
	{
		public ReadOnlySequence<byte> ProductName { get; init; }
	}
}
