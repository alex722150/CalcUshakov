using System;

namespace CalcUshakov.CalculatorTwoArgument
{
    public class Degree : ICalculateTwoArguments
    {
        /// <summary>
        /// Calculate function degree
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// degree is performed
        /// <returns>
        /// Returns  degree from the first argument of the second argument
        /// </returns>

        public double Calculator(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, secondArgument);
        }
    }
}
