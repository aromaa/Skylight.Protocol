namespace Skylight.Protocol.Client.Variables.Rules.Dependencies.Conditions;

public sealed class ClientVariableDependencyRuleActiveValueSetCondition : ClientVariableDependencyRuleCondition
{
	public string ValueSet { get; set; } = string.Empty;
}
