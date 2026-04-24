namespace Skylight.Protocol.Generator.Parser.Mapping;

internal sealed class JoinMappingSyntax : AbstractMappingSyntax
{
	internal AbstractMappingSyntax Type { get; }
	internal object Delimiter { get; }

	internal List<AbstractMappingSyntax> Fields { get; }

	internal JoinMappingSyntax(AbstractMappingSyntax type, object delimiter, List<AbstractMappingSyntax> fields)
	{
		this.Type = type;
		this.Delimiter = delimiter;
		this.Fields = fields;
	}
}
