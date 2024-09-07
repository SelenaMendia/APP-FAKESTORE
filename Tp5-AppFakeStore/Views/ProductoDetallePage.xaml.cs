using Tp5_AppFakeStore.Models;
using Tp5_AppFakeStore.ViewModels;

namespace Tp5_AppFakeStore.Views;

public partial class ProductoDetallePage : ContentPage
{
	public ProductoDetallePage(Producto param)
	{
		InitializeComponent();

		ProductoDetalleViewModel vm = new ProductoDetalleViewModel();
		this.BindingContext = vm;		
		vm.Producto = param;
	}
}