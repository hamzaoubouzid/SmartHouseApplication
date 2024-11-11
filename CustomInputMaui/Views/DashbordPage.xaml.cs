using CustomInputMaui.ViewModels;

namespace CustomInputMaui.Views;

public partial class DashbordPage : ContentPage
{
	public DashbordPage()
	{
		InitializeComponent();
		BindingContext = new DashbordViewModel();

    }
}