using System.Windows;

namespace Lab15
{
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        private void Button_Click(object sender, RoutedEventArgs e) => Close();
    }
}
