using NUnit.Framework;

namespace Calculator.Web.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Should_add_two_numbers()
        {
            // 1. Arrange

            double x = 10;
            double y = 5;

            var expectedResult = (x + y);
            var calculator = new Calculator();

            // 2. Act

            var actualResult = calculator.Add(x, y);

            // 3. Assert

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Should_subtract_two_numbers()
        {
            // 1. Arrange

            double x = 10;
            double y = 5;

            var expectedResult = (x - y);
            var calculator = new Calculator();

            // 2. Act

            var actualResult = calculator.Subtract(x, y);

            // 3. Assert

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Should_multiply_two_numbers()
        {
            // 1. Arrange

            double x = 10;
            double y = 5;

            var expectedResult = (x * y);
            var calculator = new Calculator();

            // 2. Act

            var actualResult = calculator.Multiply(x, y);

            // 3. Assert

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Should_divide_two_numbers()
        {
            // 1. Arrange

            double x = 10;
            double y = 5;

            var expectedResult = (x / y);
            var calculator = new Calculator();

            // 2. Act

            var actualResult = calculator.Divide(x, y);

            // 3. Assert

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}