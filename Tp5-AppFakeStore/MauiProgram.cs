using Microsoft.Extensions.Logging;
using Tp5_AppFakeStore.Services;
using Tp5_AppFakeStore.ViewModels;
using Tp5_AppFakeStore.Views;

namespace Tp5_AppFakeStore
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("MaterialIcons-Regular.ttf", "MaterialDesignIcons");
                });
                 
            //login
            builder.Services.AddSingleton<IAuthService, AuthService>();
            builder.Services.AddTransient<LoginViewModel>();
            builder.Services.AddTransient<Login>();
            
            //producto
            builder.Services.AddSingleton<IProductoService, ProductoService>();
            builder.Services.AddTransient<ProductoListaViewModel>();
            builder.Services.AddTransient<ProductoListaPage>();
            //categoria
            builder.Services.AddSingleton<ICategoriaService, CategoriaService>();
            builder.Services.AddTransient<CategoriaPage>();
            builder.Services.AddTransient<CategoriaViewModel>();

            //usaurio
            builder.Services.AddSingleton<IUsuarioServices, UsuarioServices>();
            builder.Services.AddTransient<UsuarioViewModel>();
            builder.Services.AddTransient<UsuarioListaPage>();


#if DEBUG
            builder.Logging.AddDebug();

#endif

            return builder.Build();
        }
    }
}
