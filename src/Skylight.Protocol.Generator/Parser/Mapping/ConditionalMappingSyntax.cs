namespace Skylight.Protocol.Generator.Parser.Mapping;

internal sealed class ConditionalMappingSyntax : AbstractMappingSyntax
{
	public string Condition { get; }

	public AbstractMappingSyntax WhenTrue { get; }

	public ConditionalMappingSyntax(string condition, AbstractMappingSyntax whenTrue)
	{
		this.Condition = condition;

		this.WhenTrue = whenTrue;
	}
}
