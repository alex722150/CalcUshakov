using CalcUshakov.CalculatorOneArgument;
using NUnit.Framework;

namespace CalcUshakov.Tests.OneArgumentTest
{

    [TestFixture]
    public class SquareTests
    {
        [Test]
        public void SquareTest()
        {
            ICalculatorOneArgument calculator = CalculatorOneFactory.CreateCalculator("Square");
            double result = calculator.Calculator(5);
            Assert.AreEqual(25, result);
        }
        [TestCase(5, 25)]
        [TestCase(4, 16)]
        [TestCase(3, 9)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Square();
            var actualResult = calculator.Calculator(firstValue);
            Assert.AreEqual(expected, actualResult);
        }


    }
}
