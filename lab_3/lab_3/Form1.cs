using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Нахождение факториала
        private double Fact(double n) {
            double res = 1;
            for (;n > 0; n--) res *= n;
            return res;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                double x0 = double.Parse(x0_box.Text);
                double xk = double.Parse(xk_box.Text);
                int m = int.Parse(m_box.Text);
                int N = int.Parse(N_box.Text);

                // Да, это ошибка
                if (x0 >= xk) throw new Exception();

                double h = (xk - x0) / (double)m; // Это наш шаг функций

                // Очищаем поле результата
                resBox.Text = "";

                // считаем значение функции от и разложения x0 до xk
                for (double x = x0; x < xk; x += h)
                {
                    // Просто считаем
                    double reg = Math.Sin(x);

                    // Считаем по разложению
                    double distr = 0.0;
                    for (int n = 0; n < N; n++)
                    {
                        distr += Math.Pow(-1, n) * (Math.Pow(x, 2 * n + 1) / Fact(2 * n + 1));
                    }

                    // Выводим
                    resBox.Text += String.Format("x={0:F2} f(x)={1:F7} g(x)={2:F7}", x, reg, distr) + Environment.NewLine;
                }
            } catch
            {
                resBox.Text = "Неправильно введены данные";
            }
        }
    }
}
