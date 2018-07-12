namespace CalcUshakov.CalculatorTwoArgument
{
    public class Mod : ICalculateTwoArguments
    {
        /// <summary>
        /// Calculate function subtraction
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// mod is performed
        /// <returns>
        /// Returns  mod from the first argument of the second argument
        /// </returns>

        public double Calculator(double firstArgument, double secondArgument)
        {
            return firstArgument % secondArgument;
        }
    }
}
