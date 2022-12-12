using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Sound;

public sealed class SongInfoOutgoingPacket : IGameOutgoingPacket
{
	public required int Id { get; init; }
	public required string Name { get; init; }

	public required string Data { get; init; }

	public SongInfoOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public SongInfoOutgoingPacket(int id, string name, string data)
	{
		this.Id = id;
		this.Name = name;
		this.Data = data;
	}
}
