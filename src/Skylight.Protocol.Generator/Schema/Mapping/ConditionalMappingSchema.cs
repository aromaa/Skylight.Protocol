namespace Skylight.Protocol.Generator.Schema.Mapping;

public sealed class ConditionalMappingSchema : AbstractMappingSchema
{
	public required string Condition { get; set; }

	public required AbstractMappingSchema WhenTrue { get; set; }
}
