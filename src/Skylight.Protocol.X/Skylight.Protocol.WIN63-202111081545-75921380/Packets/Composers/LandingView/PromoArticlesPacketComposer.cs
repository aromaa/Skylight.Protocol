using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.LandingView;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.LandingView;

[PacketComposerId(2333u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class PromoArticlesPacketComposer : IOutgoingPacketComposer<PromoArticlesOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in PromoArticlesOutgoingPacket packet)
	{
		writer.WriteInt32(packet.Articles.Count);
		foreach (var articles in packet.Articles)
		{
			writer.WriteInt32(articles.Id);
			writer.WriteFixedUInt16String(articles.Title);
			writer.WriteFixedUInt16String(articles.BodyText);
			writer.WriteFixedUInt16String(articles.ButtonText);
			writer.WriteInt32(articles.LinkType);
			writer.WriteFixedUInt16String(articles.LinkContent);
			writer.WriteFixedUInt16String(articles.ImageUrl);
		}
	}
}
