namespace CalcUshakov.CalculatorOneArgument
{
    public class Inversion : ICalculatorOneArgument
    {
        /// <summary>
        /// Calculation Infersion(x) function
        /// </summary>
        /// <param name="firstArgument"></param>
        /// Infersion(x) is calculate
        /// <returns>
        /// return result Infersion(x)
        /// </returns>
        public double Calculator(double firstArgument)
        {
            return -firstArgument;
        }
    }
}
