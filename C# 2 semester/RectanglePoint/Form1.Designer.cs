namespace SeminarOOPForms
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
            this.rectangleButton = new System.Windows.Forms.RadioButton();
            this.pointButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rectangleButton
            // 
            this.rectangleButton.AutoSize = true;
            this.rectangleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.rectangleButton.Location = new System.Drawing.Point(110, 404);
            this.rectangleButton.Margin = new System.Windows.Forms.Padding(4);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(143, 33);
            this.rectangleButton.TabIndex = 3;
            this.rectangleButton.TabStop = true;
            this.rectangleButton.Text = "Rectangle";
            this.rectangleButton.UseVisualStyleBackColor = true;
            // 
            // pointButton
            // 
            this.pointButton.AutoSize = true;
            this.pointButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.pointButton.Location = new System.Drawing.Point(13, 401);
            this.pointButton.Margin = new System.Windows.Forms.Padding(4);
            this.pointButton.Name = "pointButton";
            this.pointButton.Size = new System.Drawing.Size(89, 33);
            this.pointButton.TabIndex = 4;
            this.pointButton.TabStop = true;
            this.pointButton.Text = "Point";
            this.pointButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pointButton);
            this.Controls.Add(this.rectangleButton);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rectangleButton;
        private System.Windows.Forms.RadioButton pointButton;
    }
}

