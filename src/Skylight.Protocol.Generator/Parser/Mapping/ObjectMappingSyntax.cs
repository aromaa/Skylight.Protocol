namespace Skylight.Protocol.Generator.Parser.Mapping;

internal sealed class ObjectMappingSyntax : AbstractMappingSyntax
{
	public string Type { get; }
	public string? Name { get; }

	internal ObjectMappingSyntax(string type, string? name = default)
	{
		this.Type = type;
		this.Name = name;
	}
}
