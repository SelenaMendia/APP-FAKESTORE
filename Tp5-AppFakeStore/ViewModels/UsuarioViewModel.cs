using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Tp5_AppFakeStore.Models;
using Tp5_AppFakeStore.Services;
using Tp5_AppFakeStore.Views;


namespace Tp5_AppFakeStore.ViewModels
{
    public partial class UsuarioViewModel : BaseViewModel
    {
        public ObservableCollection<Usuario> Usuarios { get; } = new();

        [ObservableProperty]
        bool isRefreshing;

        [ObservableProperty]
        Usuario usuarioSeleccionado;

        IUsuarioServices _usuarioService;


        public UsuarioViewModel(IUsuarioServices usuarioService)
        {
            Title = "Lista de Usuarios";
            _usuarioService = usuarioService;
        }

        [RelayCommand]
        private async Task GetUsersAsync()
        {
            if (!IsBusy)
            {
                try
                {
                    IsBusy = true;

                    var usuario = await _usuarioService.GetUsersAsync();

                    if (usuario != null)
                    {
                        if (Usuarios.Count != 0)
                            Usuarios.Clear();

                        foreach (var user in usuario)
                            Usuarios.Add(user);
                    }

                    IsBusy = false;
                }
                catch (Exception ex)
                {
                    await App.Current.MainPage.DisplayAlert("Error!", ex.Message, "Ok");
                }
                finally
                {
                    IsBusy = false;
                }

            }
        }

        [RelayCommand]
        private async Task GoToDetail()
        {
            if (usuarioSeleccionado == null)
            {
                return;
            }

            if (usuarioSeleccionado.Id > 0) // Verificar si el Id es válido
            {
                await Application.Current.MainPage.Navigation.PushAsync(new UsuarioDetallePage(usuarioSeleccionado.Id), true);
            }
            else
            {
                await Application.Current.MainPage.Navigation.PushAsync(new UsuarioDetallePage(usuarioSeleccionado), true);
            }
        }
    }
}
