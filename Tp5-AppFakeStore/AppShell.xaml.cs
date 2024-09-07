using Tp5_AppFakeStore.Models;

namespace Tp5_AppFakeStore
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Navegar a la página de login al iniciar la aplicación
            Routing.RegisterRoute("login", typeof(Login));
            GoToAsync("login");
        }
    }
}
