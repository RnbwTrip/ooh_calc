using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ooh_calc
{
    public class Sinus: ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    }
}
