
namespace LW_07
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TextBox_xn = new System.Windows.Forms.TextBox();
            this.Label_xn = new System.Windows.Forms.Label();
            this.Label_xk = new System.Windows.Forms.Label();
            this.TextBox_xk = new System.Windows.Forms.TextBox();
            this.Label_Result = new System.Windows.Forms.Label();
            this.TextBox_Result = new System.Windows.Forms.TextBox();
            this.Button_Do = new System.Windows.Forms.Button();
            this.PictureBox_1 = new System.Windows.Forms.PictureBox();
            this.Button_Clear = new System.Windows.Forms.Button();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Label_n = new System.Windows.Forms.Label();
            this.TextBox_n = new System.Windows.Forms.TextBox();
            this.LB_XN = new System.Windows.Forms.Label();
            this.LB_XK = new System.Windows.Forms.Label();
            this.LB_SX = new System.Windows.Forms.Label();
            this.LB_N = new System.Windows.Forms.Label();
            this.LB_YX = new System.Windows.Forms.Label();
            this.GroupBox_1 = new System.Windows.Forms.GroupBox();
            this.RadioButton_1 = new System.Windows.Forms.RadioButton();
            this.RadioButton_2 = new System.Windows.Forms.RadioButton();
            this.RadioButton_0 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_1)).BeginInit();
            this.GroupBox_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox_xn
            // 
            this.TextBox_xn.Location = new System.Drawing.Point(210, 118);
            this.TextBox_xn.Name = "TextBox_xn";
            this.TextBox_xn.Size = new System.Drawing.Size(91, 23);
            this.TextBox_xn.TabIndex = 0;
            this.TextBox_xn.Text = "0,1";
            // 
            // Label_xn
            // 
            this.Label_xn.AutoSize = true;
            this.Label_xn.Location = new System.Drawing.Point(78, 121);
            this.Label_xn.Name = "Label_xn";
            this.Label_xn.Size = new System.Drawing.Size(129, 15);
            this.Label_xn.TabIndex = 1;
            this.Label_xn.Text = "Введите значение X_n:";
            // 
            // Label_xk
            // 
            this.Label_xk.AutoSize = true;
            this.Label_xk.Location = new System.Drawing.Point(78, 159);
            this.Label_xk.Name = "Label_xk";
            this.Label_xk.Size = new System.Drawing.Size(128, 15);
            this.Label_xk.TabIndex = 2;
            this.Label_xk.Text = "Введите значение X_k:";
            // 
            // TextBox_xk
            // 
            this.TextBox_xk.Location = new System.Drawing.Point(210, 155);
            this.TextBox_xk.Name = "TextBox_xk";
            this.TextBox_xk.Size = new System.Drawing.Size(91, 23);
            this.TextBox_xk.TabIndex = 3;
            this.TextBox_xk.Text = "1";
            // 
            // Label_Result
            // 
            this.Label_Result.AutoSize = true;
            this.Label_Result.Location = new System.Drawing.Point(78, 246);
            this.Label_Result.Name = "Label_Result";
            this.Label_Result.Size = new System.Drawing.Size(216, 15);
            this.Label_Result.TabIndex = 6;
            this.Label_Result.Text = "Результаты выполнения программы: ";
            // 
            // TextBox_Result
            // 
            this.TextBox_Result.Location = new System.Drawing.Point(78, 278);
            this.TextBox_Result.Multiline = true;
            this.TextBox_Result.Name = "TextBox_Result";
            this.TextBox_Result.ReadOnly = true;
            this.TextBox_Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_Result.Size = new System.Drawing.Size(223, 197);
            this.TextBox_Result.TabIndex = 7;
            // 
            // Button_Do
            // 
            this.Button_Do.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Do.Location = new System.Drawing.Point(78, 481);
            this.Button_Do.Name = "Button_Do";
            this.Button_Do.Size = new System.Drawing.Size(223, 41);
            this.Button_Do.TabIndex = 8;
            this.Button_Do.Text = "Вычислить";
            this.Button_Do.UseVisualStyleBackColor = true;
            this.Button_Do.Click += new System.EventHandler(this.Button_Do_Click);
            // 
            // PictureBox_1
            // 
            this.PictureBox_1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox_1.Image")));
            this.PictureBox_1.InitialImage = null;
            this.PictureBox_1.Location = new System.Drawing.Point(0, 12);
            this.PictureBox_1.Name = "PictureBox_1";
            this.PictureBox_1.Size = new System.Drawing.Size(530, 92);
            this.PictureBox_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_1.TabIndex = 9;
            this.PictureBox_1.TabStop = false;
            // 
            // Button_Clear
            // 
            this.Button_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Clear.Location = new System.Drawing.Point(78, 528);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(107, 41);
            this.Button_Clear.TabIndex = 10;
            this.Button_Clear.Text = "Очистить";
            this.Button_Clear.UseVisualStyleBackColor = true;
            this.Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // Button_Exit
            // 
            this.Button_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Exit.Location = new System.Drawing.Point(194, 528);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(107, 41);
            this.Button_Exit.TabIndex = 11;
            this.Button_Exit.Text = "Выход";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Label_n
            // 
            this.Label_n.AutoSize = true;
            this.Label_n.Location = new System.Drawing.Point(78, 197);
            this.Label_n.Name = "Label_n";
            this.Label_n.Size = new System.Drawing.Size(119, 15);
            this.Label_n.TabIndex = 13;
            this.Label_n.Text = "Введите значение N:";
            // 
            // TextBox_n
            // 
            this.TextBox_n.Location = new System.Drawing.Point(210, 194);
            this.TextBox_n.Name = "TextBox_n";
            this.TextBox_n.Size = new System.Drawing.Size(91, 23);
            this.TextBox_n.TabIndex = 12;
            this.TextBox_n.Text = "10";
            // 
            // LB_XN
            // 
            this.LB_XN.AutoSize = true;
            this.LB_XN.Location = new System.Drawing.Point(12, 12);
            this.LB_XN.Name = "LB_XN";
            this.LB_XN.Size = new System.Drawing.Size(21, 15);
            this.LB_XN.TabIndex = 14;
            this.LB_XN.Text = "Xn";
            // 
            // LB_XK
            // 
            this.LB_XK.AutoSize = true;
            this.LB_XK.Location = new System.Drawing.Point(57, 12);
            this.LB_XK.Name = "LB_XK";
            this.LB_XK.Size = new System.Drawing.Size(20, 15);
            this.LB_XK.TabIndex = 15;
            this.LB_XK.Text = "Xk";
            // 
            // LB_SX
            // 
            this.LB_SX.AutoSize = true;
            this.LB_SX.Location = new System.Drawing.Point(179, 9);
            this.LB_SX.Name = "LB_SX";
            this.LB_SX.Size = new System.Drawing.Size(28, 15);
            this.LB_SX.TabIndex = 16;
            this.LB_SX.Text = "S(X)";
            // 
            // LB_N
            // 
            this.LB_N.AutoSize = true;
            this.LB_N.Location = new System.Drawing.Point(325, 9);
            this.LB_N.Name = "LB_N";
            this.LB_N.Size = new System.Drawing.Size(16, 15);
            this.LB_N.TabIndex = 17;
            this.LB_N.Text = "N";
            // 
            // LB_YX
            // 
            this.LB_YX.AutoSize = true;
            this.LB_YX.Location = new System.Drawing.Point(424, 12);
            this.LB_YX.Name = "LB_YX";
            this.LB_YX.Size = new System.Drawing.Size(29, 15);
            this.LB_YX.TabIndex = 18;
            this.LB_YX.Text = "Y(X)";
            // 
            // GroupBox_1
            // 
            this.GroupBox_1.Controls.Add(this.RadioButton_1);
            this.GroupBox_1.Controls.Add(this.RadioButton_2);
            this.GroupBox_1.Controls.Add(this.RadioButton_0);
            this.GroupBox_1.Location = new System.Drawing.Point(307, 118);
            this.GroupBox_1.Name = "GroupBox_1";
            this.GroupBox_1.Size = new System.Drawing.Size(223, 58);
            this.GroupBox_1.TabIndex = 19;
            this.GroupBox_1.TabStop = false;
            this.GroupBox_1.Text = "Y(x)";
            // 
            // RadioButton_1
            // 
            this.RadioButton_1.AutoSize = true;
            this.RadioButton_1.Location = new System.Drawing.Point(92, 23);
            this.RadioButton_1.Name = "RadioButton_1";
            this.RadioButton_1.Size = new System.Drawing.Size(45, 19);
            this.RadioButton_1.TabIndex = 3;
            this.RadioButton_1.TabStop = true;
            this.RadioButton_1.Text = "x^2";
            this.RadioButton_1.UseVisualStyleBackColor = true;
            // 
            // RadioButton_2
            // 
            this.RadioButton_2.AutoSize = true;
            this.RadioButton_2.Location = new System.Drawing.Point(171, 23);
            this.RadioButton_2.Name = "RadioButton_2";
            this.RadioButton_2.Size = new System.Drawing.Size(45, 19);
            this.RadioButton_2.TabIndex = 2;
            this.RadioButton_2.TabStop = true;
            this.RadioButton_2.Text = "e^x";
            this.RadioButton_2.UseVisualStyleBackColor = true;
            // 
            // RadioButton_0
            // 
            this.RadioButton_0.AutoSize = true;
            this.RadioButton_0.Location = new System.Drawing.Point(7, 23);
            this.RadioButton_0.Name = "RadioButton_0";
            this.RadioButton_0.Size = new System.Drawing.Size(51, 19);
            this.RadioButton_0.TabIndex = 0;
            this.RadioButton_0.TabStop = true;
            this.RadioButton_0.Text = "sh(x)";
            this.RadioButton_0.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(540, 585);
            this.Controls.Add(this.GroupBox_1);
            this.Controls.Add(this.LB_YX);
            this.Controls.Add(this.LB_N);
            this.Controls.Add(this.LB_SX);
            this.Controls.Add(this.LB_XK);
            this.Controls.Add(this.LB_XN);
            this.Controls.Add(this.Label_n);
            this.Controls.Add(this.TextBox_n);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Button_Clear);
            this.Controls.Add(this.PictureBox_1);
            this.Controls.Add(this.Button_Do);
            this.Controls.Add(this.TextBox_Result);
            this.Controls.Add(this.Label_Result);
            this.Controls.Add(this.TextBox_xk);
            this.Controls.Add(this.Label_xk);
            this.Controls.Add(this.Label_xn);
            this.Controls.Add(this.TextBox_xn);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LW_07";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_1)).EndInit();
            this.GroupBox_1.ResumeLayout(false);
            this.GroupBox_1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_xn;
        private System.Windows.Forms.Label Label_xn;
        private System.Windows.Forms.Label Label_xk;
        private System.Windows.Forms.TextBox TextBox_xk;
        private System.Windows.Forms.Label Label_Result;
        private System.Windows.Forms.TextBox TextBox_Result;
        private System.Windows.Forms.Button Button_Do;
        private System.Windows.Forms.PictureBox PictureBox_1;
        private System.Windows.Forms.Button Button_Clear;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.Label Label_n;
        private System.Windows.Forms.TextBox TextBox_n;
        private System.Windows.Forms.Label LB_XN;
        private System.Windows.Forms.Label LB_XK;
        private System.Windows.Forms.Label LB_SX;
        private System.Windows.Forms.Label LB_N;
        private System.Windows.Forms.Label LB_YX;
        private System.Windows.Forms.GroupBox GroupBox_1;
        private System.Windows.Forms.RadioButton RadioButton_1;
        private System.Windows.Forms.RadioButton RadioButton_2;
        private System.Windows.Forms.RadioButton RadioButton_0;
    }
}

