using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LW_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Do_Click(object sender, EventArgs e)
        {
            double x, y, z, a, b, c, d;
            try
            {
                x = double.Parse(TextBox_X.Text); // Считывается значение x
                y = double.Parse(TextBox_Y.Text); // Считывается значение y
                z = double.Parse(TextBox_Z.Text); // Считывается значение z
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены некорректные данные", "Ошибка");
                return;
            }

            TextBox_Result.Text += "Лa6.раб.№1. Лепеш Р.Д." + "\r\n";  // Вывод x в окно TextBox_Result                                
            TextBox_Result.Text += "x = " + TextBox_X.Text + "\r\n";  // Вывод x в окно TextBox_Result                                
            TextBox_Result.Text += "y = " + TextBox_Y.Text + "\r\n";  // Вывод y в окно TextBox_Result
            TextBox_Result.Text += "z = " + TextBox_Z.Text + "\r\n";  // Вывод z в окно TextBox_Result
                                                             // Вычисляем арифметическое выражение
            a = Math.Pow(8 + Math.Pow(Math.Abs(x - y), 2) + 1, 1 / 3);   // Abs  модуль числа
            b = Math.Pow(x, 2) + Math.Pow(y, 2) + 2;  // Pow степень
            c = Math.Exp(Math.Abs(x - y)) * Math.Pow((Math.Pow(Math.Tan(z), 2) + 1), x);  // Exp exonent
            d = a / b - c;

            TextBox_Result.Text += "Результат = " + d + "\r\n";  //Выводим результат в окно Memo_Result
        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            TextBox_Result.Clear();
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
