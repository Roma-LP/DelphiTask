using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab_5
{
    class Sin : Father
    {
        public Sin(double startX, double endX, double eps,ref Chart chart) : base(startX, endX, eps, chart)
        {
        }

        public override double func(double x)
        {
            return  Math.Sin(x);
        }

        public override double iterFunc(double x)
        {
            return Math.Asin(x);
        }

        public override double diffFunc(double x)
        {
            return Math.Cos(x);
        }
    }
}
