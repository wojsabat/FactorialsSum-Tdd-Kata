using System.Linq;

namespace FactorialsSumCalculator
{
    public class FactorialsOfDigitsSumCalculator
    {
        public int GetSumOfAllCuriousNumbers(int maxValue)
        {
            var sum = 0;
            for (int i = 3; i <= maxValue; i++)
            {
                if (IsCuriousNumber(i))
                    sum += i;
            }
            return sum;
        }

        public bool IsCuriousNumber(int number)
        {
            return number.Equals(GetFactorialsOfDigitsSum(number));
        }

        public int GetFactorialsOfDigitsSum(int number)
        {
            var digits = GetDigitsOfNumber(number);
            var factorials = digits.Select(d => d.Factorial());
            return factorials.Sum();
        }

        public int[] GetDigitsOfNumber(int number)
        {
            var stringNumber = number.ToString();
            var charArray = stringNumber.ToCharArray();
            var digits = charArray.Select(ch => ch.ToInt());
            return digits.ToArray();
        }
    }
}
