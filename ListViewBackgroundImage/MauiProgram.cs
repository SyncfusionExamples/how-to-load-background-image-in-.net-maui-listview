using Syncfusion.Maui.Core.Hosting;

namespace ListViewBackgroundImage;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("Roboto-Regular.ttf", "Roboto");
				fonts.AddFont("Roboto-Medium.ttf", "RobotoMedium");
			});
		builder.ConfigureSyncfusionCore();
		return builder.Build();
	}
}
