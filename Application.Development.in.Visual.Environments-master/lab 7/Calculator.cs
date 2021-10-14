using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab_7
{
    public abstract class Calculator
    {
        public enum CalcMod { EULER, TRAPEZOIDAL, RUNGE_KHUTT3, RUNGE_KHUTT4 }
        public delegate double DFunc(double x, double y);

        protected CalcMod calcMod = CalcMod.EULER;
        protected Chart chart;

        public double X1 { get; set; }
        public double X2 { get; set; }
        public double Y { get; set; } = 1;
        public double Step { get; set; }
        public string NameOfSeries { get; set; }

        public DFunc F { get; set; }

        protected Calculator(ref Chart chart, string nameOfSeries, DFunc f, double x1, double x2, double y, double step)
        {
            this.chart = chart;
            X1 = x1;
            X2 = x2;
            Y = y;
            Step = step;
            NameOfSeries = nameOfSeries;
            F = f;
        }
        
        public void setEulerCalcMod() { calcMod = CalcMod.EULER; }
        public void setYsovCalcMod() { calcMod = CalcMod.TRAPEZOIDAL; }
        public void setRunge3CalcMod() { calcMod = CalcMod.RUNGE_KHUTT3; }
        public void setRunge4CalcMod() { calcMod = CalcMod.RUNGE_KHUTT4; }

        public bool CalcEulerMethodStep(out DataPoint point)
        {
            if (X1 < X2)
            {
                Y += Step * F(X1, Y);
                X1 += Step;

                point = new DataPoint(X1, Y);
                return true;
            }
            point = null;
            return false;
        }

        public bool CalcTrapezoidalMethodStep(out DataPoint point)
        {
            if (X1 < X2)
            {
                double k1 = Step * F(X1, Y);
                double k2 = Step * F(X1 + Step, Y + k1);
                Y += (k1 + k2) / 2;
                X1 += Step;

                point = new DataPoint(X1, Y);
                return true;
            }
            point = null;
            return false;
        }

        public bool CalcRungeCutt3MethodStep(out DataPoint point)
        {
            if (X1 < X2)
            {
                double k1 = F(X1, Y) * Step;
                double k2 = F(X1 + Step / 2, Y + Step * k1 / 2) * Step;
                double k3 = F(X1 + Step, Y + 2 * k2 + k1) * Step;
                Y += (k1 + 4 * k2 + k3) / 6;
                X1 += Step;

                point = new DataPoint(X1, Y);
                return true;
            }
            point = null;
            return false;
        }

        public bool CalcRungeCutt4MethodStep(out DataPoint point)
        {
            if (X1 < X2)
            {
                double k1 =F(X1, Y) * Step;
                double k2 =F(X1 + Step / 2, Y + Step * k1 / 2) * Step;
                double k3 =F(X1 + Step / 2, Y + Step * k2 / 2) * Step;
                double k4 =F(X1 + Step, Y + k3) * Step;
                Y += (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                X1 += Step;

                point = new DataPoint(X1, Y);
                return true;
            }
            point = null;
            return false;
        }
    }
}
