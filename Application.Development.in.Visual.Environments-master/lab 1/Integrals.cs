using System;

namespace lab_1
{
    class Integrals
    {
        public enum Mods { LEFT_RECTANGLE_METHOD, MIDDLE_RECTANGLE_METHOD, RIGHT_RECTANGLE_METHOD, TRAPEZOID_METHOD }

        public static double Func(double x)
        {
            return Math.Sin(x)/Math.Pow(x, 0.5);
        }

        public static double CalcAndDraw(double lim1, double lim2, double step, Mods mod,
            ref System.Windows.Forms.DataVisualization.Charting.Chart chart1)
        {
            double area = 0;
            chart1.Series[0].Points.Clear();
            double y;

            for (double x = lim1; x <= lim2; x += step)
            {
                switch (mod)
                {
                    case Mods.LEFT_RECTANGLE_METHOD:
                        {
                            y = Func(x);

                            chart1.Series[0].Points.AddXY(x, y);
                            if (x + step <= lim2)
                            {
                                chart1.Series[0].Points.AddXY(x + step, y);
                            }

                            area += y * step;          //левых прямоугольников left rectangle
                            break;
                        }
                    case Mods.MIDDLE_RECTANGLE_METHOD:
                        {
                            y = Func(x + step / 2);

                            chart1.Series[0].Points.AddXY(x, y);
                            if (x + step <= lim2)
                            {
                                chart1.Series[0].Points.AddXY(x + step, y);
                            }

                            area += y * step;   //средних прямоугольников middle rectangle
                            break;
                        }
                    case Mods.RIGHT_RECTANGLE_METHOD:
                        {
                            y = Func(x + step);

                            chart1.Series[0].Points.AddXY(x, y);
                            if (x + step <= lim2)
                            {
                                chart1.Series[0].Points.AddXY(x + step, y);
                            }

                            area +=  y * step;   //правых прямоугольников right rectangle
                            break;
                        }
                    case Mods.TRAPEZOID_METHOD:
                        {
                            y = Func(x);

                                chart1.Series[0].Points.AddXY(x, y);

                            area += step*(Func(x) + Func(x + step)) / 2;   //трапеций trapezoid
                            break;
                        }
                }
            }
            return area;
        }

        public static void DrawIntegral(ref System.Windows.Forms.DataVisualization.Charting.Chart chart1,
            double lim1, double lim2, double step)
        {
            int counter = 0;
            chart1.Series[1].Points.Clear();

            for (double i = lim1; i <= lim2 && counter < short.MaxValue; i += step)
            {
                double x = i;
                double y = Func(i);

                chart1.Series[1].Points.AddXY(x, y);

                counter++;
            }
        }
    }
}
