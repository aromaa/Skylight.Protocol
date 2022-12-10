using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.Perk;

public sealed class PerkAllowanceData
{
	public required string Code { get; init; }
	public required string ErrorMessage { get; init; }

	public required bool IsAllowed { get; init; }

	public PerkAllowanceData()
	{
	}

	[SetsRequiredMembers]
	public PerkAllowanceData(string code, string errorMessage, bool isAllowed)
	{
		this.Code = code;

		this.ErrorMessage = errorMessage;
		this.IsAllowed = isAllowed;
	}
}
