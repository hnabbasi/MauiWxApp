using MauiWxApp.Services;
using MauiWxApp.ViewModels;
using MauiWxApp.Views;

namespace MauiWxApp;

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
				})
			.RegisterViews()
			.RegisterViewModels()
			.RegisterServices();

		return builder.Build();
	}

	static MauiAppBuilder RegisterViews(this MauiAppBuilder builder)
	{
		builder.Services.AddSingleton<MainPage>();
		return builder;
	}
	static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder)
	{
		builder.Services.AddSingleton<BaseViewModel>();
		builder.Services.AddSingleton<MainPageViewModel>();
		return builder;
	}
	static MauiAppBuilder RegisterServices(this MauiAppBuilder builder)
	{
		builder.Services.AddTransient<IAlertService, AlertService>();
		return builder;
	}
}

