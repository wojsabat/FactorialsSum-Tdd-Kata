using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FactorialsSumCalculator.Tests
{

    [TestClass]
    public class ExtensionsTests
    {
        [TestMethod]
        public void IntToFactorialExtensionTest()
        {
            var number = 8;
            var expected = 40320;

            var result = number.Factorial();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CharToNumberExtensionTest()
        {
            var character = '9';
            var expected = 9;

            var result = character.ToInt();

            Assert.AreEqual(expected, result);
        }
    }
}
