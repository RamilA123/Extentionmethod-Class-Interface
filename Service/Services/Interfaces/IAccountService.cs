using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services.Interfaces
{
    public interface IAccountService
    {
        public void Login(string email, string password, string role);

        public void CheckRoles(string role);
    }
}