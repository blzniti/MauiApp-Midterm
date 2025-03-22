using MauiAppMidterm.ViewModel;

namespace MauiAppMidterm.Pages;

public partial class HistoryPage : ContentPage
{
	public HistoryPage()
	{
		InitializeComponent();
		BindingContext = new HistoryViewModel();
	}
}