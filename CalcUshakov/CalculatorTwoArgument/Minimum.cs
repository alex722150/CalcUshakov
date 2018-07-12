namespace CalcUshakov.CalculatorTwoArgument
{
    public class Minimum : ICalculateTwoArguments
    {
        /// <summary>
        /// Calculate function minimum
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// minimum is performed
        /// <returns>
        /// Returns  minimum from the first argument of the second argument
        /// </returns>

        public double Calculator(double firstArgument, double secondArgument)
        {
            if (firstArgument < secondArgument)
            {
                return firstArgument;
            }

            return secondArgument;
        }
    }
}
