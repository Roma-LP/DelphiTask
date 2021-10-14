using System;
using System.Windows.Forms;

namespace lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static Integrals.Mods currentMod = Integrals.Mods.TRAPEZOID_METHOD;

        private void TextBox123_TextChanged_Or_ModChanged(object sender, EventArgs e)
        {
            label8.Text = "";
            label7.Text = textBox1.Text;
            label6.Text = textBox2.Text;


            double.TryParse(textBox1.Text, out double lim1);
            double.TryParse(textBox2.Text, out double lim2);
            double.TryParse(textBox3.Text, out double step);

            if (lim1 >= lim2)
            {
                label8.Text = "Нижняя граница больше чем\nверхняя, не удаётся\nпостроить график!";
                return;
            }

            if (step <= 0)
            {
                label8.Text = "Шаг должен быть больше нуля!";
                return;
            }

            label2.Text = Integrals.CalcAndDraw(lim1, lim2, step, currentMod, ref chart1).ToString();

            Integrals.DrawIntegral(ref chart1, lim1, lim2, step);
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            currentMod = Integrals.Mods.TRAPEZOID_METHOD;
            TextBox123_TextChanged_Or_ModChanged(sender, e);
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            currentMod = Integrals.Mods.LEFT_RECTANGLE_METHOD;
            TextBox123_TextChanged_Or_ModChanged(sender, e);
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            currentMod = Integrals.Mods.RIGHT_RECTANGLE_METHOD;
            TextBox123_TextChanged_Or_ModChanged(sender, e);
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            currentMod = Integrals.Mods.MIDDLE_RECTANGLE_METHOD;
            TextBox123_TextChanged_Or_ModChanged(sender, e);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
