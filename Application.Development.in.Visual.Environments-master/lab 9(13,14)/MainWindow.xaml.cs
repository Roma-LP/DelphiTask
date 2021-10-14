using Microsoft.Office.Interop.Word;
using System;
using System.Windows;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;

namespace Lab13
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc";

            //Создание документа.
            Word._Application oWord;
            Word._Document oDoc;
            oWord = new Word.Application
            {
                Visible = true
            };
            oDoc = oWord.Documents.Add();

            //Вставка заголовка.
            Word.Paragraph oPara1;
            oPara1 = oDoc.Content.Paragraphs.Add();
            oPara1.Range.Text = "Заголовок 1";
            oPara1.Range.Font.Bold = 1;
            oPara1.Format.SpaceAfter = 24;
            oPara1.Range.InsertParagraphAfter();

            //Вставка текста в конец документа.
            Word.Paragraph oPara2;
            object oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara2 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara2.Range.Text = "Заголовок 2";
            oPara2.Format.SpaceAfter = 6;
            oPara2.Range.InsertParagraphAfter();

            //Вставка обычного текста.
            Word.Paragraph oPara3;
            oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara3 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara3.Range.Text = "Какой-то очень длинный текст. Какой-то очень длинный текст. Какой-то очень длинный текст.";
            oPara3.Range.Font.Bold = 0;
            oPara3.Format.SpaceAfter = 24;
            oPara3.Range.InsertParagraphAfter();

            // Табличка 3х5
            Word.Table oTable;
            Word.Range wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oTable = oDoc.Tables.Add(wrdRng, 3, 5);
            oTable.Range.ParagraphFormat.SpaceAfter = 6;

            oTable.Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle;
            oTable.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;

            string strText;
            for (int r = 1; r <= 3; r++)
                for (int c = 1; c <= 5; c++)
                {
                    strText = $"строка {r} колонка {c}";
                    oTable.Cell(r, c).Range.Text = strText;
                }
            oTable.Rows[1].Range.Font.Bold = 1;
            oTable.Rows[1].Range.Font.Italic = 1;


            //Вставка графика.
            InlineShape oShape;
            wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oShape = wrdRng.InlineShapes.AddOLEObject("MSGraph.Chart.8");
            
            oShape.Width = oWord.InchesToPoints(6.25f);
            oShape.Height = oWord.InchesToPoints(3.57f);

            //Вставка картинки после графика.
            wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            wrdRng.InsertParagraphAfter();
            var addr = Environment.CurrentDirectory + "\\simple_plot1.png";
            wrdRng.InlineShapes.AddPicture(addr);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application()
            {
                Visible = true
            };
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlWorkSheet.Cells[1, 1] = "";

            xlWorkSheet.Cells[1, 2] = "Студент 1";
            xlWorkSheet.Cells[1, 3] = "Студент 2";
            xlWorkSheet.Cells[1, 4] = "Студент 3";

            xlWorkSheet.Cells[2, 1] = "Семестр 1";
            xlWorkSheet.Cells[2, 2] = "80";
            xlWorkSheet.Cells[2, 3] = "65";
            xlWorkSheet.Cells[2, 4] = "45";

            xlWorkSheet.Cells[3, 1] = "Семестр 2";
            xlWorkSheet.Cells[3, 2] = "78";
            xlWorkSheet.Cells[3, 3] = "72";
            xlWorkSheet.Cells[3, 4] = "60";

            xlWorkSheet.Cells[4, 1] = "Семестр 3";
            xlWorkSheet.Cells[4, 2] = "82";
            xlWorkSheet.Cells[4, 3] = "80";
            xlWorkSheet.Cells[4, 4] = "65";

            xlWorkSheet.Cells[5, 1] = "Семестр 4";
            xlWorkSheet.Cells[5, 2] = "75";
            xlWorkSheet.Cells[5, 3] = "82";
            xlWorkSheet.Cells[5, 4] = "68";

            Excel.Range chartRange;

            Excel.ChartObjects xlCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
            Excel.ChartObject myChart = xlCharts.Add(10, 80, 300, 250);
            Excel.Chart chartPage = myChart.Chart;

            chartRange = xlWorkSheet.get_Range("A1", "d5");
            chartPage.SetSourceData(chartRange, misValue);
            chartPage.ChartType = Excel.XlChartType.xlColumnClustered;
        }
    }
}
