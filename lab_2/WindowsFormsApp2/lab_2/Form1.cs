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

        private double Fun(Functions fun, double arg)
        {
            switch (fun)
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

                Functions fun = Functions.SH;

                if (sh.Checked) {
                    fun = Functions.SH;
                } else if (x2.Checked) {
                    fun = Functions.X2;
                } else if (ex.Checked) {
                    fun = Functions.EX;
                } 

                if (0.5 < x * b && x * b <10)  g = Math.Pow( Math.E , Fun(fun,x)) - Math.Abs(b);
                else if (0.1 < x * b && x*b < 0.5)  g = Math.Sqrt( Fun(fun, x) + b);
                else g = 2*Math.Pow(Fun(fun,x),2);

                string ans = "x=" + x +" b="+b+" g="+g;// b={1:F2}, g={2:F2}, ", x, b, g);
                resBox.Text += ans + Environment.NewLine;
            } catch {
                this.resBox.ForeColor = System.Drawing.Color.Red;
                this.resBox.BackColor = System.Drawing.Color.Yellow;
                resBox.Text += "Неправильно введены данные!" + System.Environment.NewLine;
            }
            this.resBox.ForeColor = System.Drawing.Color.Black;
            this.resBox.BackColor = System.Drawing.Color.White;
        }

        private void Main_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) CalButton.PerformClick();
            else if (e.KeyChar == '0') MessageBox.Show("Nigga");
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count > 1)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    checkedListBox1.SetItemChecked(i, false);
                checkedListBox1.SetItemChecked(checkedListBox1.SelectedIndex, true);
            }

        }
        private void sh_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked == true) resBox.Text += System.Environment.NewLine + rb.Text;
        }
    }
}
