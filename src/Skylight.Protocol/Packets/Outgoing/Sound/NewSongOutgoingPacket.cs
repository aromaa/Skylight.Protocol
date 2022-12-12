using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Sound;

public sealed class NewSongOutgoingPacket : IGameOutgoingPacket
{
	public required int Id { get; init; }
	public required string Name { get; init; }

	public NewSongOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public NewSongOutgoingPacket(int id, string name)
	{
		this.Id = id;
		this.Name = name;
	}
}
