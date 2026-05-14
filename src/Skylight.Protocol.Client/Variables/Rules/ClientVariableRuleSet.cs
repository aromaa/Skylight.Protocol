namespace Skylight.Protocol.Client.Variables.Rules;

public sealed class ClientVariableRuleSet
{
	public OrderedDictionary<string, ClientVariableRule> Rules { get; set; } = [];
}
