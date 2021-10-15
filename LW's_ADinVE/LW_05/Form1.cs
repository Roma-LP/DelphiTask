using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void СomboBox_1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)  // Проверка на клавишу ентер
            {
                if (CheckCorrect(ComboBox_1.Text))
                {
                    ListBox_Result.Items.Add(ComboBox_1.Text);
                }
            }
        }

        private bool CheckCorrect(string str)
        {
            for (byte i = 0; i < str.Length; i++)
            {
                if (str[i] == '0' || str[i] == '1' || str[i] == ' ')
                    continue;
                else
                    return false;
            }
            return true;
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            if (CheckCorrect(ComboBox_1.Text))
            {
                ListBox_Result.Items.Add(ComboBox_1.Text);
            }
        }

        private void ListBox_Result_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBox_Result.SelectedItem != null)
            {
                string str_selected = ListBox_Result.SelectedItem.ToString();
                string[] words = str_selected.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string str_result = words[0];
                foreach(string word in words)
                {
                    if(word.Length< str_result.Length)
                    {
                        str_result = word;
                    }
                }
                Label_Result.Text = "Самая короткая группа: " + str_result + " - "+str_result.Length+" символов";
            }
        }

        private void Button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


}
