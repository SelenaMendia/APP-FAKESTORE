using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Tp5_AppFakeStore.Models;

namespace Tp5_AppFakeStore.ViewModels
{
    public partial class UsuarioDetalleViewModel : BaseViewModel
    {
        [ObservableProperty]
        Usuario usuario;

        
        public UsuarioDetalleViewModel(Usuario usuario = null)
        {
            Title = "Detalle de Usuario";
            Usuario = usuario;
        }

        [RelayCommand]
        private async Task GoBack()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
