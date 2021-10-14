using Lab15.Functions;
using OxyPlot;

namespace Lab15.Integrals
{
    delegate int DSome(int z);
    public class MiddleRectIntegral : Integral
    {
        public MiddleRectIntegral() : base(0, 0, 0)
        {
        }
        public MiddleRectIntegral(int bottom, int top, int steps) : base(bottom, top, steps)
        {
        }

        /// <summary>
        /// Решение методом средних прямоугольников
        /// </summary>
        /// <returns>Возвращает решение заданного интеграла методом средних прямоугольников</returns>
        public override double Cast() => CastMiddleRect();
    }
}
