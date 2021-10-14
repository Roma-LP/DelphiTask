using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2
{
    public partial class Main : Form
    {
        enum Functions { SH, X2, EX }

        public Main()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count > 1)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    checkedListBox1.SetItemChecked(i, false);
                checkedListBox1.SetItemChecked(checkedListBox1.SelectedIndex, true);
            }
            MessageBox.Show("Выбран режим №" + (checkedListBox1.SelectedIndex+1));
        }

        private double Fun(Functions fun, double arg)
        {
            switch ((Functions)checkedListBox1.SelectedIndex)
            {
                case Functions.SH: return Math.Sinh(arg);
                case Functions.X2: return Math.Pow(arg, 2);
                case Functions.EX: return Math.Pow(Math.E, arg);
            }
            return 0;
        }        

        private void CalButton_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(xbox.Text);
                double b = double.Parse(bbox.Text);
                double g = 0.0;

                Functions fun = (Functions)checkedListBox1.SelectedIndex;

                if (checkedListBox1.CheckedItems.Count == 0) throw new Exception();

                if (0.5 < x * b && x * b <10)  g = Math.Pow( Math.E , Fun(fun,x)) - Math.Abs(b);
                else if (0.1 < x * b && x*b < 0.5)  g = Math.Sqrt( Fun(fun, x) + b);
                else g = 2*Math.Pow(Fun(fun,x),2);

                string ans = "Результат вычислений по формуле #"+ (checkedListBox1.SelectedIndex+1 ) + ": x=" + x +" b="+b+" g="+g;
                resBox.Text += ans + Environment.NewLine;
            } catch {
                resBox.Text += "Неправильно введены данные!" + System.Environment.NewLine;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) this.resBox.BackColor = System.Drawing.Color.Red;
            else this.resBox.BackColor = System.Drawing.Color.White;
        }

    }
}
