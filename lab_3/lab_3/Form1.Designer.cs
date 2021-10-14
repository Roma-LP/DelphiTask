namespace lab_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.x0_box = new System.Windows.Forms.TextBox();
            this.xk_box = new System.Windows.Forms.TextBox();
            this.resBox = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.N_box = new System.Windows.Forms.TextBox();
            this.m_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nn_box = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // x0_box
            // 
            this.x0_box.Location = new System.Drawing.Point(51, 149);
            this.x0_box.Name = "x0_box";
            this.x0_box.Size = new System.Drawing.Size(158, 20);
            this.x0_box.TabIndex = 0;
            this.x0_box.Text = "0";
            // 
            // xk_box
            // 
            this.xk_box.Location = new System.Drawing.Point(51, 197);
            this.xk_box.Name = "xk_box";
            this.xk_box.Size = new System.Drawing.Size(158, 20);
            this.xk_box.TabIndex = 2;
            this.xk_box.Text = "2";
            // 
            // resBox
            // 
            this.resBox.Location = new System.Drawing.Point(248, 149);
            this.resBox.Multiline = true;
            this.resBox.Name = "resBox";
            this.resBox.Size = new System.Drawing.Size(248, 164);
            this.resBox.TabIndex = 4;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(12, 319);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(521, 23);
            this.Calculate.TabIndex = 5;
            this.Calculate.Text = "Рассчитать";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "x0 =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Xk =";
            // 
            // N_box
            // 
            this.N_box.Location = new System.Drawing.Point(51, 245);
            this.N_box.Name = "N_box";
            this.N_box.Size = new System.Drawing.Size(158, 20);
            this.N_box.TabIndex = 10;
            this.N_box.Text = "15";
            // 
            // m_box
            // 
            this.m_box.Location = new System.Drawing.Point(51, 293);
            this.m_box.Name = "m_box";
            this.m_box.Size = new System.Drawing.Size(158, 20);
            this.m_box.TabIndex = 11;
            this.m_box.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "N(раз)";
            // 
            // nn_box
            // 
            this.nn_box.AutoSize = true;
            this.nn_box.Location = new System.Drawing.Point(9, 98);
            this.nn_box.Name = "nn_box";
            this.nn_box.Size = new System.Drawing.Size(0, 13);
            this.nn_box.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "M(ф) =";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(483, 98);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 354);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nn_box);
            this.Controls.Add(this.m_box);
            this.Controls.Add(this.N_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.resBox);
            this.Controls.Add(this.xk_box);
            this.Controls.Add(this.x0_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Lab 3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox x0_box;
        private System.Windows.Forms.TextBox xk_box;
        private System.Windows.Forms.TextBox resBox;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox N_box;
        private System.Windows.Forms.TextBox m_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nn_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

