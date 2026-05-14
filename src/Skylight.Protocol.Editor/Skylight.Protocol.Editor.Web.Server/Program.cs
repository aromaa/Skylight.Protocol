using Skylight.Protocol.Editor.Web.Server.Components;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
	.AddInteractiveWebAssemblyComponents();

WebApplication app = builder.Build();
if (app.Environment.IsDevelopment())
{
	app.UseWebAssemblyDebugging();
}
else
{
	app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);

app.MapStaticAssets();

app.MapRazorComponents<App>()
	.DisableAntiforgery()
	.AddInteractiveWebAssemblyRenderMode()
	.AddAdditionalAssemblies(
		typeof(Skylight.Protocol.Editor.Web._Imports).Assembly,
		typeof(Skylight.Protocol.Editor.Web.Client._Imports).Assembly);

await app.RunAsync().ConfigureAwait(false);
