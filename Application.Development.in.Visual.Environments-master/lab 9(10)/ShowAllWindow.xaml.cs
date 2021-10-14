using Lab15.Integrals;
using System.Collections.Generic;
using System.Windows;

namespace Lab4
{
    /// <summary>
    /// Логика взаимодействия для ShowAllWindow.xaml
    /// </summary>
    public partial class ShowAllWindow : Window
    {
        public ShowAllWindow(IEnumerable<Integral> integrals)
        {
            InitializeComponent();
            foreach (var integral in integrals)
            {
                PART_PLOT.Series.Add(new OxyPlot.Wpf.LineSeries() { Title = integral.Title, ItemsSource = integral.Points });
            }
        }
    }
}
