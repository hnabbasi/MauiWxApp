using MauiWxApp.Services;
using MauiWxApp.ViewModels;

namespace MauiWxApp.Views;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageViewModel viewModel)
	{
		BindingContext = viewModel;
		InitializeComponent();
	}
}


