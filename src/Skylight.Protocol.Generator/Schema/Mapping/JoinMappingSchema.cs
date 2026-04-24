namespace Skylight.Protocol.Generator.Schema.Mapping;

public sealed class JoinMappingSchema : AbstractMappingSchema
{
	public required object Delimiter { get; set; }
	public required string Type { get; set; }

	public required List<AbstractMappingSchema> Fields { get; set; }
}
