using System;
using System.Collections.Generic;
using System.Text;

namespace Math.Helpers
{
    public static class Extentions
    {
        public static int CalculateTheFactorial(this int num)
        {
            int mult = 1;
            for (int i = 1; i <= num; i++)
            {
                mult *= i;
            }
            return mult;
        }
    }
}