namespace CalcUshakov.CalculatorOneArgument
{
    public class Fabs : ICalculatorOneArgument
    {
        /// <summary>
        /// Calculation Fabs(x) function
        /// </summary>
        /// <param name="firstArgument"></param>
        /// Fabs(x) is calculate
        /// <returns>
        /// return result Fabs(x)
        /// </returns>
        public double Calculator(double firstArgument)
        {
            return System.Math.Abs(firstArgument);
        }
    }
}
