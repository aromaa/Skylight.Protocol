namespace Skylight.Protocol.Client.Variables.Rules.Expressions;

public sealed class ClientVariableRuleNotExpression : ClientVariableRuleExpression
{
	public required ClientVariableRuleExpression Expression { get; set; }
}
