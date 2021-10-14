using System;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab_2
{
    class Integrals
    {
        public enum Mods { LEFT_RECTANGLE_METHOD, MIDDLE_RECTANGLE_METHOD, RIGHT_RECTANGLE_METHOD, TRAPEZOID_METHOD }

        public double lim1; //lower limit of integral
        private double lim2; //upper limit of integral
        private double step; //step of integral

        public double Lim1 { get => lim1; set => lim1 = value; }
        public double Lim2 { get => lim2; set => lim2 = value; }
        public double Step { get => step; set => step = value; }

        public static double Func(double x)
        {
            return Math.Sin(x) / Math.Pow(x, 0.5);
        }

        public double CalcLeftRectanglesSquare()
        {
            double area = 0;

            for (double x = lim1; x <= lim2; x += step)
            {
                double y = Func(x);
                area += y * step;          //левых прямоугольников left rectangle
            }

            return area;
        }

        public Series CalcLeftRectanglesDots()
        {
            Series series = new Series();

            for (double x = lim1; x <= lim2; x += step)
            {
                double y = Func(x);

                series.Points.AddXY(x, y);
                if (x + step <= lim2)
                {
                    series.Points.AddXY(x + step, y);
                }
            }

            return series;
        }

        public double CalcMiddleRectanglesSquare()
        {
            double area = 0;

            for (double x = lim1; x <= lim2; x += step)
            {
                double y = Func(x + step / 2);

                area += y * step;   //средних прямоугольников middle rectangle

            }

            return area;
        }

        public Series CalcMiddleRectanglesDots()
        {
            Series series = new Series();

            for (double x = lim1; x <= lim2; x += step)
            {
                double y = Func(x + step / 2);

                series.Points.AddXY(x, y);
                if (x + step <= lim2)
                {
                    series.Points.AddXY(x + step, y);
                }
            }

            return series;
        }

        public double CalcRightRectanglesSquare()
        {
            double area = 0;

            for (double x = lim1; x <= lim2; x += step)
            {
                double y = Func(x + step);

                area += y * step;   //правых прямоугольников right rectangle

            }

            return area;
        }

        public Series CalcRightRectanglesDots()
        {
            Series series = new Series();

            for (double x = lim1; x <= lim2; x += step)
            {
                double y = Func(x + step);

                series.Points.AddXY(x, y);
                if (x + step <= lim2)
                {
                    series.Points.AddXY(x + step, y);
                }
            }

            return series;
        }

        public double CalcTrapezoidSquare()
        {
            double area = 0;

            for (double x = lim1; x <= lim2; x += step)
            {
                double y = Func(x);

                area += step * (Func(x) + Func(x + step)) / 2;   //трапеций trapezoid

            }

            return area;
        }

        public Series CalcTrapezoidDots()
        {
            Series series = new Series();

            for (double x = lim1; x <= lim2; x += step)
            {
                double y = Func(x);

                series.Points.AddXY(x, y);

            }

            return series;
        }

        public Series CalcIntegralDots()
        {
            Series series = new Series();

            for(double i = lim1; i <= lim2; i += step)
            {
                double x = i;
                double y = Func(i);

                series.Points.AddXY(x, y);
            }

            return series;
        }

    }
}
