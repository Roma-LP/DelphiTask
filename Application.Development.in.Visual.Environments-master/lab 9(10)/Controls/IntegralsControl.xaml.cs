using Lab15.Integrals;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Lab4.Controls
{
    /// <summary>
    /// Interaction logic for IntegralsControl.xaml
    /// </summary>
    public partial class IntegralsControl : UserControl
    {

        #region IntegralTitle
        public string IntegralTitle
        {
            get { return (string)GetValue(IntegralTitleProperty); }
            set { SetValue(IntegralTitleProperty, value); }
        }

        public static readonly DependencyProperty IntegralTitleProperty =
            DependencyProperty.Register("IntegralTitle", typeof(string), typeof(IntegralsControl), new PropertyMetadata("Подынтегральная функция"));
        #endregion

        #region MethodTitle
        public string MethodTitle
        {
            get { return (string)GetValue(MethodTitleProperty); }
            set { SetValue(MethodTitleProperty, value); }
        }

        public static readonly DependencyProperty MethodTitleProperty =
            DependencyProperty.Register("MethodTitle", typeof(string), typeof(IntegralsControl), new PropertyMetadata("Метод вычислений"));
        #endregion

        #region BordersTitle
        public string BordersTitle
        {
            get { return (string)GetValue(BordersTitleProperty); }
            set { SetValue(BordersTitleProperty, value); }
        }

        public static readonly DependencyProperty BordersTitleProperty =
            DependencyProperty.Register("BordersTitle", typeof(string), typeof(IntegralsControl), new PropertyMetadata("Границы интеграла"));
        #endregion

        #region SelectedIntegral
        private Integral oldIntegral;
        public Integral SelectedIntegral
        {
            get => (Integral)GetValue(SelectedIntegralProperty);
            set => SetValue(SelectedIntegralProperty, value);
        }

        public static readonly DependencyProperty SelectedIntegralProperty =
            DependencyProperty.Register("SelectedIntegral", typeof(Integral), typeof(IntegralsControl));
        #endregion

        #region Top
        public double Top
        {
            get { return (double)GetValue(TopProperty); }
            set { SetValue(TopProperty, value); }
        }

        public static readonly DependencyProperty TopProperty =
            DependencyProperty.Register("Top", typeof(double), typeof(IntegralsControl));
        #endregion

        #region Bottom
        public double Bottom
        {
            get { return (double)GetValue(BottomProperty); }
            set { SetValue(BottomProperty, value); }
        }

        public static readonly DependencyProperty BottomProperty =
            DependencyProperty.Register("Bottom", typeof(double), typeof(IntegralsControl));
        #endregion

        #region Steps
        public double Steps
        {
            get { return (double)GetValue(StepsProperty); }
            set { SetValue(StepsProperty, value); }
        }

        public static readonly DependencyProperty StepsProperty =
            DependencyProperty.Register("Steps", typeof(double), typeof(IntegralsControl));
        #endregion


        public ObservableCollection<Integral> Integrals { get; set; }

        public IntegralsControl()
        {
            InitializeComponent();

            DataContext = this;
        }

        private void ListBox_Loaded(object sender, RoutedEventArgs e)
        {
            SelectedIntegral = Integrals?.FirstOrDefault();
        }

        private void tr_Selected(object sender, RoutedEventArgs e)
        {
            if (SelectedIntegral != null)
            {
                SelectedIntegral.CastMethod = CastMethod.Trapeze;
                SelectedIntegral.Cast();
            }
        }

        private void lr_Selected(object sender, RoutedEventArgs e)
        {
            if (SelectedIntegral != null)
            {
                SelectedIntegral.CastMethod = CastMethod.LeftRect;
                SelectedIntegral.Cast();
            }
        }
        
        private void rr_Selected(object sender, RoutedEventArgs e)
        {
            if (SelectedIntegral != null)
            {
                SelectedIntegral.CastMethod = CastMethod.RightRect;
                SelectedIntegral.Cast();
            }
        }
        
        private void mr_Selected(object sender, RoutedEventArgs e)
        {
            if (SelectedIntegral != null)
            {
                SelectedIntegral.CastMethod = CastMethod.MiddleRect;
                SelectedIntegral.Cast();
            }
        }
                
        private void IntegralSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (oldIntegral != null)
            {
                SelectedIntegral.CastMethod = oldIntegral.CastMethod;
                SelectedIntegral.Top = oldIntegral.Top;
                SelectedIntegral.Bottom = oldIntegral.Bottom;
                SelectedIntegral.Steps = oldIntegral.Steps;
            }

            oldIntegral = SelectedIntegral;
        }

    }
}
