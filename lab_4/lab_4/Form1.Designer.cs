namespace lab_4
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
            this.GridView = new System.Windows.Forms.DataGridView();
            this.Calculate = new System.Windows.Forms.Button();
            this.NBox = new System.Windows.Forms.TextBox();
            this.SetSize = new System.Windows.Forms.Button();
            this.MBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.resBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.AllowUserToResizeColumns = false;
            this.GridView.AllowUserToResizeRows = false;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Location = new System.Drawing.Point(10, 74);
            this.GridView.Name = "GridView";
            this.GridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.GridView.RowTemplate.Height = 21;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridView.ShowCellToolTips = false;
            this.GridView.ShowEditingIcon = false;
            this.GridView.Size = new System.Drawing.Size(653, 340);
            this.GridView.TabIndex = 0;
            this.GridView.SelectionChanged += new System.EventHandler(this.GridView_SelectionChanged);
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(10, 500);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(469, 23);
            this.Calculate.TabIndex = 1;
            this.Calculate.Text = "Вычислить";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // NBox
            // 
            this.NBox.Location = new System.Drawing.Point(200, 12);
            this.NBox.Name = "NBox";
            this.NBox.Size = new System.Drawing.Size(123, 20);
            this.NBox.TabIndex = 2;
            // 
            // SetSize
            // 
            this.SetSize.Location = new System.Drawing.Point(332, 11);
            this.SetSize.Name = "SetSize";
            this.SetSize.Size = new System.Drawing.Size(182, 57);
            this.SetSize.TabIndex = 3;
            this.SetSize.Text = "Установить размерность";
            this.SetSize.UseVisualStyleBackColor = true;
            this.SetSize.Click += new System.EventHandler(this.SetSize_Click);
            // 
            // MBox
            // 
            this.MBox.Location = new System.Drawing.Point(200, 47);
            this.MBox.Name = "MBox";
            this.MBox.Size = new System.Drawing.Size(123, 20);
            this.MBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите кол-во строк матрицы:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите кол-во столбцов матрицы:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 57);
            this.button1.TabIndex = 7;
            this.button1.Text = "Заполнить матрицу случайными символами";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Randomize_Click);
            // 
            // resBox
            // 
            this.resBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.resBox.Location = new System.Drawing.Point(10, 421);
            this.resBox.Multiline = true;
            this.resBox.Name = "resBox";
            this.resBox.ReadOnly = true;
            this.resBox.Size = new System.Drawing.Size(654, 74);
            this.resBox.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(484, 500);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Выделить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 534);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.resBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MBox);
            this.Controls.Add(this.SetSize);
            this.Controls.Add(this.NBox);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.GridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Lab 4";
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox NBox;
        private System.Windows.Forms.Button SetSize;
        private System.Windows.Forms.TextBox MBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox resBox;
        private System.Windows.Forms.Button button2;
    }
}

