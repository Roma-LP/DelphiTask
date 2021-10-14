using Lab15.Functions;
using OxyPlot;

namespace Lab15.Integrals
{
    public class TrapezeIntegral : Integral
    {
        public TrapezeIntegral() : base(0, 0, 0)
        {
        }
        public TrapezeIntegral(int bottom, int top, int steps) : base(bottom, top, steps)
        {
        }

        /// <summary>
        /// Решение методом трапеций
        /// </summary>
        /// <returns>Возвращает решение заданного интеграла методом трапеций</returns>
        public override double Cast() => CastTrapeze();
    }
}
