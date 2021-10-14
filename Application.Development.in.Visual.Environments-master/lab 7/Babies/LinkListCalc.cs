using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab_7.Babies
{
    public class LinkListCalc : Calculator
    {
        private LinkedList<DataPoint> dataPoints;

        public LinkedList<DataPoint> DataPoints { get => dataPoints; set => dataPoints = value; }

        public LinkListCalc(ref Chart chart, string nameOfSeries, DFunc f, double x1, double x2, double y, double step) : base(ref chart, nameOfSeries, f, x1, x2, y, step)
        {
            dataPoints = new LinkedList<DataPoint>();

        }

        public void restart(DFunc f, double x1, double x2, double y, double step)
        {
            X1 = x1;
            X2 = x2;
            Y = y;
            Step = step;
            F = f;

            dataPoints.Clear();
            chart.Series[NameOfSeries].Points.Clear();
        }

        public DataPoint CalcDot()
        {
            switch (calcMod)
            {
                case CalcMod.EULER:
                    {
                        if (CalcEulerMethodStep(out DataPoint point))
                        {
                            dataPoints.AddLast(point);
                            return point;
                        }

                        break;
                    }
                case CalcMod.TRAPEZOIDAL:
                    {
                        if (CalcTrapezoidalMethodStep(out DataPoint point))
                        {
                            dataPoints.AddLast(point);

                            return point;
                        }
                        break;
                    }
                case CalcMod.RUNGE_KHUTT3:
                    {
                        if (CalcRungeCutt3MethodStep(out DataPoint point))
                        {
                            dataPoints.AddLast(point);

                            return point;
                        }
                        break;
                    }
                case CalcMod.RUNGE_KHUTT4:
                    {
                        if (CalcRungeCutt4MethodStep(out DataPoint point))
                        {
                            dataPoints.AddLast(point);

                            return point;
                        }
                        break;
                    }
            }
            return null;
        }

        public void DrawDot()
        {
            chart.Series[NameOfSeries].Points.AddXY(dataPoints.Last.Value.XValue, dataPoints.Last.Value.YValues[0]);
        }

        public DataPoint LastPoint()
        {
            return dataPoints.Last.Value;
        }

        public void DrawDots()
        {
            chart.Series[NameOfSeries].Points.Clear();

            foreach (DataPoint point in dataPoints)
            {
                chart.Series[NameOfSeries].Points.AddXY(point.XValue, point.YValues[0]);
            }
        }
    }

}
