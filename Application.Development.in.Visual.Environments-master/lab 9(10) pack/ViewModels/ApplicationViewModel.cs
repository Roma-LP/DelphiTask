using Lab15.Functions;
using Lab15.Integrals;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Lab15.ViewModels
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private const int LINE_ACCURACY = 600; //Точтость построения линии графика f(x)

        #region Property State     - Обновление графика при изменении состояния окна
        private WindowState _state = WindowState.Normal;   
        public WindowState State    
        {
            get => _state;
            set
            {
                _state = value;
                Cast();
                OnPropertyChanged("State");
            }
        }
        #endregion

        #region Property SelectedIntegral    - Выбранный интеграл
        private Integral _selectedIntegral;
        public Integral SelectedIntegral
        {
            get => _selectedIntegral;
            set
            {
                _selectedIntegral = value;
                Cast();
                OnPropertyChanged("SelectedIntegral");
            }
        }
        #endregion

        #region Property Bottom    - Нижний предел интегрирования
        private int _bottom = 0;
        public int Bottom
        {
            get => _bottom;
            set
            {
                _bottom = value;
                Cast();
                OnPropertyChanged("Bottom");
            }
        }
        #endregion

        #region Property Top       - Верхний предел интегрирования
        private int _top = 1;
        public int Top
        {
            get => _top;
            set
            {
                _top = value;
                Cast();
                OnPropertyChanged("Top");
            }
        }
        #endregion

        #region Property Steps     - Количество шагов
        private int _steps = 10;
        public int Steps
        {
            get => _steps;
            set
            {
                _steps = value;
                Cast();
                OnPropertyChanged("Steps");
            }
        }
        #endregion

        public Integral Line { get; set; } // Линия функции f(x)
        public string LaTeX
        {
            get => @"f\left(x\right)=\int_{" + _bottom.ToString() + "}^{" + _top.ToString() + @"}e^{-0.5x^2+2x}\cos(x)dx=" + _selectedIntegral.Answer.ToString();
        } // Интерактивная формула интеграла
        public ObservableCollection<Integral> Integrals { get; set; } // Колекция интегралов разных типов

        public ApplicationViewModel()
        {
            // Добавление интегралов в колекцию (инициализация) 
            Line = new TrapezeIntegral(_bottom, _top, _steps);
            Integrals = new ObservableCollection<Integral>
            {
                new TrapezeIntegral(_bottom, _top, _steps) { Title = "Метод трапеций" },
                new LeftRectIntegral(_bottom, _top, _steps) { Title = "Метод левых прямоугольников" },
                new RightRectIntegral(_bottom, _top, _steps) { Title = "Метод правых прямоугольников" },
                new MiddleRectIntegral(_bottom, _top, _steps) { Title = "Метод средних прямоугольников" }
            };
            SelectedIntegral = Integrals[0];
        }

        /// <summary>
        /// Решение интеграла, обновление точек графика.
        /// </summary>
        public void Cast()
        {
            _selectedIntegral.Refresh(_bottom, _top, _steps);
            Line.Refresh(_bottom, _top, LINE_ACCURACY);
            OnPropertyChanged("LaTeX");
        }


        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        #endregion
    }
}
