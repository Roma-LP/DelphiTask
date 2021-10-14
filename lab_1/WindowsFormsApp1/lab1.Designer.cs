namespace WindowsFormsApp1
{
    partial class lab1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.TB3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.res_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите занчение X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите занчение Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите занчение Z:";
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(157, 12);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(100, 20);
            this.TB1.TabIndex = 3;
            this.TB1.Tag = "";
            this.TB1.Text = "0,01655";
            // 
            // TB2
            // 
            this.TB2.Location = new System.Drawing.Point(157, 43);
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(100, 20);
            this.TB2.TabIndex = 4;
            this.TB2.Tag = "";
            this.TB2.Text = "-2,75";
            // 
            // TB3
            // 
            this.TB3.Location = new System.Drawing.Point(157, 74);
            this.TB3.Name = "TB3";
            this.TB3.Size = new System.Drawing.Size(100, 20);
            this.TB3.TabIndex = 5;
            this.TB3.Tag = "";
            this.TB3.Text = "0,15";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Результат выполнения программы:";
            // 
            // res_box
            // 
            this.res_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.res_box.Location = new System.Drawing.Point(21, 143);
            this.res_box.Multiline = true;
            this.res_box.Name = "res_box";
            this.res_box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.res_box.Size = new System.Drawing.Size(236, 122);
            this.res_box.TabIndex = 7;
            this.res_box.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Вычислить результат";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 338);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.res_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB3);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "lab1";
            this.Text = "lab1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.TextBox TB2;
        private System.Windows.Forms.TextBox TB3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox res_box;
        private System.Windows.Forms.Button button1;
    }
}

