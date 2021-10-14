
namespace LW_01
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
            this.TextBox_X = new System.Windows.Forms.TextBox();
            this.Label_x = new System.Windows.Forms.Label();
            this.Label_y = new System.Windows.Forms.Label();
            this.TextBox_Y = new System.Windows.Forms.TextBox();
            this.Label_z = new System.Windows.Forms.Label();
            this.TextBox_Z = new System.Windows.Forms.TextBox();
            this.Label_Result = new System.Windows.Forms.Label();
            this.TextBox_Result = new System.Windows.Forms.TextBox();
            this.Button_Do = new System.Windows.Forms.Button();
            this.PictureBox_1 = new System.Windows.Forms.PictureBox();
            this.Button_Clear = new System.Windows.Forms.Button();
            this.Button_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_X
            // 
            this.TextBox_X.Location = new System.Drawing.Point(201, 104);
            this.TextBox_X.Name = "TextBox_X";
            this.TextBox_X.Size = new System.Drawing.Size(100, 23);
            this.TextBox_X.TabIndex = 0;
            this.TextBox_X.Text = "0";
            // 
            // Label_x
            // 
            this.Label_x.AutoSize = true;
            this.Label_x.Location = new System.Drawing.Point(78, 107);
            this.Label_x.Name = "Label_x";
            this.Label_x.Size = new System.Drawing.Size(117, 15);
            this.Label_x.TabIndex = 1;
            this.Label_x.Text = "Введите значение X:";
            // 
            // Label_y
            // 
            this.Label_y.AutoSize = true;
            this.Label_y.Location = new System.Drawing.Point(78, 145);
            this.Label_y.Name = "Label_y";
            this.Label_y.Size = new System.Drawing.Size(117, 15);
            this.Label_y.TabIndex = 2;
            this.Label_y.Text = "Введите значение Y:";
            // 
            // TextBox_Y
            // 
            this.TextBox_Y.Location = new System.Drawing.Point(201, 141);
            this.TextBox_Y.Name = "TextBox_Y";
            this.TextBox_Y.Size = new System.Drawing.Size(100, 23);
            this.TextBox_Y.TabIndex = 3;
            this.TextBox_Y.Text = "0";
            // 
            // Label_z
            // 
            this.Label_z.AutoSize = true;
            this.Label_z.Location = new System.Drawing.Point(78, 186);
            this.Label_z.Name = "Label_z";
            this.Label_z.Size = new System.Drawing.Size(117, 15);
            this.Label_z.TabIndex = 4;
            this.Label_z.Text = "Введите значение Z:";
            // 
            // TextBox_Z
            // 
            this.TextBox_Z.Location = new System.Drawing.Point(201, 183);
            this.TextBox_Z.Name = "TextBox_Z";
            this.TextBox_Z.Size = new System.Drawing.Size(100, 23);
            this.TextBox_Z.TabIndex = 5;
            this.TextBox_Z.Text = "0";
            // 
            // Label_Result
            // 
            this.Label_Result.AutoSize = true;
            this.Label_Result.Location = new System.Drawing.Point(78, 224);
            this.Label_Result.Name = "Label_Result";
            this.Label_Result.Size = new System.Drawing.Size(216, 15);
            this.Label_Result.TabIndex = 6;
            this.Label_Result.Text = "Результаты выполнения программы: ";
            // 
            // TextBox_Result
            // 
            this.TextBox_Result.Location = new System.Drawing.Point(78, 256);
            this.TextBox_Result.Multiline = true;
            this.TextBox_Result.Name = "TextBox_Result";
            this.TextBox_Result.ReadOnly = true;
            this.TextBox_Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_Result.Size = new System.Drawing.Size(223, 182);
            this.TextBox_Result.TabIndex = 7;
            // 
            // Button_Do
            // 
            this.Button_Do.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Do.Location = new System.Drawing.Point(78, 444);
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
            this.PictureBox_1.Location = new System.Drawing.Point(78, 12);
            this.PictureBox_1.Name = "PictureBox_1";
            this.PictureBox_1.Size = new System.Drawing.Size(223, 86);
            this.PictureBox_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_1.TabIndex = 9;
            this.PictureBox_1.TabStop = false;
            // 
            // Button_Clear
            // 
            this.Button_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Clear.Location = new System.Drawing.Point(78, 491);
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
            this.Button_Exit.Location = new System.Drawing.Point(194, 491);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(107, 41);
            this.Button_Exit.TabIndex = 11;
            this.Button_Exit.Text = "Выход";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(383, 568);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Button_Clear);
            this.Controls.Add(this.PictureBox_1);
            this.Controls.Add(this.Button_Do);
            this.Controls.Add(this.TextBox_Result);
            this.Controls.Add(this.Label_Result);
            this.Controls.Add(this.TextBox_Z);
            this.Controls.Add(this.Label_z);
            this.Controls.Add(this.TextBox_Y);
            this.Controls.Add(this.Label_y);
            this.Controls.Add(this.Label_x);
            this.Controls.Add(this.TextBox_X);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LW_01";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_X;
        private System.Windows.Forms.Label Label_x;
        private System.Windows.Forms.Label Label_y;
        private System.Windows.Forms.TextBox TextBox_Y;
        private System.Windows.Forms.Label Label_z;
        private System.Windows.Forms.TextBox TextBox_Z;
        private System.Windows.Forms.Label Label_Result;
        private System.Windows.Forms.TextBox TextBox_Result;
        private System.Windows.Forms.Button Button_Do;
        private System.Windows.Forms.PictureBox PictureBox_1;
        private System.Windows.Forms.Button Button_Clear;
        private System.Windows.Forms.Button Button_Exit;
    }
}

