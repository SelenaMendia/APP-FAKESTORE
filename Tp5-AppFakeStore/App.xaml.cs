using Tp5_AppFakeStore.Services;
using Tp5_AppFakeStore.Views;

namespace Tp5_AppFakeStore
{
    public partial class App : Application
    {
        private readonly IServiceProvider serviceProvider;

        public App(IServiceProvider servProvider)
        {

            InitializeComponent();

            serviceProvider = servProvider;


            //MainPage = new AppShell();
            // Configura la página de inicio como Login
            MainPage = new NavigationPage(serviceProvider.GetRequiredService<Login>());

            //MainPage = new NavigationPage(new VLogin());
        }
    }
}
