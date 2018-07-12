namespace CalcUshakov.CalculatorOneArgument
{
    public class Cos : ICalculatorOneArgument
    {
        /// <summary>
        /// Calculation Cos(x) function
        /// </summary>
        /// <param name="firstArgument"></param>
        /// Cos(x) is calculate
        /// <returns>
        /// return result Cos(x)
        /// </returns>
        public double Calculator(double firstArgument)
        {
            return System.Math.Cos(firstArgument);
        }
    }
}
