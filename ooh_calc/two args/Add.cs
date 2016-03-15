using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ooh_calc
{
    public class Add: ICalculator
    {
        public double Calculate(double first, double second)
        {
            return first + second;
        }
    }
}
