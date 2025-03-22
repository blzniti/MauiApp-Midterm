using MauiAppMidterm.ViewModel;

namespace MauiAppMidterm.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

	private async void ForgetPasswordTapped(object sender, EventArgs e)
	{
		Console.WriteLine($"Email: {email.Text}, Password: {pwd.Text}");
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		if (email.Text == "65011212178@msu.ac.th" && pwd.Text == "1234")
		{
			await Navigation.PushAsync(new HomePage());
		}
		else
		{
			await DisplayAlert("Incorrect", "Email or Password incorrect", "Close");
		}
	}
}