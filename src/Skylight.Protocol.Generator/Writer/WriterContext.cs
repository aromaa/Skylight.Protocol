using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using Skylight.Protocol.Generator.Parser.Mapping;
using Skylight.Protocol.Generator.Structure;
using Skylight.Protocol.Generator.Writer.Handlers;

namespace Skylight.Protocol.Generator.Writer;

internal struct WriterContext(PacketStructure packet, Dictionary<Type, MappingWriterHandler> handlers)
{
	private readonly Dictionary<Type, MappingWriterHandler> handlers = handlers;

	public PacketStructure Packet { get; } = packet;

	public string Name { get; private set; } = string.Empty;
	public TargetData Target { get; private set; } = new TargetData(string.Empty, typeof(object));

	public void Read(ProtocolStructure protocol, IndentedTextWriter writer, AbstractMappingSyntax mapping, MemberInfo type)
	{
		this.handlers[mapping.GetType()].Read(ref this, protocol, writer, mapping, type);
	}

	public void ReadPost(ProtocolStructure protocol, IndentedTextWriter writer, AbstractMappingSyntax mapping, MemberInfo type)
	{
		this.handlers[mapping.GetType()].ReadPost(ref this, protocol, writer, mapping, type);
	}

	public void Write(ProtocolStructure protocol, IndentedTextWriter writer, string? method, AbstractMappingSyntax mapping, MemberInfo type)
	{
		this.handlers[mapping.GetType()].Write(ref this, protocol, writer, method, mapping, type);
	}

	[UnscopedRef]
	public Scope PushScope(string? name, bool overrideName = false, TargetData? target = null)
	{
		string oldName = this.Name;
		TargetData oldTarget = this.Target;

		if (name is not null)
		{
			if (this.Name.Length == 0 || overrideName)
			{
				this.Name = name;
			}
			else
			{
				this.Name = $"{this.Name}.{name}";
			}
		}

		if (target is not null)
		{
			this.Target = target;
		}

		return new Scope(ref this, oldName, oldTarget);
	}

	private void ExitScope(string name, TargetData target)
	{
		this.Name = name;
		this.Target = target;
	}

	internal class TargetData(string name, Type type)
	{
		public string Name { get; } = name;
		public Type Type { get; } = type;
	}

	internal ref struct Scope
	{
		internal ref WriterContext context;

		internal string name;
		internal TargetData target;

		internal Scope(ref WriterContext context, string name, TargetData target)
		{
			this.context = ref context;

			this.name = name;
			this.target = target;
		}

		public void Dispose()
		{
			if (Unsafe.IsNullRef(ref this.context))
			{
				return;
			}

			this.context.ExitScope(this.name, this.target);
			this.context = ref Unsafe.NullRef<WriterContext>();
		}
	}
}
