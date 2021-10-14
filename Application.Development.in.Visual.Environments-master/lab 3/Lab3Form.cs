using System;
using System.Windows.Forms;
using lab_3.Integrals;

namespace lab_3
{
    public partial class Lab3Form : Form
    {
        //eto hren
        SinIntegral Integral1;
        SinIntegral func1Area;
        SinIntegral Integral2;
        SinIntegral func2Area;
        SinIntegral mutualArea;

        public Lab3Form()
        {
            InitializeComponent();
        }

        private void Lab3Form_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = chart1.Series["Func1"].Color; //серия графика 1й функции
            pictureBox4.BackColor = chart1.Series["Func2"].Color; //серия графика 2й функции
            pictureBox2.BackColor = chart1.Series["Func1Area"].Color; //серия графика площади 1й функции
            pictureBox3.BackColor = chart1.Series["Func2Area"].Color; //серия графика площади 2й фунцкии
            pictureBox5.BackColor = chart1.Series["MutualArea1"].Color; //серия графика общей площади
        }

        #region Выбор цветов

        private void SetFunc1Color_Button_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            chart1.Series["Func1"].Color = colorDialog1.Color;
            pictureBox1.BackColor = colorDialog1.Color;
        }

        private void SetFunc2Color_Button_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            chart1.Series["Func2"].Color = colorDialog1.Color;
            pictureBox4.BackColor = colorDialog1.Color;
        }

        private void SetFunc1AreaColor_Button_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            chart1.Series["Func1Area"].Color = colorDialog1.Color;
            pictureBox2.BackColor = colorDialog1.Color;
        }

        private void SetFunc2AreaColor_Button_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            chart1.Series["Func2Area"].Color = colorDialog1.Color;
            pictureBox3.BackColor = colorDialog1.Color;
        }

        private void MutualAreaColor_Button_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            chart1.Series["MutualArea1"].Color = colorDialog1.Color;
            pictureBox5.BackColor = colorDialog1.Color;
        }

        #endregion

        #region Рисование графиков

        private void DrawFunc1_Button_Click(object sender, EventArgs e)
        {
            bool flag1 = double.TryParse(textBox1.Text, out double bottom);
            bool flag2 = double.TryParse(textBox2.Text, out double top);
            bool flag3 = double.TryParse(textBox4.Text, out double step);

            if (flag1 && flag2 && flag3)
            {
                Integral1 = new SinIntegral(ref chart1, "Func1", bottom, top, step);

                Integral1.DrawFunc();

                func1Area = new SinIntegral(ref chart1, "Func1Area", bottom, top, step);

                func1Area.DrawFunc();
            }
        }

        private void DrawFunc2_Button_Click(object sender, EventArgs e)
        {
            bool flag1 = double.TryParse(textBox6.Text, out double bottom);
            bool flag2 = double.TryParse(textBox5.Text, out double top);
            bool flag3 = double.TryParse(textBox4.Text, out double step);

            if (flag1 && flag2 && flag3)
            {
                Integral2 = new SinIntegral(ref chart1, "Func2", bottom, top, step);

                Integral2.DrawFunc();

                func2Area = new SinIntegral(ref chart1, "Func2Area", bottom, top, step);

                func2Area.DrawFunc();
            }
        }

        private void DrawMutualArea_Button_Click(object sender, EventArgs e)
        {

            if (Integral2.Bottom > Integral1.Bottom)
            {
                if (Integral2.Top > Integral1.Top)
                {
                    mutualArea = new SinIntegral(ref chart1, "MutualArea1", Integral2.Bottom, Integral1.Top, Integral1.Step);

                    mutualArea.DrawFunc();
                }
            }
        }

        #endregion

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            calcName_Label.Text = "Общая площадь:";
            if (mutualArea != null) { calcValue_Label.Text = mutualArea.CalcLeftRectanglesSquare().ToString(); }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            calcName_Label.Text = "Сумма:";
            if (Integral1 != null && Integral2 != null) { calcValue_Label.Text = (Integral1.CalcLeftRectanglesSquare() + Integral2.CalcLeftRectanglesSquare()).ToString(); }
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            calcName_Label.Text = "Разность:";
            if (Integral1 != null && Integral2 != null) { calcValue_Label.Text = (Math.Abs(Integral1.CalcLeftRectanglesSquare()) - Math.Abs(Integral2.CalcLeftRectanglesSquare())).ToString(); }
        }

        private void CalcF1Area_Button_Click(object sender, EventArgs e)
        {
            if (Integral1 != null) { func1Area_Label.Text = Integral1.CalcLeftRectanglesSquare().ToString(); }
        }

        private void CalcF2Area_Button_Click(object sender, EventArgs e)
        {
            if (Integral2 != null) { func2Area_Label.Text = Integral2.CalcLeftRectanglesSquare().ToString(); }
        }
    }
}
