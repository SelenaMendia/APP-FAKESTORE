using Tp5_AppFakeStore.Models;
using Tp5_AppFakeStore.Utils;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Tp5_AppFakeStore.ViewModels;

public partial class ProductoDetalleViewModel : BaseViewModel
{
    [ObservableProperty]
    Producto producto;

    public ProductoDetalleViewModel()
    {
        Title = "Detalle de Producto";
    }

    [RelayCommand]
    private async Task GoBack()
    {
        await Application.Current.MainPage.Navigation.PopAsync();
    }

    
}
