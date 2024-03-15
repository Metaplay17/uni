namespace ShapesColors
{
    partial class MainWindow
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
            this.RectangleButton = new System.Windows.Forms.RadioButton();
            this.EllipseButton = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RectangleButton
            // 
            this.RectangleButton.AutoSize = true;
            this.RectangleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RectangleButton.Location = new System.Drawing.Point(21, 30);
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(120, 29);
            this.RectangleButton.TabIndex = 0;
            this.RectangleButton.TabStop = true;
            this.RectangleButton.Text = "Rectangle";
            this.RectangleButton.UseVisualStyleBackColor = true;
            // 
            // EllipseButton
            // 
            this.EllipseButton.AutoSize = true;
            this.EllipseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EllipseButton.Location = new System.Drawing.Point(193, 30);
            this.EllipseButton.Name = "EllipseButton";
            this.EllipseButton.Size = new System.Drawing.Size(90, 29);
            this.EllipseButton.TabIndex = 1;
            this.EllipseButton.TabStop = true;
            this.EllipseButton.Text = "Ellipse";
            this.EllipseButton.UseVisualStyleBackColor = true;
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(193, 91);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(90, 44);
            this.colorButton.TabIndex = 2;
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(27, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select color";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.EllipseButton);
            this.Controls.Add(this.RectangleButton);
            this.Name = "MainWindow";
            this.Text = "ShapesColors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RectangleButton;
        private System.Windows.Forms.RadioButton EllipseButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Label label1;
    }
}

