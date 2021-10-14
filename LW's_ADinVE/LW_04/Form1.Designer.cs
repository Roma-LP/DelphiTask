
namespace LW_04
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
            this.Label_row = new System.Windows.Forms.Label();
            this.TextBox_row = new System.Windows.Forms.TextBox();
            this.Label_column = new System.Windows.Forms.Label();
            this.TextBox_column = new System.Windows.Forms.TextBox();
            this.Matrix_1 = new System.Windows.Forms.DataGridView();
            this.Array_B = new System.Windows.Forms.DataGridView();
            this.Button_Create = new System.Windows.Forms.Button();
            this.Button_Random = new System.Windows.Forms.Button();
            this.Buttom_Calculate = new System.Windows.Forms.Button();
            this.Button_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Array_B)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_row
            // 
            this.Label_row.AutoSize = true;
            this.Label_row.Location = new System.Drawing.Point(11, 9);
            this.Label_row.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_row.Name = "Label_row";
            this.Label_row.Size = new System.Drawing.Size(168, 13);
            this.Label_row.TabIndex = 7;
            this.Label_row.Text = "Введите кол-во строк матрицы:";
            // 
            // TextBox_row
            // 
            this.TextBox_row.Location = new System.Drawing.Point(199, 6);
            this.TextBox_row.Name = "TextBox_row";
            this.TextBox_row.Size = new System.Drawing.Size(123, 20);
            this.TextBox_row.TabIndex = 6;
            // 
            // Label_column
            // 
            this.Label_column.AutoSize = true;
            this.Label_column.Location = new System.Drawing.Point(11, 39);
            this.Label_column.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_column.Name = "Label_column";
            this.Label_column.Size = new System.Drawing.Size(186, 13);
            this.Label_column.TabIndex = 9;
            this.Label_column.Text = "Введите кол-во столбцов матрицы:";
            // 
            // TextBox_column
            // 
            this.TextBox_column.Location = new System.Drawing.Point(199, 36);
            this.TextBox_column.Name = "TextBox_column";
            this.TextBox_column.Size = new System.Drawing.Size(123, 20);
            this.TextBox_column.TabIndex = 8;
            // 
            // Matrix_1
            // 
            this.Matrix_1.AllowUserToAddRows = false;
            this.Matrix_1.AllowUserToDeleteRows = false;
            this.Matrix_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Matrix_1.Location = new System.Drawing.Point(12, 62);
            this.Matrix_1.Name = "Matrix_1";
            this.Matrix_1.RowHeadersWidth = 65;
            this.Matrix_1.Size = new System.Drawing.Size(563, 342);
            this.Matrix_1.TabIndex = 10;
            // 
            // Array_B
            // 
            this.Array_B.ColumnHeadersHeight = 35;
            this.Array_B.Location = new System.Drawing.Point(581, 62);
            this.Array_B.Name = "Array_B";
            this.Array_B.ReadOnly = true;
            this.Array_B.RowHeadersWidth = 70;
            this.Array_B.Size = new System.Drawing.Size(172, 342);
            this.Array_B.TabIndex = 11;
            // 
            // Button_Create
            // 
            this.Button_Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Create.Location = new System.Drawing.Point(329, 6);
            this.Button_Create.Name = "Button_Create";
            this.Button_Create.Size = new System.Drawing.Size(246, 50);
            this.Button_Create.TabIndex = 12;
            this.Button_Create.Text = "Посторить матрицу";
            this.Button_Create.UseVisualStyleBackColor = true;
            this.Button_Create.Click += new System.EventHandler(this.Button_Create_Click);
            // 
            // Button_Random
            // 
            this.Button_Random.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Random.Location = new System.Drawing.Point(581, 6);
            this.Button_Random.Name = "Button_Random";
            this.Button_Random.Size = new System.Drawing.Size(172, 50);
            this.Button_Random.TabIndex = 13;
            this.Button_Random.Text = "Заполнить случайными числами";
            this.Button_Random.UseVisualStyleBackColor = true;
            this.Button_Random.Click += new System.EventHandler(this.Button_Random_Click);
            // 
            // Buttom_Calculate
            // 
            this.Buttom_Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Buttom_Calculate.Location = new System.Drawing.Point(12, 410);
            this.Buttom_Calculate.Name = "Buttom_Calculate";
            this.Buttom_Calculate.Size = new System.Drawing.Size(563, 50);
            this.Buttom_Calculate.TabIndex = 14;
            this.Buttom_Calculate.Text = "Вычислить";
            this.Buttom_Calculate.UseVisualStyleBackColor = true;
            this.Buttom_Calculate.Click += new System.EventHandler(this.Buttom_Calculate_Click);
            // 
            // Button_Exit
            // 
            this.Button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Exit.Location = new System.Drawing.Point(581, 410);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(172, 50);
            this.Button_Exit.TabIndex = 15;
            this.Button_Exit.Text = "Выход";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(760, 465);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Buttom_Calculate);
            this.Controls.Add(this.Button_Random);
            this.Controls.Add(this.Button_Create);
            this.Controls.Add(this.Array_B);
            this.Controls.Add(this.Matrix_1);
            this.Controls.Add(this.Label_column);
            this.Controls.Add(this.TextBox_column);
            this.Controls.Add(this.Label_row);
            this.Controls.Add(this.TextBox_row);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LW_04";
            ((System.ComponentModel.ISupportInitialize)(this.Matrix_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Array_B)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_row;
        private System.Windows.Forms.TextBox TextBox_row;
        private System.Windows.Forms.Label Label_column;
        private System.Windows.Forms.TextBox TextBox_column;
        private System.Windows.Forms.DataGridView Matrix_1;
        private System.Windows.Forms.DataGridView Array_B;
        private System.Windows.Forms.Button Button_Create;
        private System.Windows.Forms.Button Button_Random;
        private System.Windows.Forms.Button Buttom_Calculate;
        private System.Windows.Forms.Button Button_Exit;
    }
}

