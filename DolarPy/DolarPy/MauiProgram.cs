namespace DolarPy;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureSyncfusionToolkit()
			.UseMauiCommunityToolkit()
			.UseSkiaSharp()
#if ANDROID || IOS
			.UseMauiMaps()
#elif WINDOWS
			// Add your API key here.
			// See also https://github.com/CommunityToolkit/Maui/discussions/2123
			.UseMauiCommunityToolkitMaps("YOUR_API_KEY")
#endif
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("MaterialIcons-Regular.ttf", "MaterialSymbol");
				fonts.AddFont("FontAwesome6FreeBrands.otf", "FontAwesomeBrands");
				fonts.AddFont("FontAwesome6FreeRegular.otf", "FontAwesomeRegular");
				fonts.AddFont("FontAwesome6FreeSolid.otf", "FontAwesomeSolid");
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
#if DEBUG
		builder.Logging.AddDebug();
#endif
		builder.Services.AddSingleton<MainViewModel>();

		builder.Services.AddSingleton<MainPage>();

		builder.Services.AddTransient<SampleDataService>();
		builder.Services.AddTransient<ListDetailDetailViewModel>();
		builder.Services.AddTransient<ListDetailDetailPage>();

		builder.Services.AddSingleton<ListDetailViewModel>();

		builder.Services.AddSingleton<ListDetailPage>();

		builder.Services.AddSingleton<SampleViewModel>();

		builder.Services.AddSingleton<SamplePage>();

		builder.Services.AddSingleton<MapViewModel>();

		builder.Services.AddSingleton<MapPage>();

		builder.Services.AddSingleton<LocalizationViewModel>();

		builder.Services.AddSingleton<LocalizationPage>();

		builder.Services.AddSingleton<ExampleFontAwesomeUsageViewModel>();

		builder.Services.AddSingleton<ExampleFontAwesomeUsagePage>();

		builder.Services.AddSingleton<ExampleMaterialFontUsageViewModel>();

		builder.Services.AddSingleton<ExampleMaterialFontUsagePage>();

		builder.Services.AddSingleton<LottieViewModel>();

		builder.Services.AddSingleton<LottiePage>();

		return builder.Build();
	}
}
