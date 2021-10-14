using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab_5
{
    class Var3 : Father
    {
        public Var3(double startX, double endX, double eps,ref Chart chart) : base(startX, endX, eps, chart)
        {
        }

        public override double func(double x)
        {
             return x * x + 2 * x - 3;
        }

        public override double iterFunc(double x)
        {
            return 3/(x+2);
        }

        public override double diffFunc(double x)
        {
            return 2 * x + 2;
        }
    }
}
