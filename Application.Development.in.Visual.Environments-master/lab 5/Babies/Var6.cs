using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab_5
{
    class Var6 : Father
    {
        public Var6(double startX, double endX, double eps,ref Chart chart) : base(startX, endX, eps, chart)
        {
        }

        public override double func(double x)
        {
            return Math.Pow(x, 3) - 2 * Math.Pow(x, 2) - x + 2;
        }

        public override double iterFunc(double x)
        {
            return -2 / (Math.Pow(x, 2) - 2 * x - 1);
        }

        public override double diffFunc(double x)
        {
            return 3 * Math.Pow(x, 2) - 4 * x - 1;
        }
    }
}
