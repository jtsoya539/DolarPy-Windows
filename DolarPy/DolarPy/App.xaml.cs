namespace DolarPy;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		// Uncomment the following as a quick way to test loading resources for different languages
		// CultureInfo.CurrentCulture = CultureInfo.CurrentUICulture = new CultureInfo("es");
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(new AppShell());
	}
}
