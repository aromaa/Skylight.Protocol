namespace Skylight.Protocol.Editor.Maui;

public sealed partial class App : Application
{
	public App()
	{
		this.InitializeComponent();
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(new MainPage())
		{
			Title = "Skylight.Protocol.Editor"
		};
	}
}
