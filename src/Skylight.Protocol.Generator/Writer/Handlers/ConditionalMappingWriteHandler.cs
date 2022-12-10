using System.Buffers;
using System.CodeDom.Compiler;
using System.Reflection;
using Skylight.Protocol.Generator.Parser.Mapping;
using Skylight.Protocol.Generator.Structure;

namespace Skylight.Protocol.Generator.Writer.Handlers;

internal sealed class ConditionalMappingWriteHandler : MappingWriterHandler
{
	internal override void Read(ref WriterContext context, ProtocolStructure protocol, IndentedTextWriter writer, AbstractMappingSyntax mapping, MemberInfo type)
	{
		if (mapping is not ConditionalMappingSyntax conditionalMapping)
		{
			throw new NotSupportedException();
		}

		if (conditionalMapping.Condition == "Readable")
		{
			writer.Write($"reader.Readable ? ");

			context.Read(protocol, writer, conditionalMapping.WhenTrue, type);

			if (type is PropertyInfo propertyInfo)
			{
				type = propertyInfo.PropertyType;
			}

			if (type == typeof(ReadOnlySequence<byte>))
			{
				writer.Write($" : ReadOnlySequence<byte>.Empty");
			}
			else
			{
				throw new NotSupportedException();
			}
		}
		else
		{
			throw new NotSupportedException();
		}
	}

	internal override void Write(ref WriterContext context, ProtocolStructure protocol, IndentedTextWriter writer, AbstractMappingSyntax mapping, MemberInfo type)
	{
		if (mapping is not ConditionalMappingSyntax conditionalMapping)
		{
			throw new NotSupportedException();
		}

		writer.WriteLine($"if ({context.Name}.{conditionalMapping.Condition})");
		writer.WriteLine($"{{");
		writer.Indent++;

		context.Write(protocol, writer, conditionalMapping.WhenTrue, type);

		writer.Indent--;
		writer.WriteLine($"}}");
	}
}
