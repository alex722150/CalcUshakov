using CalcUshakov.CalculatorTwoArgument;
using NUnit.Framework;

namespace CalcUshakov.Tests.TwoArgumentTest
{

        [TestFixture]
        public class SubtractionTests
        {
            [Test]
            public void SubtractionTest()
            {
                ICalculateTwoArguments calculator = CalculatorTwoFactory.CreateCalculator("Subtraction");
                double result = calculator.Calculator(5, 5);
                Assert.AreEqual(0, result);
            }
            [TestCase(10, 5, 5)]
            [TestCase(3, 4, -1)]
            [TestCase(10, 15, -5)]
            public void CalculateTest(double firstValue, double secondValue, double expected)
            {
                var calculator = new Subtraction();
                var actualResult = calculator.Calculator(firstValue, secondValue);
                Assert.AreEqual(expected, actualResult);
            }
        }

    }
