namespace _3_8
{
    partial class Main_F
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
            this.Search_B = new System.Windows.Forms.Button();
            this.Replace_B = new System.Windows.Forms.Button();
            this.Source_TB = new System.Windows.Forms.TextBox();
            this.Result_TB = new System.Windows.Forms.TextBox();
            this.Pattern_TB = new System.Windows.Forms.TextBox();
            this.Source_L = new System.Windows.Forms.Label();
            this.Pattern_L = new System.Windows.Forms.Label();
            this.Result_L = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Search_B
            // 
            this.Search_B.Location = new System.Drawing.Point(264, 97);
            this.Search_B.Name = "Search_B";
            this.Search_B.Size = new System.Drawing.Size(158, 23);
            this.Search_B.TabIndex = 0;
            this.Search_B.Text = "Поиск";
            this.Search_B.UseVisualStyleBackColor = true;
            this.Search_B.Click += new System.EventHandler(this.Search_B_Click);
            // 
            // Replace_B
            // 
            this.Replace_B.Location = new System.Drawing.Point(264, 127);
            this.Replace_B.Name = "Replace_B";
            this.Replace_B.Size = new System.Drawing.Size(158, 23);
            this.Replace_B.TabIndex = 1;
            this.Replace_B.Text = "Замена";
            this.Replace_B.UseVisualStyleBackColor = true;
            this.Replace_B.Click += new System.EventHandler(this.Replace_B_Click);
            // 
            // Source_TB
            // 
            this.Source_TB.Location = new System.Drawing.Point(12, 50);
            this.Source_TB.Multiline = true;
            this.Source_TB.Name = "Source_TB";
            this.Source_TB.Size = new System.Drawing.Size(208, 233);
            this.Source_TB.TabIndex = 2;
            // 
            // Result_TB
            // 
            this.Result_TB.Location = new System.Drawing.Point(471, 50);
            this.Result_TB.Multiline = true;
            this.Result_TB.Name = "Result_TB";
            this.Result_TB.ReadOnly = true;
            this.Result_TB.Size = new System.Drawing.Size(208, 233);
            this.Result_TB.TabIndex = 3;
            // 
            // Pattern_TB
            // 
            this.Pattern_TB.Location = new System.Drawing.Point(264, 50);
            this.Pattern_TB.Name = "Pattern_TB";
            this.Pattern_TB.Size = new System.Drawing.Size(158, 20);
            this.Pattern_TB.TabIndex = 4;
            // 
            // Source_L
            // 
            this.Source_L.AutoSize = true;
            this.Source_L.Location = new System.Drawing.Point(13, 31);
            this.Source_L.Name = "Source_L";
            this.Source_L.Size = new System.Drawing.Size(99, 13);
            this.Source_L.TabIndex = 5;
            this.Source_L.Text = "Исходные данные";
            // 
            // Pattern_L
            // 
            this.Pattern_L.AutoSize = true;
            this.Pattern_L.Location = new System.Drawing.Point(261, 31);
            this.Pattern_L.Name = "Pattern_L";
            this.Pattern_L.Size = new System.Drawing.Size(152, 13);
            this.Pattern_L.TabIndex = 6;
            this.Pattern_L.Text = "Параметры шаблона поиска";
            // 
            // Result_L
            // 
            this.Result_L.AutoSize = true;
            this.Result_L.Location = new System.Drawing.Point(468, 31);
            this.Result_L.Name = "Result_L";
            this.Result_L.Size = new System.Drawing.Size(59, 13);
            this.Result_L.TabIndex = 7;
            this.Result_L.Text = "Результат";
            // 
            // Main_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 320);
            this.Controls.Add(this.Result_L);
            this.Controls.Add(this.Pattern_L);
            this.Controls.Add(this.Source_L);
            this.Controls.Add(this.Pattern_TB);
            this.Controls.Add(this.Result_TB);
            this.Controls.Add(this.Source_TB);
            this.Controls.Add(this.Replace_B);
            this.Controls.Add(this.Search_B);
            this.Name = "Main_F";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search_B;
        private System.Windows.Forms.Button Replace_B;
        private System.Windows.Forms.TextBox Source_TB;
        private System.Windows.Forms.TextBox Result_TB;
        private System.Windows.Forms.TextBox Pattern_TB;
        private System.Windows.Forms.Label Source_L;
        private System.Windows.Forms.Label Pattern_L;
        private System.Windows.Forms.Label Result_L;
    }
}

