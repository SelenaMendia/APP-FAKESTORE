using Tp5_AppFakeStore.ViewModels;

namespace Tp5_AppFakeStore
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();

            MainViewModel viewModel = new MainViewModel();
            this.BindingContext = viewModel;
        }
        
    }

}
