using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW_08
{
    public partial class LW_08 : Form
    {
        public LW_08()
        {
            InitializeComponent();
        }

        private void BT_Start_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(text_box_y.Text, out double y)) return;
            if (!double.TryParse(text_box_z.Text, out double z)) return;
            if (!double.TryParse(from.Text, out double fromPos)) return;
            if (!double.TryParse(to.Text, out double toPos)) return;
            if (!double.TryParse(Step.Text, out double step)) return;

            MainChart.Series[0].Points.Clear();
            ResultBox.Items.Clear();

            for (double i = fromPos,j=1; i <= toPos; i += step,j++)
            {
                ResultBox.Items.Add(string.Format("{0,2}) x={1,6}  U(x)={2}",j,i, Func(i, y, z)));
                MainChart.Series[0].Points.AddXY(i, Func(i, y, z));
            }
        }
        private double Func(double x, double y, double z)
        {
            double a, b, c;
            a = Math.Pow(8 + Math.Pow(Math.Abs(x - y), 2) + 1, 1 / 3);   // Abs  модуль числа
            b = Math.Pow(x, 2) + Math.Pow(y, 2) + 2;  // Pow степень
            c = Math.Exp(Math.Abs(x - y)) * Math.Pow((Math.Pow(Math.Tan(z), 2) + 1), x);  // Exp exonent
            return a / b - c;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
