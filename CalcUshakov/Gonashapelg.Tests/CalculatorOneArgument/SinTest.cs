using CalcUshakov.CalculatorOneArgument;
using NUnit.Framework;

namespace CalcUshakov.Tests.OneArgumentTest
{

    [TestFixture]
    public class SinTests
    {
        [Test]
        public void SinTest()
        {
            ICalculatorOneArgument calculator = CalculatorOneFactory.CreateCalculator("Sin");
            double result = calculator.Calculator(1);
            Assert.AreEqual(0.8414709848, result, 0.00001);
        }
        [TestCase(1, 0.84147)]
        [TestCase(0, 0)]
        [TestCase(45, 0.85090)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Sin();
            var actualResult = calculator.Calculator(firstValue);
            Assert.AreEqual(expected, actualResult, 0.00001);
        }
    }
}
