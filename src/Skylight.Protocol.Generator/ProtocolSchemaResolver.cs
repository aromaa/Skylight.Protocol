using System.Text.Json;
using Skylight.Protocol.Generator.Schema;
using Skylight.Protocol.Generator.Schema.Mapping;

namespace Skylight.Protocol.Generator;

public sealed class ProtocolSchemaResolver(bool reformat = false)
{
	private readonly bool reformat = reformat;

	private readonly Dictionary<string, ProtocolSchema> revisions = [];
	private readonly Dictionary<string, HashSet<ProtocolSchema>> dependencies = [];

	private readonly HashSet<ProtocolSchema> roots = [];

	public async Task LoadAllAsync(string directory)
	{
		await Parallel.ForEachAsync(Directory.EnumerateDirectories(directory, "*", new EnumerationOptions()), this.LoadAsync).ConfigureAwait(false);

		Queue<ProtocolSchema> schemasToProcess = new(this.roots);
		while (schemasToProcess.TryDequeue(out ProtocolSchema? dependencySchema))
		{
			if (this.dependencies.TryGetValue(dependencySchema.Revision, out HashSet<ProtocolSchema>? dependencies))
			{
				foreach (ProtocolSchema schema in dependencies)
				{
					schemasToProcess.Enqueue(schema);

					foreach ((string key, PacketSchema packet) in dependencySchema.Incoming)
					{
						schema.Incoming.TryAdd(key, packet);
					}

					foreach ((string key, PacketSchema packet) in dependencySchema.Outgoing)
					{
						schema.Outgoing.TryAdd(key, packet);
					}

					foreach ((string key, List<AbstractMappingSchema> structure) in dependencySchema.Structures)
					{
						schema.Structures.TryAdd(key, structure);
					}

					foreach ((string key, SortedDictionary<string, string> @interface) in dependencySchema.Interfaces)
					{
						schema.Interfaces.TryAdd(key, @interface);
					}
				}
			}
		}
	}

	private async ValueTask LoadAsync(string directory, CancellationToken cancellationToken)
	{
		string packetsPath = Path.Combine(directory, "packets.json");

		ProtocolSchema schema;
		await using (Stream stream = File.OpenRead(packetsPath))
		{
			schema = await JsonSerializer.DeserializeAsync<ProtocolSchema>(stream, ProtocolGenerator.JsonSerializerOptions, cancellationToken).ConfigureAwait(false) ?? throw new FileNotFoundException(packetsPath);
		}

		lock (this.revisions)
		{
			this.revisions[schema.Revision] = schema;
		}

		if (schema.Inherit is null)
		{
			lock (this.roots)
			{
				this.roots.Add(schema);
			}
		}
		else
		{
			if (!this.dependencies.TryGetValue(schema.Inherit, out HashSet<ProtocolSchema>? dependencies))
			{
				this.dependencies[schema.Inherit] = dependencies = [];
			}

			dependencies.Add(schema);
		}

		if (this.reformat)
		{
			string packetsTempPath = Path.Combine(directory, "packets.json.temp");

			await using (Stream stream = File.OpenWrite(packetsTempPath))
			{
				await JsonSerializer.SerializeAsync(stream, schema, ProtocolGenerator.JsonSerializerOptions, cancellationToken).ConfigureAwait(false);
			}

			File.Move(packetsTempPath, packetsPath, true);
		}
	}

	public ProtocolSchema GetSchema(string revision)
	{
		return this.revisions[revision];
	}
}
