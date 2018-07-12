using CalcUshakov.CalculatorTwoArgument;
using NUnit.Framework;

namespace CalcUshakov.Tests.TwoArgumentTest
{
        [TestFixture]
        public class MultiplicationTests
        {
            [Test]
            public void MultiplicationTest()
            {
                ICalculateTwoArguments calculator = CalculatorTwoFactory.CreateCalculator("Multiplication");
                double result = calculator.Calculator(5, 5);
                Assert.AreEqual(25, result);
            }
            [TestCase(10, 5, 50)]
            [TestCase(3, 4, 12)]
            [TestCase(10, 15, 150)]
            public void CalculateTest(double firstValue, double secondValue, double expected)
            {
                var calculator = new Multiplication();
                var actualResult = calculator.Calculator(firstValue, secondValue);
                Assert.AreEqual(expected, actualResult);
            }
        }
    }
