using System;
using CalcUshakov.CalculatorTwoArgument;
using NUnit.Framework;

namespace CalcUshakov.Tests.TwoArgumentTest
{
    namespace Calculator.Test
    {
        public class CalculatorTwoFactoryTest
        {
            [TestCase("Addition", typeof(Addition))]
            [TestCase("Subtraction", typeof(Subtraction))]
            [TestCase("Multiplication", typeof(Multiplication))]
            [TestCase("Division", typeof(Division))]

            public void CalculattorTest(string name, Type type)
            {
                var calculator = CalculatorTwoFactory.CreateCalculator(name);
                Assert.IsInstanceOf(type, calculator);
            }
        }
    }
}