using MauiWxApp.Views;

namespace MauiWxApp;

public partial class App : Application
{
	public App(MainPage mainPage)
	{
		InitializeComponent();
		MainPage = mainPage;
	}
}