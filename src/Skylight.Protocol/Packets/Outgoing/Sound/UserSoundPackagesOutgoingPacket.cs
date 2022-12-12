using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Sound;

public sealed class UserSoundPackagesOutgoingPacket : IGameOutgoingPacket
{
	public required ICollection<int> SoundSets { get; init; }

	public UserSoundPackagesOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public UserSoundPackagesOutgoingPacket(ICollection<int> soundSets)
	{
		this.SoundSets = soundSets;
	}
}
