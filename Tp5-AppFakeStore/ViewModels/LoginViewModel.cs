using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp5_AppFakeStore.ViewModels;
using Tp5_AppFakeStore.Models;
using Tp5_AppFakeStore.Views;
using Tp5_AppFakeStore.Services;
using CommunityToolkit.Mvvm.Input;
using Login = Tp5_AppFakeStore.Views.Login;

namespace Tp5_AppFakeStore.ViewModels
{
    public partial class LoginViewModel : BaseViewModel
    {
        private readonly IAuthService _authService;

        private string _username;
        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }

        private string _password;
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        private string _loginMessage;
        public string LoginMessage
        {
            get => _loginMessage;
            set => SetProperty(ref _loginMessage, value);
        }


        public LoginViewModel(IAuthService authService)
        {
            _authService = authService;
            
        }
        [RelayCommand]
        private async Task Login()
        {
            IsBusy = true; // Mostrar el indicador de carga

            var result = await _authService.LoginAsync(Username, Password);

            IsBusy = false; // Ocultar el indicador de carga


            if (result != null && !string.IsNullOrEmpty(result.Token))
            {
                // Guardar el token en la aplicación
                LoginMessage = "Login exitoso!";

                // Navegar a la pantalla principal o realizar otras acciones
                Application.Current.MainPage = new NavigationPage(new MainPage());

                Username = string.Empty;
                Password = string.Empty; 
            }
            else
            {
                LoginMessage = "Login fallido. Verifica tus credenciales.";
            }
        }

        [RelayCommand]
        public async Task GoToLogin()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Login(new LoginViewModel(new AuthService())));
        }


    }
}
