using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LW_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Do_Click(object sender, EventArgs e)
        {
            double x, y, b=0;
            string TypeFunk = "";
            try
            {
                x = double.Parse(TextBox_X.Text); // Считывается значение x
                y = double.Parse(TextBox_Y.Text); // Считывается значение y
                if (!CheckedRadioButton()) throw new Exception();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены некорректные данные", "Ошибка");
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите функцию", "Ошибка");
                return;
            }

            TextBox_Result.Text += "Лa6.раб.№2. Лепеш Р.Д." + "\r\n";  // Вывод x в окно TextBox_Result                                
            TextBox_Result.Text += "x = " + TextBox_X.Text + "\r\n";  // Вывод x в окно TextBox_Result                                
            TextBox_Result.Text += "y = " + TextBox_Y.Text + "\r\n";  // Вывод y в окно TextBox_Result
                                                                      // Вычисляем арифметическое выражение

            if (y == 0)
                b = 0;
            else
             if (x == 0)
                b = Math.Pow(Math.Pow(Fx(TypeFunk, x), 2) + y, 3);
            else
            if (x / y > 0)
                b = Math.Log(Fx(TypeFunk, x), Math.E) + Math.Pow(Math.Pow(Fx(TypeFunk, x), 2) + y, 3);
            else
            if (x / y < 0)
                b = Math.Log(Fx(TypeFunk,x)/y, Math.E)+ Math.Pow(Fx(TypeFunk, x) + y, 3); 

            TextBox_Result.Text += "Результат = " + b + "   f(x)="+TypeFunk +"\r\n";  //Выводим результат в окно Memo_Result

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
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private double Fx(string TypeFunk,double arg)
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
