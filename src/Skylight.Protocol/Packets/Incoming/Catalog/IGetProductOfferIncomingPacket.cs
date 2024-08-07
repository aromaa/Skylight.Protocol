namespace Skylight.Protocol.Packets.Incoming.Catalog;

public interface IGetProductOfferIncomingPacket : IGameIncomingPacket
{
	public int OfferId { get; }
}
