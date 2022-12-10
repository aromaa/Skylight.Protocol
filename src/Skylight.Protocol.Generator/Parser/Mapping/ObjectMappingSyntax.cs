namespace Skylight.Protocol.Generator.Parser.Mapping;

internal sealed class ObjectMappingSyntax : AbstractMappingSyntax
{
	public string Name { get; }

	internal ObjectMappingSyntax(string name)
	{
		this.Name = name;
	}
}
