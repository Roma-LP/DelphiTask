using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Create_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TextBox_row.Text, out int rows))       // Считывается значение для rows
                return;
            if (!int.TryParse(TextBox_column.Text, out int columns)) // Считывается значение для columns
                return;

            Matrix_1.TopLeftHeaderCell.Value = "Матртца";
            Matrix_1.ColumnCount = columns;
            Matrix_1.RowCount = rows;

            Array_B.TopLeftHeaderCell.Value = "Массив В";
            Array_B.ColumnCount = 1;
            Array_B.RowCount = rows;
            


            // Устанавливаем заголовки колонок
            foreach (DataGridViewColumn c in Matrix_1.Columns)
            {
                c.Width = 50;
                c.HeaderText = "j = " + c.Index;
            }

            // Проходим по списку столбцов
            foreach (DataGridViewRow row in Matrix_1.Rows)
            {
                // Ставим заголовок столбца
                row.HeaderCell.Value = "i = " + row.Index;

                // Инициализируем ячейки
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null) cell.Value = 0;
                }
            }

            // Устанавливаем заголовки колонок Array_B
            foreach (DataGridViewColumn c in Array_B.Columns)
            {
                c.HeaderText =  "Сортировка по убыванию";
            }

            // Проходим по списку столбцов Array_B
            foreach (DataGridViewRow row in Array_B.Rows)
            {
                // Ставим заголовок столбца Array_B
                row.HeaderCell.Value = "i = " + row.Index;
            }
        }

        private void Button_Random_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            foreach (DataGridViewRow row in Matrix_1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Value = (char)rnd.Next('0', '9');
                }
            }
        }

        private void Buttom_Calculate_Click(object sender, EventArgs e)
        {

            bool flag = true;
            for(byte i = 0; i < Matrix_1.RowCount; i++)
            {
                for (byte j = 0; j < Matrix_1.ColumnCount-1; j++)
                {
                    if(int.Parse(Matrix_1.Rows[i].Cells[j].Value.ToString())> int.Parse(Matrix_1.Rows[i].Cells[j+1].Value.ToString()))
                    {
                        continue;
                    }
                    else
                    {
                        flag = false;
                        break;
                    }
                }
                if(flag)
                {
                    Array_B.Rows[i].Cells[0].Value = '1';
                }
                else
                {
                    Array_B.Rows[i].Cells[0].Value = '0';
                    flag = true;
                }
            }

            
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
