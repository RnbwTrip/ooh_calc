using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooh_calc.one_arg
{
    public class ATan : ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Atan(first);
        }
    }
}
