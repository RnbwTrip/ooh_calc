using System;

namespace ooh_calc.OneArgument
{
   public class Tan:ISingleCalculator
    {
       public double Calculate(double first)
       {
           return Math.Tan(first);
       }
    }
}
