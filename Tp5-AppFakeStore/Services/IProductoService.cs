using Tp5_AppFakeStore.Models;

namespace Tp5_AppFakeStore.Services;

public interface IProductoService
{
    Task<IEnumerable<Producto>> GetProductsAsync();



}
