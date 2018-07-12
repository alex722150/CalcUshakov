using System;

namespace CalcUshakov.CalculatorTwoArgument
{
    public static class CalculatorTwoFactory
    {
        public static ICalculateTwoArguments CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Addition":
                    return new Addition();
                case "Subtraction":
                    return new Subtraction();
                case "Multiplication":
                    return new Multiplication();
                case "Division":
                    return new Division();
                case "Mod":
                    return new Mod();
                case "Degree":
                    return new Degree();
                case "Average":
                    return new Average();
                case "Minimum":
                    return new Minimum();
                case "Maximum":
                    return new Maximum();
                case "Log":
                    return new Log();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
