using Skylight.Protocol.Client.Variables.Rules;

namespace Skylight.Protocol.Client.Variables.Keys;

public sealed class ClientVariableKey
{
	public string Name { get; set; } = string.Empty;
	public string Description { get; set; } = string.Empty;

	public string Type { get; set; } = "string";

	public OrderedDictionary<string, ClientVariableRuleSet> RuleSets { get; set; } = [];
}
