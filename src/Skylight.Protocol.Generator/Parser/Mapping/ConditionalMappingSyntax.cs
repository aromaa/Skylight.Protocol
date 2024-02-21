namespace Skylight.Protocol.Generator.Parser.Mapping;

internal sealed class ConditionalMappingSyntax(string condition, AbstractMappingSyntax whenTrue) : AbstractMappingSyntax
{
	public string Condition { get; } = condition;

	public AbstractMappingSyntax WhenTrue { get; } = whenTrue;
}
