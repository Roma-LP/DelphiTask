using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            var list = new List<char>();
            int num=0;
            foreach (DataGridViewRow row in GridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    char.TryParse(cell.Value.ToString(), out char cellchar);

                    if (list.IndexOf(cellchar) < 0)
                    {
                        list.Add(cellchar);
                        num++;
                    }
                }
            }
            resBox.Text = "Колличество различных символов в матрице: "+num;
        }

        private void SetSize_Click(object sender, EventArgs e)
        {
            int.TryParse(NBox.Text, out int rows);
            int.TryParse(MBox.Text, out int columns);

            GridView.TopLeftHeaderCell.Value = "Матртца символов";

            GridView.ColumnCount = columns;
            GridView.RowCount = rows;

            // Устанавливаем заголовки колонок
            foreach (DataGridViewColumn c in GridView.Columns)
            {
                c.HeaderText = "j = " + c.Index;
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            // Проходим по списку столбцов
            foreach (DataGridViewRow row in GridView.Rows)
            {
                // Ставим заголовок столбца
                row.HeaderCell.Value = "i = " + row.Index;

                // Инициализируем ячейки
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null) cell.Value = 0;
                }
            }
        }

        private void Randomize_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            foreach (DataGridViewRow row in GridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Value = (char)rnd.Next('a', 'z');
                }
            }
        }

        private void GridView_SelectionChanged(object sender, EventArgs e)
        {
            string text = "Адрес: [" + GridView.CurrentCell.ColumnIndex + ":" + GridView.CurrentCell.RowIndex + "] Содержимое ячейки: " + GridView.CurrentCell.Value;
            resBox.Text = text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 4; i++)
            {
                for (int j = 1; j < 4; j++)
                    GridView[i, j].Selected = true;
            }

        }// эти две функции
    }// ну хоть кто прочитает
}// мб..
