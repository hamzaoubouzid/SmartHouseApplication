using CustomInputMaui.Views;

namespace SmartHouseApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AuthentificationPage();
	}
}
