using System;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab_3
{
    public class FatherOfIntegrals
    {
        /// <summary>
        /// Переччисление доступных режимов работы
        /// </summary>
        private enum Mods { USUAL, LEFT_RECTANGLE_METHOD, MIDDLE_RECTANGLE_METHOD, RIGHT_RECTANGLE_METHOD, TRAPEZOID_METHOD }

        private Mods Mod = Mods.USUAL;

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

        private double bottom; //нижний предел интегрированя
        private double top; //верхний предел интергирования
        private double step;    //шаг интегрированя

        /// <summary>
        /// Поле нижнего предела функции.
        /// </summary>
        public double Bottom { get; set; }

        /// <summary>
        /// Поле верхнего предела функции.
        /// </summary>
        public double Top { get; set; }

        /// <summary>
        /// Поле шага функции.
        /// </summary>
        public double Step { get; set; }

        private Chart chart; //указатель на редактируемый chart
        private string nameOfSeries; //указатель на редактируемый chart

        #endregion

        public FatherOfIntegrals(ref Chart chartRef, string nameOfSeries)
        {
            chart = chartRef;

            chart.Series[nameOfSeries].Points.Clear();

            this.nameOfSeries = nameOfSeries;
        }

        public FatherOfIntegrals(ref Chart chartRef, string nameOfSeries, double Bottom, double Top, double Step)
        {
            chart = chartRef;

            chart.Series[nameOfSeries].Points.Clear();

            this.nameOfSeries = nameOfSeries;

            this.Bottom = Bottom;
            this.Top = Top;
            this.Step = Step;
        }

        /// <summary>
        /// Функция по которой рисуется график
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public virtual double Function(double x) => x;

        #region Вычисление точек


        private List<DataPoint> GetFuncDots()
        {
            List<DataPoint> points = new List<DataPoint>();

            switch (Mod)
            {
                case Mods.USUAL:
                    {
                        for (double x = Bottom; x <= Top; x += Step)
                        {
                            points.Add(new DataPoint(x, Function(x)));
                        }
                        break;
                    }

                case Mods.LEFT_RECTANGLE_METHOD:
                    {
                        for (double x = Bottom; x <= Top; x += Step)
                        {
                            double y = Function(x);

                            points.Add(new DataPoint(x, y));
                            if (x + Step <= Top)
                            {
                                points.Add(new DataPoint(x + Step, y));
                            }
                        }
                        break;
                    }

                case Mods.MIDDLE_RECTANGLE_METHOD:
                    {
                        for (double x = Bottom; x <= Top; x += Step)
                        {
                            double y = Function(x + Step / 2);

                            points.Add(new DataPoint(x, y));
                            if (x + Step <= Top)
                            {
                                points.Add(new DataPoint(x + Step, y));
                            }
                        }
                        break;
                    }

                case Mods.RIGHT_RECTANGLE_METHOD:
                    {
                        for (double x = Bottom; x <= Top; x += Step)
                        {
                            double y = Function(x + Step);

                            points.Add(new DataPoint(x, y));
                            if (x + Step <= Top)
                            {
                                points.Add(new DataPoint(x + Step, y));
                            }
                        }

                        break;
                    }

                case Mods.TRAPEZOID_METHOD:
                    {
                        for (double x = Bottom; x <= Top; x += Step)
                        {
                            double y = Function(x);

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
            if (Bottom < Top && Step != 0)  //защита от зацикливания
            {
                chart.Series[nameOfSeries].Points.Clear();

                List<DataPoint> points = GetFuncDots();

                foreach (DataPoint point in points)
                {
                    chart.Series[nameOfSeries].Points.AddXY(point.XValue, point.YValues[0]);
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region Вычисление площади разными методами
        /// <summary>
        /// Вычисляет площадь функции, вычисленную методом левых прямоугольников.
        /// </summary>
        /// <returns></returns>
        public double CalcLeftRectanglesSquare()
        {
            double area = 0;

            for (double x = Bottom; x <= Top; x += Step)
            {
                double y = Math.Abs(Function(x));
                area += y * Step;     
            }

            return area;
        }

        /// <summary>
        /// Вычисляет площадь функции, вычисленную методом средних прямоугольников.
        /// </summary>
        /// <returns></returns>
        public double CalcMiddleRectanglesSquare()
        {
            double area = 0;

            for (double x = Bottom; x <= Top; x += Step)
            {
                double y = Function(x + Step / 2);

                area += y * Step;

            }

            return area;
        }

        /// <summary>
        /// Вычисляет площадь функции, вычисленную методом правых прямоугольников.
        /// </summary>
        /// <returns></returns>
        public double CalcRightRectanglesSquare()
        {
            double area = 0;

            for (double x = Bottom; x <= Top; x += Step)
            {
                double y = Function(x + Step);

                area += y * Step;

            }

            return area;
        }

        /// <summary>
        /// Вычисляет площадь функции, вычисленную методом трапеций.
        /// </summary>
        /// <returns></returns>
        public double CalcTrapezoidSquare()
        {
            double area = 0;

            for (double x = Bottom; x <= Top; x += Step)
            {
                double y = Function(x);

                area += Step * (Function(x) + Function(x + Step)) / 2;

            }

            return area;
        }

        #endregion
    }
}