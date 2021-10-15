
namespace LW_08
{
    partial class LW_08
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.text_box_y = new System.Windows.Forms.TextBox();
            this.lb_y = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.text_box_z = new System.Windows.Forms.TextBox();
            this.lb_z = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Step = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.TextBox();
            this.from = new System.Windows.Forms.TextBox();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BT_Start = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            this.SuspendLayout();
            // 
            // text_box_y
            // 
            this.text_box_y.Location = new System.Drawing.Point(81, 48);
            this.text_box_y.Margin = new System.Windows.Forms.Padding(2);
            this.text_box_y.Name = "text_box_y";
            this.text_box_y.Size = new System.Drawing.Size(122, 20);
            this.text_box_y.TabIndex = 25;
            this.text_box_y.Text = "0,1";
            // 
            // lb_y
            // 
            this.lb_y.AutoSize = true;
            this.lb_y.Location = new System.Drawing.Point(1, 48);
            this.lb_y.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_y.Name = "lb_y";
            this.lb_y.Size = new System.Drawing.Size(62, 13);
            this.lb_y.TabIndex = 24;
            this.lb_y.Text = "Введите Y:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.text_box_z);
            this.groupBox1.Controls.Add(this.lb_z);
            this.groupBox1.Controls.Add(this.lb_y);
            this.groupBox1.Controls.Add(this.text_box_y);
            this.groupBox1.Location = new System.Drawing.Point(11, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(215, 125);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Значения:";
            // 
            // text_box_z
            // 
            this.text_box_z.Location = new System.Drawing.Point(81, 73);
            this.text_box_z.Margin = new System.Windows.Forms.Padding(2);
            this.text_box_z.Name = "text_box_z";
            this.text_box_z.Size = new System.Drawing.Size(122, 20);
            this.text_box_z.TabIndex = 27;
            this.text_box_z.Text = "0,1";
            // 
            // lb_z
            // 
            this.lb_z.AutoSize = true;
            this.lb_z.Location = new System.Drawing.Point(1, 73);
            this.lb_z.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_z.Name = "lb_z";
            this.lb_z.Size = new System.Drawing.Size(62, 13);
            this.lb_z.TabIndex = 26;
            this.lb_z.Text = "Введите Z:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::LW_08.Properties.Resources.PrimerLP1;
            this.pictureBox1.Image = global::LW_08.Properties.Resources.PrimerLP1;
            this.pictureBox1.InitialImage = global::LW_08.Properties.Resources.PrimerLP1;
            this.pictureBox1.Location = new System.Drawing.Point(231, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Step);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.to);
            this.groupBox3.Controls.Add(this.from);
            this.groupBox3.Location = new System.Drawing.Point(511, 13);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(215, 125);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Интервал:";
            // 
            // Step
            // 
            this.Step.Location = new System.Drawing.Point(81, 73);
            this.Step.Margin = new System.Windows.Forms.Padding(2);
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(122, 20);
            this.Step.TabIndex = 27;
            this.Step.Text = "0,5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "От (xmin):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Шаг:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "До:";
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(81, 48);
            this.to.Margin = new System.Windows.Forms.Padding(2);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(122, 20);
            this.to.TabIndex = 25;
            this.to.Text = "50";
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(81, 24);
            this.from.Margin = new System.Windows.Forms.Padding(2);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(122, 20);
            this.from.TabIndex = 23;
            this.from.Text = "-25";
            // 
            // MainChart
            // 
            chartArea4.Name = "ChartArea1";
            this.MainChart.ChartAreas.Add(chartArea4);
            this.MainChart.Location = new System.Drawing.Point(11, 142);
            this.MainChart.Name = "MainChart";
            this.MainChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series4.BorderWidth = 5;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series4.LabelBorderWidth = 5;
            series4.Name = "Series1";
            this.MainChart.Series.Add(series4);
            this.MainChart.Size = new System.Drawing.Size(716, 456);
            this.MainChart.TabIndex = 30;
            // 
            // BT_Start
            // 
            this.BT_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_Start.Location = new System.Drawing.Point(15, 605);
            this.BT_Start.Name = "BT_Start";
            this.BT_Start.Size = new System.Drawing.Size(175, 44);
            this.BT_Start.TabIndex = 31;
            this.BT_Start.Text = "Расчитать";
            this.BT_Start.UseVisualStyleBackColor = true;
            this.BT_Start.Click += new System.EventHandler(this.BT_Start_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(815, 608);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(175, 44);
            this.ExitButton.TabIndex = 32;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.FormattingEnabled = true;
            this.ResultBox.Location = new System.Drawing.Point(732, 13);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(258, 589);
            this.ResultBox.TabIndex = 33;
            // 
            // LW_08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1002, 661);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.BT_Start);
            this.Controls.Add(this.MainChart);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "LW_08";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LW_08";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox text_box_y;
        private System.Windows.Forms.Label lb_y;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox text_box_z;
        private System.Windows.Forms.Label lb_z;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Step;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
        private System.Windows.Forms.Button BT_Start;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ListBox ResultBox;
    }
}

