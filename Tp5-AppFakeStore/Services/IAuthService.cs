using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp5_AppFakeStore.Models;

namespace Tp5_AppFakeStore.Services;

    public interface IAuthService
    {
        

        Task<Login> LoginAsync(string username, string password);
    }

