using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp5_AppFakeStore.Models;
using Tp5_AppFakeStore.Utils;
using Tp5_AppFakeStore.Services;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Net.Http.Json;

namespace Tp5_AppFakeStore.Services
{ 
public class AuthService : IAuthService
{
    HttpClient client;

    private static JsonSerializerOptions options = new()
    {
        PropertyNameCaseInsensitive = true
    };

    public AuthService()
    {
        client = new HttpClient();
        client.BaseAddress = new Uri(Constants.ApiDataServer);
        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
    }



        public async Task<Login> LoginAsync(string username, string password)
        {
            var loginRequest = new Login { Username = username, Password = password };

            
            var response = await client.PostAsJsonAsync("/auth/login", loginRequest);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Login>(options);
            }
            else
            {
                var response1 = await client.PostAsJsonAsync("/user/id", loginRequest);

                if (response1.IsSuccessStatusCode)
                {
                    return await response1.Content.ReadFromJsonAsync<Login>(options);
                }
            }

            return null;
        }
    
    }
}

