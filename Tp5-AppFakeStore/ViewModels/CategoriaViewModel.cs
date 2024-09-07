using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Tp5_AppFakeStore.Models;
using Tp5_AppFakeStore.Services;
using Tp5_AppFakeStore.Views;

namespace Tp5_AppFakeStore.ViewModels
{
    public partial class CategoriaViewModel : BaseViewModel
    {
        private readonly ICategoriaService _categoriaService;

        public ObservableCollection<Categoria> Categorias { get; } = new();

        [ObservableProperty]
        bool isRefreshing;

        public CategoriaViewModel(ICategoriaService categoriaService)
        {
            Title = "Categorías";
            _categoriaService = categoriaService;
        }

        [RelayCommand]
        public async Task GetCategoriasAsync()
        {
            if (!IsBusy)
            {
                try
                {
                    IsBusy = true;

                    var categorias = await _categoriaService.GetCategoriesAsync();

                    if (Categorias.Count > 0)
                        Categorias.Clear();

                    foreach (var categoria in categorias)
                    {
                        Categorias.Add(categoria);
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

        
    }
}
