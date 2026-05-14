using Skylight.Protocol.Client.Variables.Rules.Dependencies.Conditions;

namespace Skylight.Protocol.Client.Variables.Rules.Dependencies;

public sealed class ClientVariableDependencyRule : ClientVariableRule
{
	public string Variable { get; set; } = string.Empty;

	public ClientVariableDependencyRuleCondition? Condition { get; set; }
}
