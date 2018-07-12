namespace CalcUshakov.CalculatorOneArgument
{
    public class Tanh : ICalculatorOneArgument
    {
        /// <summary>
        /// Calculate function Tanh(x)
        /// </summary>
        /// <param name="firstArgument"></param>
        /// Square(x) is calculate
        /// <returns>
        /// Returns result Tanh(X)
        /// </returns>
        public double Calculator(double firstArgument)
        {
            return System.Math.Tanh(firstArgument);
        }
    }
}