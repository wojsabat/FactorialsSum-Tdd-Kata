using System;

namespace FactorialsSumCalculator
{
    public static class Extensions
    {
        public static int Factorial(this int number)
        {
            var result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        public static int ToInt(this char ch)
        {
            double number = char.GetNumericValue(ch);
            return Convert.ToInt32(number);
        }
    }
}