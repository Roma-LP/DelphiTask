using Lab15.Integrals;
using Lab4.Integrals;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PART_firstIntegral.Integrals = new ObservableCollection<Integral>() {
                new IntegralX2(),
                new IntegralX3(),
                new IntegralEX(),
                new IntegralE2X(),
                new IntegralModX()
            };

            PART_secondIntegral.Integrals = new ObservableCollection<Integral>() {
                new IntegralX2(),
                new IntegralX3(),
                new IntegralEX(),
                new IntegralE2X(),
                new IntegralModX()
            };
        }

        private void TextBlock_TargetUpdated(object sender, DataTransferEventArgs e)
        {
            try
            {
                double sum = PART_firstIntegral.SelectedIntegral.Answer
                    + PART_secondIntegral.SelectedIntegral.Answer;


                double sub = PART_firstIntegral.SelectedIntegral.Answer
                    - PART_secondIntegral.SelectedIntegral.Answer;

                tb_sum.Text = $"Сумма: {sum}";
                tb_sub.Text = $"Разность (1-2): {sub}";
                tb_sub2.Text = $"Разность (2-1): {-sub}";
            }
            catch
            {
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new ShowAllWindow(PART_firstIntegral.Integrals).ShowDialog();
        }
    }
}
