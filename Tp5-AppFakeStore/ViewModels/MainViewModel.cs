using Tp5_AppFakeStore.Views;
using CommunityToolkit.Mvvm.Input;
using Tp5_AppFakeStore.ViewModels;
using Tp5_AppFakeStore.Services;

namespace Tp5_AppFakeStore.ViewModels;

public partial class MainViewModel : BaseViewModel
{
    public MainViewModel()
    {
        Title = "ITES - Demo MVVM";
    }

    [RelayCommand]
    public async Task GoToProductoLista()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new ProductoListaPage());
    }




    [RelayCommand]
    public async Task GoToUsuarioListaPage()
    {
        // Navegación con Shell
        await Application.Current.MainPage.Navigation.PushAsync(new UsuarioListaPage());
    }


    [RelayCommand]
    public async Task GoToCategoriaPage()
    {
        // Navegación a la página de categorías
        await Application.Current.MainPage.Navigation.PushAsync(new CategoriaPage());
    }


    [RelayCommand]
    public async Task GoToAcercaDesarrollador()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new AcercaDesarrollador());
    }

    [RelayCommand]
    public async Task GoToLogin()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new Login(new LoginViewModel(new AuthService())));
    }


    //[RelayCommand]
    //public async Task Exit()
    //{
    //    await Application.Current.MainPage.DisplayAlert("Salir", "¿Desea terminar la sesión y salir?", "Aceptar");
    //}

    [RelayCommand]
    public async Task Exit()
    {
        bool shouldExit = await Application.Current.MainPage.DisplayAlert(
            "Salir",
            "¿Desea terminar la sesión y salir?",
            "Aceptar",
            "Cancelar"
        );

        if (shouldExit)
        {
            // Cierra la aplicacion
            Application.Current.Quit();
        }
    }

}
