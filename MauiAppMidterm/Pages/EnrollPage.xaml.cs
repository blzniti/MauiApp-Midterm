using MauiAppMidterm.ViewModel;

namespace MauiAppMidterm.Pages;

public partial class EnrollPage : ContentPage
{
	public EnrollPage()
	{
		InitializeComponent();
		BindingContext = new EnrollViewModel();
	}

	private async void OnSubjectSelected(object sender, SelectedItemChangedEventArgs e)
	{
		// ตรวจสอบว่ามีรายวิชาที่ถูกเลือกหรือไม่
		if (e.SelectedItem == null)
			return;

		// ดึงรายวิชาที่ถูกเลือก
		string selectedSubject = e.SelectedItem as string;

		// เรียกใช้ DeleteSubject command
		var viewModel = BindingContext as EnrollViewModel;
		if (viewModel != null)
		{
			await viewModel.DeleteSubject(selectedSubject);
		}

	// รีเซ็ตการเลือกรายวิชา
	((ListView)sender).SelectedItem = null;
	}
}