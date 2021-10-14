using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15.Functions
{
    public class FunctionLab15 : Function
    {
        public override double F(double x) => Math.Exp(x * (-0.5 * x + 2)) * Math.Cos(x);
    }
}
