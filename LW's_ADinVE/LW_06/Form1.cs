using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace lab_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|Data files(*.dat)|*.dat";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|Data files(*.dat)|*.dat";
        }

        string fileName, extentinsion;

        // открытие файла
        void openButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)    
                return;

            resultListBox.Items.Clear();

            // получаем выбранный файл
            fileName = openFileDialog1.FileName;
            extentinsion  = Path.GetExtension(fileName); // расширение файла
            if (extentinsion == ".txt")
            {
                // читаем файл в строку
                string fileProduct = File.ReadAllText(fileName);
                foreach (string pr in fileProduct.Split(new char[] { '\n','\r' }, StringSplitOptions.RemoveEmptyEntries))
                { 
                    resultListBox.Items.Add(pr);
                }
            }
            if(extentinsion == ".dat")
            {
                FileStream fstream = File.Open(fileName, FileMode.Open);

                BinaryFormatter binaryFormatter = new BinaryFormatter();

                List<string> Products = (List<string>)binaryFormatter.Deserialize(fstream);

                fstream.Close();

                foreach (var pr in Products)
                    resultListBox.Items.Add(pr);
            }
            MessageBox.Show("Файл открыт");
        }

        // сохранение файла
        void saveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            // получаем выбранный файл
            string filename = saveFileDialog1.FileName, textProducts = null;
            extentinsion = Path.GetExtension(filename);
            if (extentinsion == ".txt")
            {
                // сохраняем текст в файл
                foreach (string pr in resultListBox.Items) { textProducts += pr + "\r\n"; }
                File.WriteAllText(filename, textProducts);
            }
            if (extentinsion == ".dat")
            {
                List<string> products = new List<string>();
                foreach (string pr in resultListBox.Items) { products.Add(pr); }

                FileStream fstream = File.Open(filename, FileMode.OpenOrCreate);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fstream, products);
                fstream.Close();
            }
                MessageBox.Show("Файл сохранен");
        }
        
        private void dateEnterButton_Click(object sender, EventArgs e)
        {
            string productStr=null;

            if(!double.TryParse(CodeProd.Text, out double ex1)) return;
            if(!double.TryParse(countProd.Text, out double ex2)) return;
            if(!double.TryParse(priceProd.Text, out double ex3)) return;

            productStr += CodeProd.Text + " - ";
            productStr += nameProd.Text + " - ";
            productStr += countProd.Text + " - ";
            productStr += priceProd.Text + " - ";
            productStr += dateTimePicker1.Text;
           
            bool newProd = true;

            if (resultListBox.Items.Count == 0)
            {
                resultListBox.Items.Add(productStr);                
            }
            else
            {   
                List<string> Products = new List<string>();

                foreach(string product in resultListBox.Items) { Products.Add(product); }                

                foreach (string product in Products)
                {
                    string[] productParts = product.Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
                    if (productParts[0] == CodeProd.Text)
                    {
                        DialogResult result = MessageBox.Show("Товар с таким номером уже существует!\nЗаменить его?","Сообщение",MessageBoxButtons.YesNo);
                        if(result==DialogResult.Yes)
                        {
                            int index = resultListBox.Items.IndexOf(product);
                            resultListBox.Items.Insert(index, productStr);                            
                            resultListBox.Items.RemoveAt(++index);
                            newProd = false;
                        }
                        else { newProd = false; }
                        break;
                    }   
                };
                if (newProd) { resultListBox.Items.Add(productStr); }
            }
            CodeProd.Text = (int.Parse(CodeProd.Text) + 1).ToString();
        }

        private void resultListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (resultListBox.SelectedItem==null)  return; 
            string product = resultListBox.SelectedItem.ToString();
            string[] partsOfBook = product.Split(new char[] { ' ','-' }, StringSplitOptions.RemoveEmptyEntries);
            CodeProd.Text = partsOfBook[0];
            nameProd.Text = partsOfBook[1];
            countProd.Text = partsOfBook[2];
            priceProd.Text = partsOfBook[3];
            dateTimePicker1.Text = partsOfBook[4];
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (resultListBox.SelectedIndex == -1) return;

            resultListBox.Items.RemoveAt(resultListBox.SelectedIndex);

        }

        private void TaskButton_Click(object sender, EventArgs e)
        {
            if (resultListBox.Items.Count == 0) return;

            List<string> Products = new List<string>();
            foreach(string product in resultListBox.Items) { Products.Add(product); }

            List<string> resultProducts = new List<string>();
            foreach (string product in Products)
            {
                string[] productParts = product.Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
                if (double.Parse(productParts[3]) > 1000)
                {
                    string[] data = productParts[4].Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                    if (DateTime.Now.Date.Month- int.Parse(data[1])>=1)
                    {
                        resultProducts.Add(product);
                    }
                }
            };

            resultListBox.Items.Clear();
            foreach (var pr in resultProducts)
                resultListBox.Items.Add(pr);
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
           saveButton_Click(sender, e);
            Application.Exit();
        }    
    }
}