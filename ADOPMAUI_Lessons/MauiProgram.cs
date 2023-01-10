using ADOPMAUI_Lessons.Services;

namespace ADOPMAUI_Lessons;

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
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});


            DependencyService.RegisterSingleton<IPrimeNumberService>(new PrimeNumberService());

		return builder.Build();
	}
}
