namespace MauiAppMidterm.Pages;

using MauiAppMidterm.ViewModel;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}

	private async void Button_Go_Enroll(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new EnrollPage());
	}

	private async void Button_Go_History(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new HistoryPage());
	}

	private async void Button_Go_Profile(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new ProfilePage());
	}
}