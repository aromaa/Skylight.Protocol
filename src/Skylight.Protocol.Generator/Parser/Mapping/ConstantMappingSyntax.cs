namespace Skylight.Protocol.Generator.Parser.Mapping;

internal sealed class ConstantMappingSyntax : AbstractMappingSyntax
{
	public object Value { get; }
	public AbstractMappingSyntax Type { get; }

	public ConstantMappingSyntax(object value, AbstractMappingSyntax type)
	{
		this.Value = value;
		this.Type = type;
	}
}
