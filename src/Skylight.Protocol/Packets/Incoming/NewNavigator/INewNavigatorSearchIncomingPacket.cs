using System.Buffers;
using Skylight.Protocol.Attributes;

namespace Skylight.Protocol.Packets.Incoming.NewNavigator;

[IntroducedIn("WIN63-202111081545-75921380")]
public interface INewNavigatorSearchIncomingPacket : IGameIncomingPacket
{
	public ReadOnlySequence<byte> SearchCode { get; }
	public ReadOnlySequence<byte> Filtering { get; }
}
