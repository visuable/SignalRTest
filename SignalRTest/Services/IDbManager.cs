using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SignalRTest.Models;

namespace SignalRTest.Services
{
    public interface IDbManager
    {
        bool Register(RegisterModel model);
        RegisterModel Login(LoginModel model);
    }
}
