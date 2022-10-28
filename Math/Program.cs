using Service.Services.Implementations;
using Math.Helpers;
using System;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1

            AccountService user = new AccountService();
            user.Login("test@code.edu.az", "test12345", "SuperAdmin");

            //Task 2

            //int num = 7;
            //Console.WriteLine("Factorial of number = " + num.CalculateTheFactorial());
        }
    }
}