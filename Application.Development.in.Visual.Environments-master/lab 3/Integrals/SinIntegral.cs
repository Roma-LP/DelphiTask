using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab_3.Integrals
{
    public class SinIntegral : FatherOfIntegrals
    {
        public SinIntegral(ref Chart chartRef, string nameOfSeries, double Bottom, double Top, double Step) : base(ref chartRef, nameOfSeries, Bottom, Top, Step) { }

        public override double Function(double x) => Math.Sin(x);

    }
}
