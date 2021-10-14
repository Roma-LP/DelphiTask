using Lab15.Integrals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Integrals
{
    public class IntegralEX : Integral
    {
        public IntegralEX() : base()
        {
            Title = "e^x";
        }
        public IntegralEX(int bottom, int top, int steps) : this()
        {
            Bottom = bottom;
            Top = top;
            Steps = steps;
        }

        public override double Function(double x) => Math.Pow(Math.E, x);
    }
}
