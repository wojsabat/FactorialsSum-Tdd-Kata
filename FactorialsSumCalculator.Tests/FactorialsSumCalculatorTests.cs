using Microsoft.VisualStudio.TestTools.UnitTesting;

//    16. Digit factorials
//    145 is a curious number, as 1! + 4! + 5! = 1 + 24 + 120 = 145.
//    Find the sum of all numbers which are equal to the sum of the factorial git of their digits.
//    Note: as 1! = 1 and 2! = 2 are not sums they are not included.

namespace FactorialsSumCalculator.Tests
{
    [TestClass]
    public class FactorialsSumCalculatorTests
    {
        FactorialsOfDigitsSumCalculator calculator;

        [TestInitialize]
        public void Initialize()
        {
            calculator = new FactorialsOfDigitsSumCalculator();
        }

        [TestMethod]
        public void GetDigitsOfNumberTest()
        {
            var number = 123456;
            var expected = new [] {1, 2, 3, 4, 5, 6};

            var result = calculator.GetDigitsOfNumber(number);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FactorialOfDigitsSumTests()
        {
            var number = 1234;
            var expected = 1 + 2 + 2 * 3 + 2 * 3 * 4;

            var result = calculator.GetFactorialsOfDigitsSum(number);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsCuriousNumberReturnsTrueTest()
        {
            var number = 145;

            var result = calculator.IsCuriousNumber(number);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsCuriousNumberReturnsFalseTest()
        {
            var number = 12345;

            var result = calculator.IsCuriousNumber(number);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GetSumOfAllCuriousNumbersTest()
        {
            var maxValue = 150;
            var expected = 145;

            var result = calculator.GetSumOfAllCuriousNumbers(maxValue);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetSumOfAllCuriousNumbersWithBigMaxValueTest()
        {
            var maxValue = 1000000;
            var expected = 40730;

            var result = calculator.GetSumOfAllCuriousNumbers(maxValue);

            Assert.AreEqual(expected, result);
        }
    }
}
