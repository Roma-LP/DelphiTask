using Lab15.Integrals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Integrals
{
    public class IntegralE2X : Integral
    {
        public IntegralE2X() : base()
        {
            Title = "e^2x";
        }
        public IntegralE2X(int bottom, int top, int steps) : this()
        {
            Bottom = bottom;
            Top = top;
            Steps = steps;
        }

        public override double Function(double x) => Math.Pow(Math.E, 2 * x);
    }
}
