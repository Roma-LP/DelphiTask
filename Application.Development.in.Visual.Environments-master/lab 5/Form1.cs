using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private enum Func {VAR3,SIN,VAR6}

        private void button1_Click(object sender, EventArgs e)
        {
            double eps, endX, startX;
            try
            {
                startX = Convert.ToDouble(textBox1.Text);
                endX = Convert.ToDouble(textBox2.Text);
                eps = Convert.ToDouble(textBox3.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                return;
            }

            Father[] method = { new Var3(startX, endX, eps,ref chart1), new Sin(startX, endX, eps,ref chart1), new Var6(startX, endX, eps, ref chart1) };
            Func func;

            if (radioButton4.Checked)
                func = Func.VAR3;
            else if (radioButton5.Checked)
                func = Func.SIN;
            else
                func = Func.VAR6;

            if (radioButton1.Checked)
                textBox4.Text = method[(int)func].methodMid().ToString();
            else if (radioButton2.Checked)
                textBox4.Text = method[(int)func].methodIter().ToString();
            else
                textBox4.Text = method[(int)func].methodNuton().ToString();
        }
    }
}
