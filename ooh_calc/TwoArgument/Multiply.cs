namespace ooh_calc.TwoArgument
{
    /// <summary>
    /// Public Class.
    /// Exists "Calculate" function, which performs multiply.
    /// </summary>
    public class Multiply: ICalculator
    {
        /// <summary>
        /// Multiplying of two arguments
        /// </summary>
        /// <param name="first">
        /// First multiplier
        /// </param>
        /// <param name="second">
        /// Second multiplier
        /// </param>
        /// <returns>
        /// Returns the multiply
        /// </returns>
        public double Calculate(double first, double second)
        {
            return first * second;
        }
    }
}
