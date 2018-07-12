namespace CalcUshakov.CalculatorTwoArgument
{
    public class Average : ICalculateTwoArguments
    {
        /// <summary>
        /// Calculate function Average
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// Average is performed
        /// <returns>
        /// Returns  Average from the first argument of the second argument
        /// </returns>

        public double Calculator(double firstArgument, double secondArgument)
        {
            return (firstArgument+secondArgument)/2;
        }
    }
}
