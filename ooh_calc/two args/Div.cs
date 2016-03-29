using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooh_calc.two_args
{
    public class Div : ICalculator
    {
        public double Calculate(double first, double second)
        {
            return (int)((Math.Round(first))/(Math.Round(second)));
        }
    }
}
