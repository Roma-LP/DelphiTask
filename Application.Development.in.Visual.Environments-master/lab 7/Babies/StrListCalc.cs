using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab_7.Babies
{
    public class StrListCalc : Calculator
    {
        private List<string[]> dataPoints;

        public List<string[]> DataPoints { get => dataPoints; set => dataPoints = value; }

        public StrListCalc(ref Chart chart, string nameOfSeries, DFunc f, double x1, double x2, double y, double step) : base(ref chart, nameOfSeries, f, x1, x2, y, step)
        {
            dataPoints = new List<string[]>();

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
                            dataPoints.Add(new string[] { point.XValue.ToString(), point.YValues[0].ToString() });
                            return point;
                        }

                        break;
                    }
                case CalcMod.TRAPEZOIDAL:
                    {
                        if (CalcTrapezoidalMethodStep(out DataPoint point))
                        {
                            dataPoints.Add(new string[] { point.XValue.ToString(), point.YValues[0].ToString() });

                            return point;
                        }
                        break;
                    }
                case CalcMod.RUNGE_KHUTT3:
                    {
                        if (CalcRungeCutt3MethodStep(out DataPoint point))
                        {
                            dataPoints.Add(new string[] { point.XValue.ToString(), point.YValues[0].ToString() });

                            return point;
                        }
                        break;
                    }
                case CalcMod.RUNGE_KHUTT4:
                    {
                        if (CalcRungeCutt4MethodStep(out DataPoint point))
                        {
                            dataPoints.Add(new string[] { point.XValue.ToString(), point.YValues[0].ToString() });

                            return point;
                        }
                        break;
                    }
            }
            return null;
        }

        public void DrawDot()
        {
            chart.Series[NameOfSeries].Points.AddXY(
                Convert.ToDouble(dataPoints[dataPoints.Count - 1][0]),
                Convert.ToDouble(dataPoints[dataPoints.Count - 1][1]));
        }

        public string[] LastPoint()
        {
            return dataPoints[dataPoints.Count - 1];
        }


        public void DrawDots()
        {
            chart.Series[NameOfSeries].Points.Clear();

            foreach (string[] point in dataPoints)
            {
                chart.Series[NameOfSeries].Points.AddXY(
                    Convert.ToDouble(dataPoints[dataPoints.Count - 1][0]),
                    Convert.ToDouble(dataPoints[dataPoints.Count - 1][1]));
            }
        }
    }
}
