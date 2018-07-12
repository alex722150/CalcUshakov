using System;
using CalcUshakov.CalculatorOneArgument;
using NUnit.Framework;

namespace CalcUshakov.Tests.OneArgumentTest
{
    namespace Calculator.Test
    {
        public class CalculatorOneFactoryTest
        {
            [TestCase("Square", typeof(Square))]
            [TestCase("Sin", typeof(Sin))]
            [TestCase("Cos", typeof(Cos))]
            [TestCase("Sqrt", typeof(Sqrt))]

            public void CalculattorTest(string name, Type type)
            {
                var calculator = CalculatorOneFactory.CreateCalculator(name);
                Assert.IsInstanceOf(type, calculator);
            }
        }
    }
}
