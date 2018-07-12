using System;

namespace CalcUshakov.CalculatorTwoArgument
{
    public class Log : ICalculateTwoArguments
    {
        /// <summary>
        /// Calculate function Log
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// Log is performed
        /// <returns>
        /// Returns  Log from the first argument of the second argument
        /// </returns>

        public double Calculator(double firstArgument, double secondArgument)
        {
            return Math.Log(secondArgument, firstArgument); 
          
            }

         
    }
}
