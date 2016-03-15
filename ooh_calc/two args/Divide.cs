using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooh_calc
{
    public class Divide: ICalculator
    {
        public double Calculate(double first, double second)
        {
            return first / second;
        }
    }
}
