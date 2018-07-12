using CalcUshakov.CalculatorOneArgument;
using NUnit.Framework;

namespace CalcUshakov.Tests.OneArgumentTest
{

    [TestFixture]
    public class SqrtTests
    {
        [Test]
        public void SquareTest()
        {
            ICalculatorOneArgument calculator = CalculatorOneFactory.CreateCalculator("Sqrt");
            double result = calculator.Calculator(25);
            Assert.AreEqual(5, result);
        }
        [TestCase(9, 3)]
        [TestCase(25, 5)]
        [TestCase(64, 8)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Sqrt();
            var actualResult = calculator.Calculator(firstValue);
            Assert.AreEqual(expected, actualResult);
        }


    }
}