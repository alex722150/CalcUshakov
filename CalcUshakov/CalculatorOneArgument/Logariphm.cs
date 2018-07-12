namespace CalcUshakov.CalculatorOneArgument
{
    public class Logariphm : ICalculatorOneArgument
    {
        /// <summary>
        /// Calculate function log(x)
        /// </summary>
        /// <param name="firstArgument"></param>
        /// Log(x) is calculate
        /// <returns>
        /// Returns result Log(X)
        /// </returns>
        public double Calculator(double firstArgument)
        {
            return System.Math.Log(firstArgument);
        }
    }
}