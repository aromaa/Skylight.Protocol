using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Handshake;

public sealed class UserObjectOutgoingPacket : IGameOutgoingPacket
{
	public required int UserId { get; init; }

	public required string Username { get; init; }
	public required string RealName { get; init; }

	public required string Figure { get; init; }
	public required string Gender { get; init; }
	public required string SwimSuit { get; init; }

	public required string CustomData { get; init; }

	public required int Tickets { get; init; }
	public required int Film { get; init; }
	public required int RespectTotal { get; init; }
	public required int RespectLeft { get; init; }
	public required int PerRespectLeft { get; init; }

	public required DateTimeOffset LastAccessDate { get; init; }

	public required bool DirectMail { get; init; }
	public required bool StreamPublishingAllowed { get; init; }
	public required bool NameChangeAllowed { get; init; }
	public required bool AccountSafetyLocked { get; init; }

	public UserObjectOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public UserObjectOutgoingPacket(int userId, string username, string realName, string figure, string gender, string swimSuit, string customData, int tickets, int film, int respectTotal, int respectLeft, int perRespectLeft, DateTimeOffset lastAccessDate, bool directMail, bool streamPublishingAllowed, bool nameChangeAllowed, bool accountSafetyLocked)
	{
		this.UserId = userId;

		this.Username = username;
		this.RealName = realName;

		this.Figure = figure;
		this.Gender = gender;
		this.SwimSuit = swimSuit;

		this.CustomData = customData;

		this.Tickets = tickets;
		this.Film = film;
		this.RespectTotal = respectTotal;
		this.RespectLeft = respectLeft;
		this.PerRespectLeft = perRespectLeft;

		this.LastAccessDate = lastAccessDate;

		this.DirectMail = directMail;
		this.StreamPublishingAllowed = streamPublishingAllowed;
		this.NameChangeAllowed = nameChangeAllowed;
		this.AccountSafetyLocked = accountSafetyLocked;
	}
}
