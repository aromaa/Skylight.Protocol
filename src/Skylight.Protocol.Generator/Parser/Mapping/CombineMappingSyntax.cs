namespace Skylight.Protocol.Generator.Parser.Mapping;

internal sealed class CombineMappingSyntax : AbstractMappingSyntax
{
	internal AbstractMappingSyntax Type { get; }

	internal List<AbstractMappingSyntax> Fields { get; }

	internal CombineMappingSyntax(AbstractMappingSyntax type, List<AbstractMappingSyntax> fields)
	{
		this.Type = type;

		this.Fields = fields;
	}
}
