using CalcUshakov.CalculatorTwoArgument;
using NUnit.Framework;

namespace CalcUshakov.Tests.TwoArgumentTest
{
        [TestFixture]
        public class DivisionTests
        {
            [Test]
            public void DivisionTest()
            {
                ICalculateTwoArguments calculator = CalculatorTwoFactory.CreateCalculator("Division");
                double result = calculator.Calculator(5, 5);
                Assert.AreEqual(1, result);
            }
            [TestCase(10, 5, 2)]
            [TestCase(20, 4, 5)]
            [TestCase(100, 10, 10)]
            public void CalculateTest(double firstValue, double secondValue, double expected)
            {
                var calculator = new Division();
                var actualResult = calculator.Calculator(firstValue, secondValue);
                Assert.AreEqual(expected, actualResult);
            }

        }
    }

