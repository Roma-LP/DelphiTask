using Lab15.Functions;
using OxyPlot;

namespace Lab15.Integrals
{
    public class RightRectIntegral : Integral
    {
        public RightRectIntegral() : base(0, 0, 0)
        {
        }
        public RightRectIntegral(int bottom, int top, int steps) : base(bottom, top, steps)
        { 
        }

        /// <summary>
        /// Решение методом правых прямоугольников
        /// </summary>
        /// <returns>Возвращает решение заданного интеграла методом правых прямоугольников</returns>
        public override double Cast() => CastRightRect();
    }
}
