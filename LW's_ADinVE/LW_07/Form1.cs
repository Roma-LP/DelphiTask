using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LW_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Do_Click(object sender, EventArgs e)
        {
            double xn, xk, n, h,Yx,Sx;
            string TypeFunk = "";
            try
            {
                xn = double.Parse(TextBox_xn.Text); // Считывается значение xn
                xk = double.Parse(TextBox_xk.Text); // Считывается значение xk
                if (xn >= xk) throw new Exception("Значение должно быть: X_n < X_k"); 
                n = double.Parse(TextBox_n.Text); // Считывается значение n
                if (!CheckedRadioButton())return;

            }
            catch (FormatException)
            {
                MessageBox.Show("Введены некорректные данные", "Ошибка");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Ошибка");
                return;
            }

            TextBox_Result.Text += "Лa6.раб.№3. Лепеш Р.Д." + "\r\n";                              
            TextBox_Result.Text += "xn = " + TextBox_xn.Text + "\r\n";  // Вывод xn в окно TextBox_Result                                
            TextBox_Result.Text += "xk = " + TextBox_xk.Text + "\r\n";  // Вывод xk в окно TextBox_Result
            TextBox_Result.Text += "n = " + TextBox_n.Text + "\r\n";  // Вывод n в окно TextBox_Result
                                                                      // Вычисляем арифметическое выражение
            h = (xk - xn) / n;  // Высчитываем шаг

            // считаем значение функции от и разложения xn до xk
            for (double i = xn,number=1; i < xk; i += h,number++)
            {
                // Считаем функцию Y(x)
                Yx = Fx(TypeFunk, i);

                // Считаем по разложению S(x)
                Sx = 0.0;
                for (int j = 0; j < n; j++)
                {
                    Sx += (Math.Pow(i,2*j)) / (Fact(2*j));
                }

                // Выводим
                TextBox_Result.Text += String.Format("{3:F0}) x={0:F3} Y(x)={1:F3} S(x)={2:F3}\r\n", i, Yx, Sx, number);
            }


            bool CheckedRadioButton()
            {
                byte count = 0; // количество выбранных RadioButton
                foreach (Control item in GroupBox_1.Controls)
                {
                    if (item is RadioButton)
                    {
                        RadioButton radioButton = (RadioButton)item;
                        if (radioButton.Checked)
                        {
                            count++;
                            TypeFunk = radioButton.Text;
                        }
                    }
                }
                if (count == 1) return true;
                else return false;
            }

        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            TextBox_Result.Clear();
            TextBox_xn.Text ="0,1";
            TextBox_xk.Text = "1";
            TextBox_n.Text = "10";
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Нахождение факториала
        private double Fact(double n)
        {
            double res = 1;
            for (; n > 0; n--) res *= n;
            return res;
        }

        private double Fx(string TypeFunk, double arg)
        {
            switch (TypeFunk)
            {
                case "sh(s)":
                    {
                        return Math.Sinh(arg);
                    }
                case "x^2":
                    {
                        return Math.Pow(arg, 2);
                    }
                case "e^x":
                    {
                        return Math.Pow(Math.E, arg);
                    }
                default:
                    return 0;
            }
        }
    }
}
