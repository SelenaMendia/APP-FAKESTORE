using Tp5_AppFakeStore.Services;
using Tp5_AppFakeStore.ViewModels;

namespace Tp5_AppFakeStore.Views;

public partial class UsuarioListaPage : ContentPage
{
    public UsuarioListaPage()
    {
        UsuarioServices service = new UsuarioServices();
        UsuarioViewModel vm = new UsuarioViewModel(service);

        InitializeComponent();

        this.BindingContext = vm;
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();

        var vm = BindingContext as UsuarioViewModel;

        if (vm != null)
        {
            await vm.GetUsersCommand.ExecuteAsync(null);
        }
    }
}