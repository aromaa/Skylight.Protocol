using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Users;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Parsers.Users;

[PacketParserId(2757u)]
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
