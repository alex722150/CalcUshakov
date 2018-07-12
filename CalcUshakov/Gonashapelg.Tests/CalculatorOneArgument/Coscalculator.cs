using CalcUshakov.CalculatorOneArgument;
using NUnit.Framework;

namespace CalcUshakov.Tests.OneArgumentTest
{

    [TestFixture]
    public class CosTests
    {
        [Test]
        public void CosTest()
        {
            ICalculatorOneArgument calculator = CalculatorOneFactory.CreateCalculator("Cos");
            double result = calculator.Calculator(1);
            Assert.AreEqual(0.54030, result, 0.00001);
        }
        [TestCase(1, 0.54030)]
        [TestCase(0, 1)]
        [TestCase(45, 0.52532)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Cos();
            var actualResult = calculator.Calculator(firstValue);
            Assert.AreEqual(expected, actualResult, 0.00001);
        }
    }
}
