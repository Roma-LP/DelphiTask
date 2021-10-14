namespace lab_9
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.th1_start = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.th1_stop = new System.Windows.Forms.Button();
            this.th1_pause = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.start_bt = new System.Windows.Forms.Button();
            this.stop_bt = new System.Windows.Forms.Button();
            this.pause_bt = new System.Windows.Forms.Button();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // th1_start
            // 
            this.th1_start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.th1_start.Location = new System.Drawing.Point(3, 3);
            this.th1_start.Name = "th1_start";
            this.th1_start.Size = new System.Drawing.Size(131, 39);
            this.th1_start.TabIndex = 0;
            this.th1_start.Text = "Start";
            this.th1_start.UseVisualStyleBackColor = true;
            this.th1_start.Click += new System.EventHandler(this.th1_start_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.chart1);
            this.splitContainer1.Panel1.Controls.Add(this.trackBar1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel2.Controls.Add(this.trackBar2);
            this.splitContainer1.Panel2.Controls.Add(this.progressBar1);
            this.splitContainer1.Size = new System.Drawing.Size(838, 531);
            this.splitContainer1.SplitterDistance = 419;
            this.splitContainer1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.th1_start, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.th1_stop, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.th1_pause, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 483);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(413, 45);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // th1_stop
            // 
            this.th1_stop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.th1_stop.Enabled = false;
            this.th1_stop.Location = new System.Drawing.Point(277, 3);
            this.th1_stop.Name = "th1_stop";
            this.th1_stop.Size = new System.Drawing.Size(133, 39);
            this.th1_stop.TabIndex = 5;
            this.th1_stop.Text = "Stop";
            this.th1_stop.UseVisualStyleBackColor = true;
            this.th1_stop.Click += new System.EventHandler(this.th1_stop_Click);
            // 
            // th1_pause
            // 
            this.th1_pause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.th1_pause.Location = new System.Drawing.Point(140, 3);
            this.th1_pause.Name = "th1_pause";
            this.th1_pause.Size = new System.Drawing.Size(131, 39);
            this.th1_pause.TabIndex = 6;
            this.th1_pause.Text = "Pause";
            this.th1_pause.UseVisualStyleBackColor = true;
            this.th1_pause.Click += new System.EventHandler(this.th1_pause_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Top;
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 4;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(419, 383);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(7, 432);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Minimum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(406, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.TickFrequency = 20;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.start_bt, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.stop_bt, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.pause_bt, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 483);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(413, 45);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // start_bt
            // 
            this.start_bt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.start_bt.Location = new System.Drawing.Point(3, 3);
            this.start_bt.Name = "start_bt";
            this.start_bt.Size = new System.Drawing.Size(131, 39);
            this.start_bt.TabIndex = 0;
            this.start_bt.Text = "Start";
            this.start_bt.UseVisualStyleBackColor = true;
            this.start_bt.Click += new System.EventHandler(this.start_bt_Click);
            // 
            // stop_bt
            // 
            this.stop_bt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stop_bt.Enabled = false;
            this.stop_bt.Location = new System.Drawing.Point(277, 3);
            this.stop_bt.Name = "stop_bt";
            this.stop_bt.Size = new System.Drawing.Size(133, 39);
            this.stop_bt.TabIndex = 5;
            this.stop_bt.Text = "Stop";
            this.stop_bt.UseVisualStyleBackColor = true;
            this.stop_bt.Click += new System.EventHandler(this.stop_bt_Click);
            // 
            // pause_bt
            // 
            this.pause_bt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pause_bt.Location = new System.Drawing.Point(140, 3);
            this.pause_bt.Name = "pause_bt";
            this.pause_bt.Size = new System.Drawing.Size(131, 39);
            this.pause_bt.TabIndex = 6;
            this.pause_bt.Text = "Pause";
            this.pause_bt.UseVisualStyleBackColor = true;
            this.pause_bt.Click += new System.EventHandler(this.pause_bt_Click);
            // 
            // trackBar2
            // 
            this.trackBar2.LargeChange = 500;
            this.trackBar2.Location = new System.Drawing.Point(6, 432);
            this.trackBar2.Maximum = 1000;
            this.trackBar2.Minimum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(397, 45);
            this.trackBar2.SmallChange = 100;
            this.trackBar2.TabIndex = 4;
            this.trackBar2.TickFrequency = 20;
            this.trackBar2.Value = 100;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(415, 383);
            this.progressBar1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 531);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lab 9";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button th1_start;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button th1_stop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button th1_pause;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button start_bt;
        private System.Windows.Forms.Button stop_bt;
        private System.Windows.Forms.Button pause_bt;
    }
}

