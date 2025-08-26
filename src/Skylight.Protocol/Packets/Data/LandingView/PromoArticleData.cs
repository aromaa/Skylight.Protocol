using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.LandingView;

public sealed class PromoArticleData
{
	public required int Id { get; init; }

	public required string Title { get; init; }

	public required string BodyText { get; init; }

	public required string ButtonText { get; init; }

	public required int LinkType { get; init; }

	public required string LinkContent { get; init; }

	public required string ImageUrl { get; init; }

	public PromoArticleData()
	{
	}

	[SetsRequiredMembers]
	public PromoArticleData(int id, string title, string bodyText, string buttonText, int linkType, string linkContent, string imageUrl)
	{
		this.Id = id;
		this.Title = title;
		this.BodyText = bodyText;
		this.ButtonText = buttonText;
		this.LinkType = linkType;
		this.LinkContent = linkContent;
		this.ImageUrl = imageUrl;
	}
}
