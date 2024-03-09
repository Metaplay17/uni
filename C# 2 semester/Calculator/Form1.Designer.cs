namespace WindowsFormsApp1
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
            this.m1Box = new System.Windows.Forms.TextBox();
            this.m2Box = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.n1Box = new System.Windows.Forms.TextBox();
            this.n2Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // m1Box
            // 
            this.m1Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.m1Box.Location = new System.Drawing.Point(66, 77);
            this.m1Box.Name = "m1Box";
            this.m1Box.Size = new System.Drawing.Size(133, 34);
            this.m1Box.TabIndex = 0;
            // 
            // m2Box
            // 
            this.m2Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.m2Box.Location = new System.Drawing.Point(464, 77);
            this.m2Box.Name = "m2Box";
            this.m2Box.Size = new System.Drawing.Size(165, 34);
            this.m2Box.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBox1.Location = new System.Drawing.Point(242, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 37);
            this.comboBox1.TabIndex = 2;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ResultLabel.Location = new System.Drawing.Point(287, 234);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(81, 29);
            this.ResultLabel.TabIndex = 3;
            this.ResultLabel.Text = "Result";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.Location = new System.Drawing.Point(242, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // n1Box
            // 
            this.n1Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.n1Box.Location = new System.Drawing.Point(66, 128);
            this.n1Box.Name = "n1Box";
            this.n1Box.Size = new System.Drawing.Size(133, 34);
            this.n1Box.TabIndex = 5;
            // 
            // n2Box
            // 
            this.n2Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.n2Box.Location = new System.Drawing.Point(464, 128);
            this.n2Box.Name = "n2Box";
            this.n2Box.Size = new System.Drawing.Size(165, 34);
            this.n2Box.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.n2Box);
            this.Controls.Add(this.n1Box);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.m2Box);
            this.Controls.Add(this.m1Box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m1Box;
        private System.Windows.Forms.TextBox m2Box;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox n1Box;
        private System.Windows.Forms.TextBox n2Box;
    }
}

