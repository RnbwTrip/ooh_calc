using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooh_calc.two_args
{
    public class Log: ICalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Log(first)/Math.Log(second);
        }
    }
}
