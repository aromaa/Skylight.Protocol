namespace Skylight.Protocol.Generator.Schema.Mapping;

internal sealed class ConditionalMappingSchema : AbstractMappingSchema
{
	public required string Condition { get; init; }

	public required AbstractMappingSchema WhenTrue { get; init; }
}
