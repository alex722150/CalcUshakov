using CalcUshakov.CalculatorTwoArgument;
using NUnit.Framework;

namespace CalcUshakov.Tests.TwoArgumentTest
{
        [TestFixture]
        public class AdditionTests
        {
            [Test]
            public void AdditionTest()
            {
                ICalculateTwoArguments calculator = CalculatorTwoFactory.CreateCalculator("Addition");
                double result = calculator.Calculator(5, 5);
                Assert.AreEqual(10, result);
            }
            [TestCase(0, 0, 0)]
            [TestCase(3, 4, 7)]
            [TestCase(-7, -2, -9)]
            public void CalculateTest(double firstValue, double secondValue, double expected)
            {
                var calculator = new Addition();
                var actualResult = calculator.Calculator(firstValue, secondValue);
                Assert.AreEqual(expected, actualResult);
            }

        }
    }


