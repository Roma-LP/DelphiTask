
namespace LW_05
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
            this.ComboBox_1 = new System.Windows.Forms.ComboBox();
            this.ListBox_Result = new System.Windows.Forms.ListBox();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Label_Result = new System.Windows.Forms.Label();
            this.Button_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComboBox_1
            // 
            this.ComboBox_1.FormattingEnabled = true;
            this.ComboBox_1.Items.AddRange(new object[] {
            "00111 01111 111100 110",
            "010101 11001 11100010 110 110",
            "11001 1010 0  101 111   1 100101   101011 10 1010",
            "1111 000 0011 000 1111 01 1111 00 1101"});
            this.ComboBox_1.Location = new System.Drawing.Point(12, 12);
            this.ComboBox_1.Name = "ComboBox_1";
            this.ComboBox_1.Size = new System.Drawing.Size(554, 21);
            this.ComboBox_1.TabIndex = 1;
            this.ComboBox_1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.СomboBox_1_KeyUp);
            // 
            // ListBox_Result
            // 
            this.ListBox_Result.FormattingEnabled = true;
            this.ListBox_Result.Location = new System.Drawing.Point(12, 40);
            this.ListBox_Result.Name = "ListBox_Result";
            this.ListBox_Result.Size = new System.Drawing.Size(554, 121);
            this.ListBox_Result.TabIndex = 2;
            this.ListBox_Result.SelectedIndexChanged += new System.EventHandler(this.ListBox_Result_SelectedIndexChanged);
            // 
            // Button_Add
            // 
            this.Button_Add.Location = new System.Drawing.Point(12, 167);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(155, 48);
            this.Button_Add.TabIndex = 3;
            this.Button_Add.Text = "Добавить";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Label_Result
            // 
            this.Label_Result.AutoSize = true;
            this.Label_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Result.Location = new System.Drawing.Point(9, 246);
            this.Label_Result.Name = "Label_Result";
            this.Label_Result.Size = new System.Drawing.Size(167, 16);
            this.Label_Result.TabIndex = 4;
            this.Label_Result.Text = "Самая короткая группа: ";
            // 
            // Button_exit
            // 
            this.Button_exit.Location = new System.Drawing.Point(429, 167);
            this.Button_exit.Name = "Button_exit";
            this.Button_exit.Size = new System.Drawing.Size(137, 48);
            this.Button_exit.TabIndex = 5;
            this.Button_exit.Text = "Выход";
            this.Button_exit.UseVisualStyleBackColor = true;
            this.Button_exit.Click += new System.EventHandler(this.Button_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(173, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите \'1\' или \'0\' или \' \' и нажмите Enter.\r\nВыберите необходимую строку ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(578, 278);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_exit);
            this.Controls.Add(this.Label_Result);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.ListBox_Result);
            this.Controls.Add(this.ComboBox_1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LW_05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ComboBox_1;
        private System.Windows.Forms.ListBox ListBox_Result;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Label Label_Result;
        private System.Windows.Forms.Button Button_exit;
        private System.Windows.Forms.Label label1;
    }
}

