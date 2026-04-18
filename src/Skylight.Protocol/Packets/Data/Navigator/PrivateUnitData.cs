using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.Navigator;

public sealed class PrivateUnitData
{
	public required string IP { get; init; }
	public required int Port { get; init; }

	public PrivateUnitData()
	{
	}

	[SetsRequiredMembers]
	public PrivateUnitData(string ip, int port)
	{
		this.IP = ip;
		this.Port = port;
	}
}
