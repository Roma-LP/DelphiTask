using Lab15.Integrals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Integrals
{
    public class IntegralX2 : Integral
    {
        public IntegralX2() : base()
        {
            Title = "x^2";
        }
        public IntegralX2(int bottom, int top, int steps) : this()
        {
            Bottom = bottom;
            Top = top;
            Steps = steps;
        }

        public override double Function(double x) => x * x;
    }
}
