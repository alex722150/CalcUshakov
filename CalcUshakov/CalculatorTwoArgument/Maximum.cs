namespace CalcUshakov.CalculatorTwoArgument
{
    public class Maximum : ICalculateTwoArguments
    {
        /// <summary>
        /// Calculate function maximum
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// maximum is performed
        /// <returns>
        /// Returns  maximum from the first argument of the second argument
        /// </returns>

        public double Calculator(double firstArgument, double secondArgument)
        {
            if (firstArgument > secondArgument)
            {
                return firstArgument;
            }

            return secondArgument;
        }
    }
}
