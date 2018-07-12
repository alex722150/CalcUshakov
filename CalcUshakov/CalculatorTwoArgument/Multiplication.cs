namespace CalcUshakov.CalculatorTwoArgument
{
    public class Multiplication : ICalculateTwoArguments
    {
        /// <summary>
        /// Calculate function multyplication
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// Multiplication is performed
        /// <returns>
        /// Returns   multiplication of two argument
        /// </returns>
        public double Calculator(double firstArgument, double secondArgument)
        
        {
            return firstArgument * secondArgument;
        }
    }

}
