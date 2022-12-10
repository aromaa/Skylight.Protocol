using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Room.Chat;

public sealed class ChatOutgoingPacket : IGameOutgoingPacket
{
	public required int UserId { get; init; }

	public required string Text { get; init; }

	public required int Gesture { get; init; }
	public required int StyleId { get; init; }
	public required int TrackingId { get; init; }

	public required ICollection<(string Location, string Text, bool Trusted)> Links { get; init; }

	public ChatOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public ChatOutgoingPacket(int userId, string text, int gesture, int styleId, int trackingId, ICollection<(string Location, string Text, bool Trusted)> links)
	{
		this.UserId = userId;

		this.Text = text;

		this.Gesture = gesture;
		this.StyleId = styleId;
		this.TrackingId = trackingId;

		this.Links = links;
	}
}
