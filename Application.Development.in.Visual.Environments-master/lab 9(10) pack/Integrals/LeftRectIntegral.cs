using Lab15.Functions;
using OxyPlot;

namespace Lab15.Integrals
{
    public class LeftRectIntegral : Integral
    {
        public LeftRectIntegral() : base(0, 0, 0)
        {

        }
        public LeftRectIntegral(int bottom, int top, int steps) : base(bottom, top, steps)
        {
        }

        /// <summary>
        /// Решение методом левых прямоугольников
        /// </summary>
        /// <returns>Возвращает решение заданного интеграла методом левых прямоугольников</returns>
        public override double Cast() => CastLeftRect();
    }
}
