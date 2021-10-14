using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15.Functions
{
    public abstract class Function
    {
        public double OffsetX { get; set; }
        public double OffsetY { get; set; }
        public virtual string Title { get; }
        public abstract double F(double x);

        public Function()
        { 
        }

        public Function(double offsetX, double offsetY)
        {
            OffsetX = offsetX;
            OffsetY = offsetY;
        }

        public Function(double offsetX) : this(offsetX, 0)
        {
        }

    }
}
