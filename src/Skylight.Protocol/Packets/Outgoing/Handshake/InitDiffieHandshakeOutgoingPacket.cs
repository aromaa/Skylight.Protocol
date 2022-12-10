using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Handshake;

public sealed class InitDiffieHandshakeOutgoingPacket : IGameOutgoingPacket
{
	public required string EncryptedPrime { get; init; }

	public InitDiffieHandshakeOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public InitDiffieHandshakeOutgoingPacket(string encryptedPrime)
	{
		this.EncryptedPrime = encryptedPrime;
	}
}
