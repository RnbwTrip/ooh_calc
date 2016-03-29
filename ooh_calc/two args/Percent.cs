using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooh_calc.two_args
{
    public class Percent : ICalculator
    {
        public double Calculate(double first, double second)
        {
            return (first*(second/100));
        }
    }
}
