using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services.Implementations
{
    public class AccountService : IAccountService
    {
        public void CheckRoles(string role)
        {
            switch (role)
            {
                case "SuperAdmin":
                    Console.WriteLine("Access is successful.");
                    break;
                case "Admin":
                    Console.WriteLine("There is no your authorization for access.");
                    break;
                case "Member":
                    Console.WriteLine("There is no your authorization for access.");
                    break;
            }
        }

        public void Login(string email, string password, string role)
        {
            if (email == "test@code.edu.az" && password == "test12345")
            {
                CheckRoles(role);
            }
            else
            {
                if (email != "test@code.edu.az")
                {
                    Console.WriteLine("Your email is wrong. Please enter your email correctly again.");
                }

                else if (password != "test12345")
                {
                    Console.WriteLine("Your password is wrong. Please enter your password correctly again.");
                }
            }
        }
    }
}