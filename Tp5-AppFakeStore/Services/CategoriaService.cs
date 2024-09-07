using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Tp5_AppFakeStore.Models;

namespace Tp5_AppFakeStore.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly HttpClient _client;

        public CategoriaService()
        {
            _client = new HttpClient { BaseAddress = new Uri("https://fakestoreapi.com/") };
        }

        public async Task<IEnumerable<Categoria>> GetCategoriesAsync()
        {
            var response = await _client.GetFromJsonAsync<IEnumerable<string>>("products/categories");
            return response.Select(c => new Categoria { Name = c });
        }
    }
}
