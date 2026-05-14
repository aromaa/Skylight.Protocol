using Foundation;

namespace Skylight.Protocol.Editor.Maui.Platforms.MacCatalyst;

[Register("AppDelegate")]
public sealed class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
