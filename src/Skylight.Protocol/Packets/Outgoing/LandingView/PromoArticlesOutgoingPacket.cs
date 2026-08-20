using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.LandingView;

namespace Skylight.Protocol.Packets.Outgoing.LandingView;

public sealed class PromoArticlesOutgoingPacket : IGameOutgoingPacket
{
	public required ICollection<PromoArticleData> Articles { get; init; }

	public PromoArticlesOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public PromoArticlesOutgoingPacket(ICollection<PromoArticleData> articles)
	{
		this.Articles = articles;
	}
}
