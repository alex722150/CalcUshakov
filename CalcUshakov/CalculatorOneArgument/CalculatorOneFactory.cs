using System;
using CalcUshakov.CalculatorTwoArgument;

namespace CalcUshakov.CalculatorOneArgument
{
    public static class CalculatorOneFactory
    {
        public static ICalculatorOneArgument CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Square":
                    return new Square();
                case "Sin":
                    return new Sin();
                case "Cos":
                    return new Cos();
                case "Sqrt":
                    return new Sqrt();
                case "Tan":
                    return new Tan();
                case "Tanh":
                    return new Tanh();
                case "Logariphm":
                    return new Logariphm();
                case "Deg2":
                    return new Deg2();
                case "Fabs":
                    return new Fabs();
                case "Inversion":
                    return new Inversion();
               
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
