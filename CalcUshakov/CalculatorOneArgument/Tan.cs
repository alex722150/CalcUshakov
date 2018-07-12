namespace CalcUshakov.CalculatorOneArgument
{
    public class Tan : ICalculatorOneArgument
    {
        /// <summary>
        /// Calculate function Tan(x)
        /// </summary>
        /// <param name="firstArgument"></param>
        /// Square(x) is calculate
        /// <returns>
        /// Returns result Tan(X)
        /// </returns>
        public double Calculator(double firstArgument)
        {
            return System.Math.Tan(firstArgument);
        }
    }
}
