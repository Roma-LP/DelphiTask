using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab_5
{
    abstract class Father
    {
        private double startX;  //левая граница
        private double endX;    //правая граница
        private double eps;     //точность
        private Chart chart;    //элемент рисования

        public Father(double startX, double endX, double eps, Chart chart)
        {
            this.startX = startX;
            this.endX = endX;
            this.eps = eps;
            this.chart = chart;
        }

        public double StartX { get => startX; set => startX = value; }
        public double EndX { get => endX; set => endX = value; }
        public double Eps { get => eps; set => eps = value; }

        public double methodMid()
        {
            draw();

            chart.Series["Tracker"].Points.Clear();
            chart.Series["TrackerDots"].Points.Clear();
            int iter = 0;

            // Точность.
            double accuracy = eps;
            // Интервал поиска.
            double min = startX;
            double max = endX;
            // Длина интервала.
            var length = max - min;
            // Начальная ошибка.
            var err = length;
            // Корень.
            double x = 0;
            while (err > accuracy && func(x) != 0)
            {
                // Вычисляем середину интервала.
                x = (min + max) / 2;
                // Найдём новый интервал, в котором функция меняет знак.
                if (func(min) * func(x) < 0)
                {
                    max = x;
                }
                else if (func(x) * func(max) < 0)
                {
                    min = x;
                }
                // Вычисляем новую ошибку.
                err = (max - min) / length;

                chart.Series["Tracker"].Points.AddXY(x, 0);
                chart.Series["TrackerDots"].Points.AddXY(x, 0);
                chart.Series["Tracker"].Points.AddXY(x, func(x));
                chart.Series["TrackerDots"].Points.AddXY(x, func(x));
                iter++;
                chart.Series["Func"].LegendText = $"Func(Шаг №:{iter})";
                chart.Update();

                System.Threading.Thread.Sleep(500);


            }

            return x;

        }

        public double methodIter()
        {
            draw();

            chart.Series["Tracker"].Points.Clear();
            chart.Series["TrackerDots"].Points.Clear();

            double x0 = 0, x = 0;
            int iter = 0;
            bool error = false;

            do
            {
                x = iterFunc(x0);
                iter++;
                if (Math.Abs(x - x0) >= eps && iter == 1000)
                {
                    error = true;
                    break;
                }

                chart.Series["Tracker"].Points.AddXY(x, 0);
                chart.Series["TrackerDots"].Points.AddXY(x, 0);
                chart.Series["Tracker"].Points.AddXY(x, iterFunc(x));
                chart.Series["TrackerDots"].Points.AddXY(x, iterFunc(x));
                iter++;
                chart.Series["Func"].LegendText = $"Func(Шаг №:{iter})";

                chart.Update();
                System.Threading.Thread.Sleep(10);
                Console.WriteLine(x);
                x0 = x;
            } while (Math.Abs(x0 - iterFunc(x0)) > eps);
            if (error)
            {
                Console.WriteLine("Не найдено");
            }
            else
            {
                Console.WriteLine("Ответ: X = {0} ", Math.Round(x, 3));
                Console.WriteLine("Итераций пройдено: {0}", iter);
            }

            return x;
        }

        public double methodNuton()
        {
            draw();
            chart.Series["Tracker"].Points.Clear();
            chart.Series["TrackerDots"].Points.Clear();

            double x = (endX - startX)/2;

            int iter = 0;

            while (Math.Abs(func(x))>eps)
            {
                x -= func(x) / diffFunc(x);
                chart.Series["Tracker"].Points.AddXY(x,0);
                chart.Series["TrackerDots"].Points.AddXY(x,0);
                chart.Series["Tracker"].Points.AddXY(x,func(x));
                chart.Series["TrackerDots"].Points.AddXY(x,func(x));
                iter++;
                chart.Series["Func"].LegendText = $"Func(Шаг №:{iter})";

                chart.Update();
                System.Threading.Thread.Sleep(1000);
                //x += dx; 
            }
            return x;
            
        }

        public void draw()
        {
            
            chart.Series["Func"].Points.Clear();
            double dx = 0.0001;
            for (double x = startX; x < endX; x += dx)
            {
                chart.Series["Func"].Points.AddXY(x, func(x));
            }
        }

        abstract public double func(double x);
        abstract public double diffFunc(double x);
        abstract public double iterFunc(double x);
        
    }
}
