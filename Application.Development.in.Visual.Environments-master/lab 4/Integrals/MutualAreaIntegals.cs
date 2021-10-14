using lab_4.Integrals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab_4
{
    public class MutualAreaIntegals : MegaIntegral
    {
        public MutualAreaIntegals(ref Chart chart,
            string ser1name, Func func1,
            string ser2name, Func func2,
            double f1bottom, double f1top, double f1step,
            double f2bottom, double f2top, double f2step) : base(ref chart)
        {
            if (f1bottom > f2bottom)
            {
                Bottom = f1bottom;
            }
            else
            {
                Bottom = f2bottom;
            }

            if (f1top < f2top)
            {
                Top = f1top;
            }
            else
            {
                Top = f2top;
            }

            SerName1 = ser1name;
            SerName2 = ser2name;

            Func1 = func1;
            Func2 = func2;

            Step1 = f1step;
            Step2 = f2step;
        }

        /// <summary>
        /// Шаг первой функции.
        /// </summary>
        public double Step1 { get; set; }
        /// <summary>
        /// Шаг второй функции.
        /// </summary>
        public double Step2 { get; set; }

        /// <summary>
        /// Имя серии на которой будет отрисовываться первая функция.
        /// </summary>
        public string SerName1 { get; set; }
        /// <summary>
        /// Имя серии на которой будет отрисовываться вторая функция.
        /// </summary>
        public string SerName2 { get; set; }

        /// <summary>
        /// Функция по которой будет отрисовываться общая площадь первой функции.
        /// </summary>
        public Func Func1 { get; set; }
        /// <summary>
        /// Функция по которой будет отрисовываться общая площадь второй функции.
        /// </summary>
        public Func Func2 { get; set; }

        
        /// <summary>
        /// Рисует общую площадь двух функций.
        /// </summary>
        public void DrawMutualArea()
        {
            NameOfSeries = SerName1;
            Function = Func1;
            Step = Step1;
            DrawFunc();

            NameOfSeries = SerName2;
            Function = Func2;
            Step = Step2;
            DrawFunc();
        }


        /// <summary>
        /// Возвращает общуюю площадь методом левых прямоугольников.
        /// </summary>
        /// <returns></returns>
        public double GetLRSquare()
        {
            double answer = 0;
            SetModLEFT_RECTANGLE_METHOD();

            NameOfSeries = SerName1;
            Function = Func1;
            Step = Step1;
            answer += CalcArea();

            NameOfSeries = SerName2;
            Function = Func2;
            Step = Step2;
            answer += CalcArea();

            return answer;
        }

        /// <summary>
        /// Возвращает общуюю площадь методом средних прямоугольников.
        /// </summary>
        /// <returns></returns>
        public double GetMRSquare()
        {
            SetModMIDDLE_RECTANGLE_METHOD();
            double answer = 0;

            NameOfSeries = SerName1;
            Function = Func1;
            Step = Step1;
            answer += CalcArea();

            NameOfSeries = SerName2;
            Function = Func2;
            Step = Step2;
            answer += CalcArea();

            return answer;
        }

        /// <summary>
        /// Возвращает общуюю площадь методом правых прямоугольников.
        /// </summary>
        /// <returns></returns>
        public double GetRRSquare()
        {
            SetModRIGHT_RECTANGLE_METHOD();
            double answer = 0;

            NameOfSeries = SerName1;
            Function = Func1;
            Step = Step1;
            answer += CalcArea();

            NameOfSeries = SerName2;
            Function = Func2;
            Step = Step2;
            answer += CalcArea();

            return answer;
        }


        /// <summary>
        /// Возвращает общуюю площадь методом трапеций.
        /// </summary>
        /// <returns></returns>
        public double GetTRSquare()
        {
            SetModTRAPEZOID_METHOD();
            double answer = 0;

            NameOfSeries = SerName1;
            Function = Func1;
            Step = Step1;
            answer += CalcArea();

            NameOfSeries = SerName2;
            Function = Func2;
            Step = Step2;
            answer += CalcArea();

            return answer;
        }
    }

}
