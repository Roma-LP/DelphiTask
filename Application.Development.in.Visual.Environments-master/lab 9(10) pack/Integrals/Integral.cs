using Lab15.Functions;
using OxyPlot;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Lab15.Integrals
{
    public enum CastMethod
    {
        Trapeze,
        LeftRect,
        RightRect,
        MiddleRect
    }

    public class Integral : INotifyPropertyChanged
    {
        #region Property Bottom    - Нижний предел интегрирования
        internal int _bottom;
        public int Bottom
        {
            get => _bottom;
            set
            {
                _bottom = value;
                OnPropertyChanged("Bottom");
                UpdateData();
            }
        }
        #endregion

        #region Property Top       - Верхний предел интегрирования
        internal int _top;
        public int Top
        {
            get => _top;
            set
            {
                _top = value;
                OnPropertyChanged("Top");
                UpdateData();
            }
        }
        #endregion

        #region Property Steps     - Количество шагов
        internal int _steps;
        public int Steps
        {
            get => _steps;
            set
            {
                _steps = value;
                OnPropertyChanged("Steps");
                UpdateData();
            }
        }
        #endregion

        #region Property Answer    - Решение интеграла
        internal double _answer;
        public double Answer
        {
            get => _answer;
            internal set
            {
                _answer = value;
                OnPropertyChanged("Answer");
            }
        }
        #endregion

        /// <summary>
        /// Функция интеграла: f(x)
        /// </summary>
        public virtual double Function(double x) => x;
        public string Title { get; set; } // Задает текст в визуальном отображении
        
        public ObservableCollection<DataPoint> Points { get; private set; } // Область построения графика
        protected Point offset;
                
        public CastMethod CastMethod { get; set; }

        public Integral()
        {
            Points = new ObservableCollection<DataPoint>();
            Bottom = 0;
            Top = 1;
            Steps = 10;
        }

        /// <summary>
        /// Инициализация интеграла
        /// </summary>
        /// <param name="bottom">Нижний предел</param>
        /// <param name="top">Верхний предел</param>
        /// <param name="steps">Количество шагов</param>
        public Integral(int bottom, int top, int steps) : this()
        {
            Refresh(bottom, top, steps);
        }

        /// <summary>
        /// Обновление переменных интеграла
        /// </summary>
        /// <param name="bottom">Нижний предел</param>
        /// <param name="top">Верхний предел</param>
        /// <param name="steps">Количество шагов</param>
        public void Refresh(int bottom, int top, int steps)
        {
            Bottom = bottom;
            Top = top;
            Steps = steps;
            Cast();
        }

        /// <summary>
        /// Решение интеграла, oбновление области построения графика
        /// </summary>
        /// <returns>Возвращает решение заданного интеграла</returns>
        public virtual double Cast()
        {
            switch (CastMethod)
            {
                case CastMethod.LeftRect:
                    return CastLeftRect();
                case CastMethod.RightRect:
                    return CastRightRect();
                case CastMethod.MiddleRect:
                    return CastMiddleRect();
            }

            return CastTrapeze();
        }

        /// <summary>
        /// Решение методом левых прямоугольников
        /// </summary>
        /// <returns>Возвращает решение заданного интеграла методом левых прямоугольников</returns>
        public double CastLeftRect()
        {
            Answer = 0;
            Points.Clear();

            double x = _bottom;
            int step = 1;
            double dx = _top - _bottom;
            dx /= _steps;

            while (step <= _steps)
            {
                Answer += dx * Function(x);
                Points.Add(new DataPoint(x, offset.Y + Function(offset.X + x + dx)));
                Points.Add(new DataPoint(x + dx, offset.Y + Function(offset.X + x + dx)));
                Points.Add(new DataPoint(x + dx, offset.Y + Function(offset.X + x + 2 * dx)));
                x += dx;
                step++;
            }
            return Answer;
        }

        /// <summary>
        /// Решение методом средних прямоугольников
        /// </summary>
        /// <returns>Возвращает решение заданного интеграла методом средних прямоугольников</returns>
        public double CastMiddleRect()
        {
            Answer = 0;
            Points.Clear();

            double x = _bottom;
            int step = 1;
            double dx = _top - _bottom;
            dx /= _steps;
            while (step <= _steps)
            {
                Answer += dx * Function(x + dx / 2);
                Points.Add(new DataPoint(x, offset.Y + Function(offset.X + x + dx / 2)));
                Points.Add(new DataPoint(x + dx, offset.Y + Function(offset.X + x + dx / 2)));
                Points.Add(new DataPoint(x + dx, offset.Y + Function(offset.X + x + dx)));
                x += dx;
                step++;
            }
            return Answer;
        }

        /// <summary>
        /// Решение методом правых прямоугольников
        /// </summary>
        /// <returns>Возвращает решение заданного интеграла методом правых прямоугольников</returns>
        public double CastRightRect()
        {
            Answer = 0;
            Points.Clear();

            double x = _bottom;
            int step = 1;
            double dx = _top - _bottom;
            dx /= _steps;
            while (step <= _steps)
            {
                Answer += dx * Function(x + dx);
                Points.Add(new DataPoint(x, offset.Y + Function(offset.X + x)));
                Points.Add(new DataPoint(x + dx, offset.Y + Function(offset.X + x)));
                Points.Add(new DataPoint(x + dx, offset.Y + Function(offset.X + x + dx)));
                x += dx;
                step++;
            }
            return Answer;
        }

        /// <summary>
        /// Решение методом трапеций
        /// </summary>
        /// <returns>Возвращает решение заданного интеграла методом трапеций</returns>
        public double CastTrapeze()
        {
            Answer = 0;
            Points.Clear();

            double dx = _top - _bottom;
            dx /= _steps;

            for (double x = _bottom; x < _top; x += dx)
            {
                Answer += dx * (Function(x) + Function(x + dx)) / 2;
                Points.Add(new DataPoint(x, offset.Y + Function(offset.X + x)));
            }

            Points.Add(new DataPoint(_top, offset.Y + Function(offset.X + _top)));
            return Answer;
        }

        private void UpdateData()
        {
            Cast();
            DataChanged?.Invoke(this, new RoutedEventArgs());
        }

        public event RoutedEventHandler DataChanged;
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        #endregion
    }
}
