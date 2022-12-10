using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Attributes;

namespace Skylight.Protocol.Packets.Outgoing.Advertisement;

[RemovedOn("WIN63-202111081545-75921380")]
public sealed class RoomAdOutgoingPacket : IGameOutgoingPacket
{
	public required string ImageUrl { get; init; }
	public required string ClickUrl { get; init; }

	public RoomAdOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public RoomAdOutgoingPacket(string imageUrl, string clickUrl)
	{
		this.ImageUrl = imageUrl;
		this.ClickUrl = clickUrl;
	}
}
