using System.CodeDom.Compiler;
using System.Reflection;
using Skylight.Protocol.Generator.Parser.Mapping;
using Skylight.Protocol.Generator.Structure;

namespace Skylight.Protocol.Generator.Writer.Handlers;

internal sealed class ConstantMappingWriteHandler : MappingWriterHandler
{
	internal override void Read(ref WriterContext context, ProtocolStructure protocol, IndentedTextWriter writer, AbstractMappingSyntax mapping, MemberInfo type)
	{
		throw new NotImplementedException();
	}

	internal override void Write(ref WriterContext context, ProtocolStructure protocol, IndentedTextWriter writer, AbstractMappingSyntax mapping, MemberInfo type)
	{
		if (mapping is not ConstantMappingSyntax constantMapping)
		{
			throw new NotSupportedException();
		}

		if (constantMapping.Value is bool boolean)
		{
			using (context.PushScope(boolean ? "true" : "false", true))
			{
				context.Write(protocol, writer, constantMapping.Type, constantMapping.Value.GetType());
			}
		}
		else
		{
			using (context.PushScope(constantMapping.Value.ToString(), true))
			{
				context.Write(protocol, writer, constantMapping.Type, constantMapping.Value.GetType());
			}
		}
	}
}
