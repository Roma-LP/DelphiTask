using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab_4
{
    public class Integral
    {
        /// <summary>
        /// Переччисление доступных режимов работы.
        /// </summary>
        private enum Mods { USUAL, LEFT_RECTANGLE_METHOD, MIDDLE_RECTANGLE_METHOD, RIGHT_RECTANGLE_METHOD, TRAPEZOID_METHOD }

        /// <summary>
        /// Текущий режим рисованя.
        /// </summary>
        private Mods Mod = Mods.TRAPEZOID_METHOD;

        /// <summary>
        /// Тип функции по которой рисуется график.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        //public delegate double Func(double x);



        #region Выбор режима рисования

        /// <summary>
        /// Устанавливает отображение функции в обычный режим.
        /// </summary>
        public void SetModUSUAL() => Mod = Mods.USUAL;

        /// <summary>
        /// Устанавливает отображение функции в режим левых прямоугольников.
        /// </summary>
        public void SetModLEFT_RECTANGLE_METHOD() => Mod = Mods.LEFT_RECTANGLE_METHOD;

        /// <summary>
        /// Устанавливает отображение функции в режим средних прямоугольников.
        /// </summary>
        public void SetModMIDDLE_RECTANGLE_METHOD() => Mod = Mods.MIDDLE_RECTANGLE_METHOD;

        /// <summary>
        /// Устанавливает отображение функции в режим правых прямоугольников.
        /// </summary>
        public void SetModRIGHT_RECTANGLE_METHOD() => Mod = Mods.RIGHT_RECTANGLE_METHOD;

        /// <summary>
        /// Устанавливает отображение функции в трапеций.
        /// </summary>
        public void SetModTRAPEZOID_METHOD() => Mod = Mods.TRAPEZOID_METHOD;

        #endregion

        #region Поля класса

        /// <summary>
        /// Поле нижнего предела интеграла.
        /// </summary>
        private double bottom;

        /// <summary>
        /// Поле верхнего предела интеграла.
        /// </summary>
        private double top;

        /// <summary>
        /// Поле шага интеграла.
        /// </summary>
        private double step;


        #endregion

        #region Геттеры и сетторы класса

        /// <summary>
        /// Нижний предел интеграла.
        /// </summary>
        public double Bottom { get => bottom; set => bottom = value; }

        /// <summary>
        /// Верхний предел интеграла.
        /// </summary>
        public double Top { get => top; set => top = value; }

        /// <summary>
        /// Поле шага интеграла.
        /// </summary>
        public double Step { get => step; set => step = value; }

        /// <summary>
        /// Указатель на редактируемый chart.
        /// </summary>
        private Chart chart;
        public Chart Chart { get => chart; set => chart = value; }

        /// <summary>
        /// Имя серии в chart.
        /// </summary>
        public string NameOfSeries { get; set; }

        /// <summary>
        /// Указатель на функцию.
        /// </summary>
        //public Func Function { get; set; }


        #endregion



        public Integral(ref Chart chartRef)
        {
            chart = chartRef;
        }

        public Integral(ref Chart chartRef, string nameOfSeries, /*Func Function,*/ double bottom, double top, double step)
        {
            chart = chartRef;

            chart.Series[nameOfSeries].Points.Clear();

            NameOfSeries = nameOfSeries;

            this.bottom = bottom;
            this.top = top;
            this.step = step;
            //this.Function = Function;
        }

        public virtual double StaticFunction(double x) => Math.Sin(x);

        #region Вычисление точек


        private List<DataPoint> GetFuncDots()
        {
            List<DataPoint> points = new List<DataPoint>();

            switch (Mod)
            {
                case Mods.LEFT_RECTANGLE_METHOD:
                    {
                        for (double x = bottom; x <= top; x += step)
                        {
                            double y = StaticFunction(x);

                            points.Add(new DataPoint(x, y));
                            if (x + step <= top)
                            {
                                points.Add(new DataPoint(x + step, y));
                            }
                        }
                        break;
                    }

                case Mods.MIDDLE_RECTANGLE_METHOD:
                    {
                        for (double x = bottom; x <= top; x += step)
                        {
                            double y = StaticFunction(x + step / 2);

                            points.Add(new DataPoint(x, y));
                            if (x + step <= top)
                            {
                                points.Add(new DataPoint(x + step, y));
                            }
                        }
                        break;
                    }

                case Mods.RIGHT_RECTANGLE_METHOD:
                    {
                        for (double x = bottom; x <= top; x += step)
                        {
                            double y = StaticFunction(x + step);

                            points.Add(new DataPoint(x, y));
                            if (x + step <= top)
                            {
                                points.Add(new DataPoint(x + step, y));
                            }
                        }

                        break;
                    }

                case Mods.TRAPEZOID_METHOD:
                    {
                        for (double x = bottom; x <= top; x += step)
                        {
                            double y = StaticFunction(x);

                            points.Add(new DataPoint(x, y));

                        }
                        break;
                    }

                default:
                    break;
            }
            return points;
        }
        #endregion

        #region Рисование функции
        /// <summary>
        /// Отрисовывает Функцию на заданной серии
        /// </summary>
        /// <returns></returns>
        public bool DrawFunc()
        {
            if (bottom < top && step != 0)  //защита от зацикливания
            {
                chart.Series[NameOfSeries].Points.Clear();

                List<DataPoint> points = GetFuncDots();

                foreach (DataPoint point in points)
                {
                    chart.Series[NameOfSeries].Points.AddXY(point.XValue, point.YValues[0]);
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region Вычисление площади

        public double CalcArea()
        {
            double area = 0;

            switch (Mod)
            {
                case Mods.LEFT_RECTANGLE_METHOD:
                    {

                        for (double x = bottom; x <= top; x += step)
                        {
                            double y = Math.Abs(StaticFunction(x));
                            area += y * step;
                        }

                        break;
                    }

                case Mods.MIDDLE_RECTANGLE_METHOD:
                    {
                        for (double x = bottom; x <= top; x += step)
                        {
                            double y = StaticFunction(x + step / 2);

                            area += y * step;
                        }

                        break;
                    }

                case Mods.RIGHT_RECTANGLE_METHOD:
                    {
                        for (double x = bottom; x <= top; x += step)
                        {
                            double y = StaticFunction(x + step);

                            area += y * step;

                        }

                        break;
                    }

                case Mods.TRAPEZOID_METHOD:
                    {
                        for (double x = bottom; x <= top; x += step)
                        {
                            double y = StaticFunction(x);

                            area += step * (StaticFunction(x) + StaticFunction(x + step)) / 2;

                        }

                        break;
                    }
            }

            return area;
        }
        #endregion
    }
}
