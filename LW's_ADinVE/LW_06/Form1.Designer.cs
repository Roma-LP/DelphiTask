namespace lab_6
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.CodeProd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.priceProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateEnterButton = new System.Windows.Forms.Button();
            this.countProd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.TaskButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CodeProd
            // 
            this.CodeProd.Location = new System.Drawing.Point(213, 31);
            this.CodeProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CodeProd.Name = "CodeProd";
            this.CodeProd.Size = new System.Drawing.Size(205, 24);
            this.CodeProd.TabIndex = 3;
            this.CodeProd.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Код товара:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.priceProd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.countProd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nameProd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CodeProd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(457, 274);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Товар:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(213, 194);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(204, 24);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.Value = new System.DateTime(2014, 7, 16, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 36);
            this.label5.TabIndex = 13;
            this.label5.Text = "Дата поступления\r\nна склад:";
            // 
            // priceProd
            // 
            this.priceProd.Location = new System.Drawing.Point(213, 154);
            this.priceProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceProd.Name = "priceProd";
            this.priceProd.Size = new System.Drawing.Size(205, 24);
            this.priceProd.TabIndex = 10;
            this.priceProd.Text = "1,15";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Цена единицы:";
            // 
            // dateEnterButton
            // 
            this.dateEnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateEnterButton.Location = new System.Drawing.Point(480, 11);
            this.dateEnterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateEnterButton.Name = "dateEnterButton";
            this.dateEnterButton.Size = new System.Drawing.Size(307, 152);
            this.dateEnterButton.TabIndex = 9;
            this.dateEnterButton.Text = "Добавить запись";
            this.dateEnterButton.UseVisualStyleBackColor = true;
            this.dateEnterButton.Click += new System.EventHandler(this.dateEnterButton_Click);
            // 
            // countProd
            // 
            this.countProd.Location = new System.Drawing.Point(213, 113);
            this.countProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.countProd.Name = "countProd";
            this.countProd.Size = new System.Drawing.Size(205, 24);
            this.countProd.TabIndex = 7;
            this.countProd.Text = "15";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "Количество единиц\r\nтовара:";
            // 
            // nameProd
            // 
            this.nameProd.Location = new System.Drawing.Point(213, 71);
            this.nameProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameProd.Name = "nameProd";
            this.nameProd.Size = new System.Drawing.Size(205, 24);
            this.nameProd.TabIndex = 5;
            this.nameProd.Text = "Ручка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Наименование товара:";
            // 
            // openFileButton
            // 
            this.openFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openFileButton.Location = new System.Drawing.Point(19, 495);
            this.openFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(184, 79);
            this.openFileButton.TabIndex = 11;
            this.openFileButton.Text = "Открыть";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(408, 495);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(184, 79);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(213, 495);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(184, 79);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(603, 495);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(184, 79);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // resultListBox
            // 
            this.resultListBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.ItemHeight = 16;
            this.resultListBox.Items.AddRange(new object[] {
            "1 - Тетрадь - 20 - 2,15 - 16.02.2021",
            "2 - Линейка - 8 - 0,80 - 16.08.2021",
            "3 - Циркуль - 12 - 1,45 - 19.09.2021"});
            this.resultListBox.Location = new System.Drawing.Point(17, 292);
            this.resultListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.ScrollAlwaysVisible = true;
            this.resultListBox.Size = new System.Drawing.Size(771, 196);
            this.resultListBox.TabIndex = 16;
            this.resultListBox.SelectedIndexChanged += new System.EventHandler(this.resultListBox_SelectedIndexChanged);
            // 
            // TaskButton
            // 
            this.TaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskButton.Location = new System.Drawing.Point(480, 167);
            this.TaskButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TaskButton.Name = "TaskButton";
            this.TaskButton.Size = new System.Drawing.Size(309, 119);
            this.TaskButton.TabIndex = 20;
            this.TaskButton.Text = "Вывести список товаров, хранящихся больше месяца, стоимость которых превышает 5 р" +
    "уб.";
            this.TaskButton.UseVisualStyleBackColor = true;
            this.TaskButton.Click += new System.EventHandler(this.TaskButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(797, 581);
            this.Controls.Add(this.TaskButton);
            this.Controls.Add(this.resultListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dateEnterButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LW_06";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox CodeProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button dateEnterButton;
        private System.Windows.Forms.TextBox countProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox priceProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.Button TaskButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

