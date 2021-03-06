﻿using System;

namespace CalcUshakov.CalculatorOneArgument
{
    public class Sqrt : ICalculatorOneArgument
    {
        /// <summary>
        /// Calculate function Sqrt(x)
        /// </summary>
        /// <param name="firstArgument"></param>
        /// Sqrt(x) is calculate
        /// <returns>
        /// Returns result Sqrt(X)
        /// </returns>
        public double Calculator(double firstArgument)
        {
            if (firstArgument < 0)
            {
                throw new Exception("Не существует");
            }
            return Math.Sqrt(firstArgument);
        }
    }
}

