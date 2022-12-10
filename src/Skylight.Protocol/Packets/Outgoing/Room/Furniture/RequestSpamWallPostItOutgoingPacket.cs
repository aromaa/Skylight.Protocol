using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Room.Object.Data.Wall;

namespace Skylight.Protocol.Packets.Outgoing.Room.Furniture;

public sealed class RequestSpamWallPostItOutgoingPacket : IGameOutgoingPacket
{
	public required int Id { get; init; }
	public required WallPosition Location { get; init; }

	public RequestSpamWallPostItOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public RequestSpamWallPostItOutgoingPacket(int id, WallPosition location)
	{
		this.Id = id;
		this.Location = location;
	}
}
