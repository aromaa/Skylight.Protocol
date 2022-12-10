using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using Skylight.Protocol.Generator.Parser.Mapping;
using Skylight.Protocol.Generator.Structure;
using Skylight.Protocol.Generator.Writer.Handlers;

namespace Skylight.Protocol.Generator.Writer;

internal struct WriterContext
{
	private readonly Dictionary<Type, MappingWriterHandler> handlers;

	public string Name { get; private set; }

	public WriterContext(Dictionary<Type, MappingWriterHandler> handlers)
	{
		this.handlers = handlers;

		this.Name = string.Empty;
	}

	public void Read(ProtocolStructure protocol, IndentedTextWriter writer, AbstractMappingSyntax mapping, MemberInfo type)
	{
		this.handlers[mapping.GetType()].Read(ref this, protocol, writer, mapping, type);
	}

	public void ReadPost(ProtocolStructure protocol, IndentedTextWriter writer, AbstractMappingSyntax mapping, MemberInfo type)
	{
		this.handlers[mapping.GetType()].ReadPost(ref this, protocol, writer, mapping, type);
	}

	public void Write(ProtocolStructure protocol, IndentedTextWriter writer, AbstractMappingSyntax mapping, MemberInfo type)
	{
		this.handlers[mapping.GetType()].Write(ref this, protocol, writer, mapping, type);
	}

	[UnscopedRef]
	public Scope PushScope(string? name, bool overrideName = false)
	{
		if (name is null)
		{
			return default;
		}

		string oldName = this.Name;

		if (this.Name.Length == 0 || overrideName)
		{
			this.Name = name;
		}
		else
		{
			this.Name = $"{this.Name}.{name}";
		}

		return new Scope(ref this, oldName);
	}

	private void ExitScope(string name)
	{
		this.Name = name;
	}

	internal ref struct Scope
	{
		internal ref WriterContext context;

		internal string name;

		internal Scope(ref WriterContext context, string name)
		{
			this.context = ref context;

			this.name = name;
		}

		public void Dispose()
		{
			if (Unsafe.IsNullRef(ref this.context))
			{
				return;
			}

			this.context.ExitScope(this.name);
			this.context = ref Unsafe.NullRef<WriterContext>();
		}
	}
}
