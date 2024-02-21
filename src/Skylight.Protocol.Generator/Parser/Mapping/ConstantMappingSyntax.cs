namespace Skylight.Protocol.Generator.Parser.Mapping;

internal sealed class ConstantMappingSyntax(object value, AbstractMappingSyntax type) : AbstractMappingSyntax
{
	public object Value { get; } = value;
	public AbstractMappingSyntax Type { get; } = type;
}
