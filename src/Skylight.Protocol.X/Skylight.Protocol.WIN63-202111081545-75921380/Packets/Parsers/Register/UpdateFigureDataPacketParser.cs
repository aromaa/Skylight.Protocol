using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Register;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Register;

[PacketParserId(3225u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class UpdateFigureDataPacketParser : IIncomingPacketParser<UpdateFigureDataPacketParser.UpdateFigureDataIncomingPacket>
{
	public UpdateFigureDataIncomingPacket Parse(ref PacketReader reader)
	{
		return new UpdateFigureDataIncomingPacket
		{
			Gender = reader.ReadBytes(reader.ReadInt16()),
			Figure = reader.ReadBytes(reader.ReadInt16())
		};
	}

	internal readonly struct UpdateFigureDataIncomingPacket : IUpdateFigureDataIncomingPacket
	{
		public ReadOnlySequence<byte> Gender { get; init; }
		public ReadOnlySequence<byte> Figure { get; init; }
	}
}
