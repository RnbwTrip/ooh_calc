using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooh_calc
{
    public class Sqr: ISingleCalculator
    {
        public double Calculate(double first)
        {
            return (first*first);
        }
    }
}
