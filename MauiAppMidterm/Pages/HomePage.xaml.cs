namespace MauiAppMidterm.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		Console.WriteLine("Email: beeeee");
		await Navigation.PopAsync();
	}
}