using Tp5_AppFakeStore.Models;
using Tp5_AppFakeStore.Services;
using Tp5_AppFakeStore.ViewModels;

namespace Tp5_AppFakeStore.Views;

public partial class CategoriaPage : ContentPage
{
	public CategoriaPage()
	{
		InitializeComponent();

        BindingContext = new CategoriaViewModel(new CategoriaService());
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        var viewModel = BindingContext as CategoriaViewModel;
        if (viewModel != null && !viewModel.IsBusy)
        {
            Task.Run(viewModel.GetCategoriasAsync);
        }
    }


}