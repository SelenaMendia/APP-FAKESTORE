using Tp5_AppFakeStore.ViewModels;

namespace Tp5_AppFakeStore.Views;

public partial class Login : ContentPage
{
	public Login(LoginViewModel ViewModels) //LoginViewModel ViewModels
    {
		InitializeComponent();
		BindingContext = ViewModels;
    }


}