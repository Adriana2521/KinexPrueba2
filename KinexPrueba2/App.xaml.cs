namespace KinexPrueba2;
using KinexPrueba2.Views;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new LoginView();
	}
}
