using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SignalRTest.Models;

namespace SignalRTest.Services
{
    public class LocalDbManager : IDbManager
    {
        private UsersContext context;
        public LocalDbManager(UsersContext context)
        {
            this.context = context;
        }
        public bool Register(RegisterModel model)
        {
            if (context.Users.FirstOrDefault(x => x.Login == model.Login) != null)
            {
                return false;
            }
            context.Users.Add(model);
            context.SaveChanges();
            return true;
        }

        public RegisterModel Login(LoginModel model)
        {
            var user = context.Users.FirstOrDefault(x => x.Login == model.Login);
            if (user != null && user.Password == model.Password)
            {
                return user;
            }

            return null;
        }
    }
}
