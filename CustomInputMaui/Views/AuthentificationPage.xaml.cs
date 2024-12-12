using CustomInputMaui.ViewModels;

namespace CustomInputMaui.Views;

public partial class AuthentificationPage : ContentPage
{
	public AuthentificationPage()
	{
		InitializeComponent();
        BindingContext = new AuthentificationViewModel(Navigation);
    }
}