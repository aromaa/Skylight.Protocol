namespace Skylight.Protocol.Client.Variables.Rules.Dependencies.Conditions;

public sealed class ClientVariableDependencyRuleValueEqualsCondition : ClientVariableDependencyRuleCondition
{
	public string Value { get; set; } = string.Empty;
}
