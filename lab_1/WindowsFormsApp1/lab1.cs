using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class lab1 : Form
    {
        public lab1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, z, a1,a2,a3,a;
            try
            {
                x = double.Parse(TB1.Text);
                y = double.Parse(TB2.Text);
                z = double.Parse(TB3.Text);
            }
            catch (FormatException)
            {
                this.res_box.ForeColor = System.Drawing.Color.Red;
                this.res_box.BackColor = System.Drawing.Color.Yellow;
                res_box.Text = "ВВЕДЕНЫ НЕКОРРЕКТНЫЕ ДАННЫЕ\nВВЕДЕНЫ НЕКОРРЕКТНЫЕ ДАННЫЕ\nВВЕДЕНЫ НЕКОРРЕКТНЫЕ ДАННЫЕ";
                return;
            }
            this.res_box.ForeColor = System.Drawing.Color.Black;
            this.res_box.BackColor = System.Drawing.Color.White;
            //a = x + y + z;
            a1 = (Math.Pow(x, 1.0 / 3.0) + Math.Pow(x, y + 2));
            a2 = Math.Sqrt(10.0 * a1);
            a3 = (Math.Pow(Math.Asin(z), 2) - Math.Abs(x - y));
            a = a2*a3;
            res_box.Text += "по 6й формуле: " +a.ToString()+ "\r\n";
        }
    }
}
