using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.Room.Engine;

public sealed class RoomUnitUpdateData
{
	public required int RoomUnitId { get; init; }
	public required string Username { get; init; }

	public required int X { get; init; }
	public required int Y { get; init; }
	public required double Z { get; init; }

	public required int BodyDirection { get; init; }
	public required int HeadDirection { get; init; }

	public required string Data { get; init; }

	public RoomUnitUpdateData()
	{
	}

	[SetsRequiredMembers]
	public RoomUnitUpdateData(int roomUnitId, string username, int x, int y, double z, int bodyDirection, int headDirection, string data)
	{
		this.RoomUnitId = roomUnitId;
		this.Username = username;

		this.X = x;
		this.Y = y;
		this.Z = z;

		this.BodyDirection = bodyDirection;
		this.HeadDirection = headDirection;

		this.Data = data;
	}
}
