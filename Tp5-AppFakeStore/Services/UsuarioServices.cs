﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Tp5_AppFakeStore.Models;
using Tp5_AppFakeStore.Utils;

namespace Tp5_AppFakeStore.Services
{
    public class UsuarioServices : IUsuarioServices
    {
        HttpClient client;

        private static JsonSerializerOptions options = new()
        {
            PropertyNameCaseInsensitive = true
        };

        public UsuarioServices()
        {
            client = new HttpClient();

            client.BaseAddress = new Uri(Constants.ApiDataServer);
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<IEnumerable<Usuario>> GetUsersAsync()
        {
            var response = await client.GetAsync(Constants.UsersEndpoint);

            if (response.IsSuccessStatusCode)
                return await response.Content.ReadFromJsonAsync<IEnumerable<Usuario>>(options);

            return default;
        }

        public async Task<Usuario> GetUserByIdAsync(int id)
        {
            var response = await client.GetAsync($"{Constants.UsersEndpoint}/{id}");

            if (response.IsSuccessStatusCode)
                return await response.Content.ReadFromJsonAsync<Usuario>(options);

            return default;
        }

    }
}
