using Tp5_AppFakeStore.Services;
using Tp5_AppFakeStore.ViewModels;

namespace Tp5_AppFakeStore.Views;

public partial class ProductoListaPage : ContentPage
{
	public ProductoListaPage()
	{
		ProductoService service = new ProductoService();
		ProductoListaViewModel vm = new ProductoListaViewModel(service);

		InitializeComponent();
		this.BindingContext = vm;
	}

	protected async override void OnAppearing()
	{
		base.OnAppearing();

		var vm = BindingContext as ProductoListaViewModel;

		if (vm != null)
		{
			await vm.GetProductosCommand.ExecuteAsync(null);
		}
	}


    
}