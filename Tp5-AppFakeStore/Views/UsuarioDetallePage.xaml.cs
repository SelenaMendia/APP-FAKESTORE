using Tp5_AppFakeStore.Models;
using Tp5_AppFakeStore.Services;
using Tp5_AppFakeStore.ViewModels;

namespace Tp5_AppFakeStore.Views;

public partial class UsuarioDetallePage : ContentPage
{
    

    // Constructor para cuando se pasa un Usuario completo
    public UsuarioDetallePage(Usuario usuario)
    {
        InitializeComponent();
        var vm = new UsuarioDetalleViewModel(usuario);
        this.BindingContext = vm;
    }

    // Constructor para cuando se pasa un ID de Usuario
    public UsuarioDetallePage(int userId)
    {
        InitializeComponent();
        var vm = new UsuarioDetalleViewModel();
        this.BindingContext = vm;
        LoadUsuarioById(userId);
    }

    // Método para cargar el usuario por ID
    private async void LoadUsuarioById(int userId)
    {
        var usuarioService = new UsuarioServices(); // Asegúrate de obtener la instancia adecuada
        var usuario = await usuarioService.GetUserByIdAsync(userId);
        if (BindingContext is UsuarioDetalleViewModel vm)
        {
            vm.Usuario = usuario;
        }
    }
}