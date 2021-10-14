using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_7
{
    public partial class Form1 : Form
    {
        public static Calculator.DFunc F1 = (x, y) => 3 * x - 2 * y + 5;
        public static Calculator.DFunc F2 = (x, y) => (1 - 2 * x) / (y * y);
        public static Calculator.DFunc F3 = (x, y) => Math.Sin(x) * y;
        public static Calculator.DFunc F4 = (x, y) => Math.Sin(x) * y;

        Calculator.CalcMod currentMod = Calculator.CalcMod.EULER;
        Calculator.DFunc currentFunc = F1;

        Babies.ArrayListCalc arrayCalc;
        Babies.ArrayListCalc arrayCalc2;
        Babies.LinkListCalc listCalc1;
        Babies.LinkListCalc listCalc2;
        Babies.StrListCalc strCalc;

        public Form1()
        {
            InitializeComponent();

            double step, endX, startX;

            try
            {
                startX = Convert.ToDouble(textBox1.Text);
                endX = Convert.ToDouble(textBox2.Text);
                step = Convert.ToDouble(textBox3.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                return;
            }

            arrayCalc = new Babies.ArrayListCalc(ref chart1, "func", F1, startX, endX, 1, step);
            arrayCalc2 = new Babies.ArrayListCalc(ref chart1, "func", F1, startX, endX, 1, step);
            listCalc1 = new Babies.LinkListCalc(ref chart1, "func", F2, startX, endX, 1, step);
            listCalc2 = new Babies.LinkListCalc(ref chart1, "func", F3, startX, endX, 1, step);
            strCalc = new Babies.StrListCalc(ref chart1, "func", F1, startX, endX, 1, step);


        }


        private void button1_Click(object sender, EventArgs e)
        {
            switch (currentMod)
            {
                case Calculator.CalcMod.EULER:
                    {
                        arrayCalc.setEulerCalcMod();

                        arrayCalc.CalcDot();

                        int strcount = dataGridView1.Rows.Count;
                        dataGridView1.Rows.Add();

                        dataGridView1.Rows[strcount].Cells[0].Value = arrayCalc.LastPoint().XValue;
                        dataGridView1.Rows[strcount].Cells[1].Value = arrayCalc.LastPoint().YValues[0];

                        arrayCalc.DrawDot();

                        break;
                    }
                case Calculator.CalcMod.TRAPEZOIDAL:
                    {
                        arrayCalc2.setYsovCalcMod();

                        arrayCalc2.CalcDot();

                        int strcount = dataGridView1.Rows.Count;
                        dataGridView1.Rows.Add();

                        dataGridView1.Rows[strcount].Cells[0].Value = arrayCalc2.LastPoint().XValue;
                        dataGridView1.Rows[strcount].Cells[1].Value = arrayCalc2.LastPoint().YValues[0];

                        arrayCalc2.DrawDot();

                        break;
                    }
                case Calculator.CalcMod.RUNGE_KHUTT3:
                    {
                        listCalc1.setRunge3CalcMod();

                        listCalc1.CalcDot();

                        int strcount = dataGridView1.Rows.Count;
                        dataGridView1.Rows.Add();

                        dataGridView1.Rows[strcount].Cells[0].Value = listCalc1.LastPoint().XValue;
                        dataGridView1.Rows[strcount].Cells[1].Value = listCalc1.LastPoint().YValues[0];

                        listCalc1.DrawDot();

                        break;
                    }
                case Calculator.CalcMod.RUNGE_KHUTT4:
                    {
                        listCalc2.setRunge4CalcMod();

                        listCalc2.CalcDot();

                        int strcount = dataGridView1.Rows.Count;
                        dataGridView1.Rows.Add();

                        dataGridView1.Rows[strcount].Cells[0].Value = listCalc2.LastPoint().XValue;
                        dataGridView1.Rows[strcount].Cells[1].Value = listCalc2.LastPoint().YValues[0];

                        listCalc2.DrawDot();

                        break;
                    }
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            currentMod = Calculator.CalcMod.EULER;
            dataGridView1.Rows.Clear();
            arrayCalc.DrawDots();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            currentMod = Calculator.CalcMod.TRAPEZOIDAL;
            dataGridView1.Rows.Clear();
            arrayCalc2.DrawDots();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            currentMod = Calculator.CalcMod.RUNGE_KHUTT3;
            dataGridView1.Rows.Clear();
            listCalc1.DrawDots();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            currentMod = Calculator.CalcMod.RUNGE_KHUTT4;
            dataGridView1.Rows.Clear();
            listCalc2.DrawDots();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            currentFunc = F1;
            double step, endX, startX;

            try
            {
                startX = Convert.ToDouble(textBox1.Text);
                endX = Convert.ToDouble(textBox2.Text);
                step = Convert.ToDouble(textBox3.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                return;
            }

            arrayCalc.restart(currentFunc, startX, endX, 1, step);
            arrayCalc2.restart(currentFunc, startX, endX, 1, step);
            listCalc1.restart(currentFunc, startX, endX, 1, step);
            listCalc2.restart(currentFunc, startX, endX, 1, step);
            dataGridView1.Rows.Clear();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            currentFunc = F2;
            double step, endX, startX;

            try
            {
                startX = Convert.ToDouble(textBox1.Text);
                endX = Convert.ToDouble(textBox2.Text);
                step = Convert.ToDouble(textBox3.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                return;
            }

            arrayCalc.restart(currentFunc, startX, endX, 1, step);
            arrayCalc2.restart(currentFunc, startX, endX, 1, step);
            listCalc1.restart(currentFunc, startX, endX, 1, step);
            listCalc2.restart(currentFunc, startX, endX, 1, step);
            dataGridView1.Rows.Clear();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            currentFunc = F3;
            double step, endX, startX;

            try
            {
                startX = Convert.ToDouble(textBox1.Text);
                endX = Convert.ToDouble(textBox2.Text);
                step = Convert.ToDouble(textBox3.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                return;
            }

            arrayCalc.restart(currentFunc, startX, endX, 1, step);
            arrayCalc2.restart(currentFunc, startX, endX, 1, step);
            listCalc1.restart(currentFunc, startX, endX, 1, step);
            listCalc2.restart(currentFunc, startX, endX, 1, step);
            dataGridView1.Rows.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double step, endX, startX;

            try
            {
                startX = Convert.ToDouble(textBox1.Text);
                endX = Convert.ToDouble(textBox2.Text);
                step = Convert.ToDouble(textBox3.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                return;
            }

            arrayCalc.restart(currentFunc, startX, endX, 1, step);
            arrayCalc2.restart(currentFunc, startX, endX, 1, step);
            listCalc1.restart(currentFunc, startX, endX, 1, step);
            listCalc2.restart(currentFunc, startX, endX, 1, step);
            dataGridView1.Rows.Clear();
        }
    }
}
