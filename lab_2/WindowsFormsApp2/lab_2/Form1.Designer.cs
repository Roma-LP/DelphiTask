namespace lab_2
{
    partial class Main
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
            this.xbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sh = new System.Windows.Forms.RadioButton();
            this.ex = new System.Windows.Forms.RadioButton();
            this.x2 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resBox = new System.Windows.Forms.TextBox();
            this.CalButton = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "x =";
            // 
            // xbox
            // 
            this.xbox.Location = new System.Drawing.Point(35, 23);
            this.xbox.Name = "xbox";
            this.xbox.Size = new System.Drawing.Size(97, 20);
            this.xbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "b =";
            // 
            // bbox
            // 
            this.bbox.Location = new System.Drawing.Point(35, 66);
            this.bbox.Name = "bbox";
            this.bbox.Size = new System.Drawing.Size(97, 20);
            this.bbox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sh);
            this.groupBox1.Controls.Add(this.ex);
            this.groupBox1.Controls.Add(this.x2);
            this.groupBox1.Location = new System.Drawing.Point(165, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(72, 115);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "U(X)";
            // 
            // sh
            // 
            this.sh.AutoSize = true;
            this.sh.Location = new System.Drawing.Point(6, 19);
            this.sh.Name = "sh";
            this.sh.Size = new System.Drawing.Size(47, 17);
            this.sh.TabIndex = 6;
            this.sh.TabStop = true;
            this.sh.Text = "sh(x)";
            this.sh.UseVisualStyleBackColor = true;
            this.sh.CheckedChanged += new System.EventHandler(this.sh_CheckedChanged);
            // 
            // ex
            // 
            this.ex.AutoSize = true;
            this.ex.Location = new System.Drawing.Point(6, 65);
            this.ex.Name = "ex";
            this.ex.Size = new System.Drawing.Size(35, 17);
            this.ex.TabIndex = 8;
            this.ex.TabStop = true;
            this.ex.Text = "eˣ";
            this.ex.UseVisualStyleBackColor = true;
            this.ex.CheckedChanged += new System.EventHandler(this.sh_CheckedChanged);
            // 
            // x2
            // 
            this.x2.AutoSize = true;
            this.x2.Location = new System.Drawing.Point(6, 42);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(33, 17);
            this.x2.TabIndex = 7;
            this.x2.TabStop = true;
            this.x2.Text = "x²";
            this.x2.UseVisualStyleBackColor = true;
            this.x2.CheckedChanged += new System.EventHandler(this.sh_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.xbox);
            this.groupBox2.Controls.Add(this.bbox);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 115);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ввод данных";
            // 
            // resBox
            // 
            this.resBox.BackColor = System.Drawing.SystemColors.Window;
            this.resBox.Location = new System.Drawing.Point(12, 133);
            this.resBox.Multiline = true;
            this.resBox.Name = "resBox";
            this.resBox.ReadOnly = true;
            this.resBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resBox.Size = new System.Drawing.Size(225, 132);
            this.resBox.TabIndex = 11;
            // 
            // CalButton
            // 
            this.CalButton.Location = new System.Drawing.Point(12, 270);
            this.CalButton.Name = "CalButton";
            this.CalButton.Size = new System.Drawing.Size(225, 23);
            this.CalButton.TabIndex = 13;
            this.CalButton.Text = "Вычислить";
            this.CalButton.UseVisualStyleBackColor = true;
            this.CalButton.Click += new System.EventHandler(this.CalButton_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "sh(x)",
            "x²",
            "eˣ"});
            this.checkedListBox1.Location = new System.Drawing.Point(276, 31);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(65, 94);
            this.checkedListBox1.TabIndex = 15;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 305);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.CalButton);
            this.Controls.Add(this.resBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "lab2";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Main_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox xbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox resBox;
        private System.Windows.Forms.Button CalButton;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.RadioButton sh;
        private System.Windows.Forms.RadioButton ex;
        private System.Windows.Forms.RadioButton x2;
    }
}

