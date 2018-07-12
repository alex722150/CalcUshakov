using System;

namespace CalcUshakov.CalculatorOneArgument
{
    public class Deg2 : ICalculatorOneArgument
    {
        /// <summary>
        /// Calculate function Deg2(x)
        /// </summary>
        /// <param name="firstArgument"></param>
        /// Deg2(x) is calculate
        /// <returns>
        /// Returns result Deg2(X)
        /// </returns>

        public double Calculator(double firstArgument)
        {
            return Math.Pow(2,firstArgument);
        }
    }
}
