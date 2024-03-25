namespace WorkspaceTuning
{
    partial class MainWindow
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            monitorComboBox = new ComboBox();
            mouseComboBox = new ComboBox();
            keyboardComboBox = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(885, 12);
            label1.Name = "label1";
            label1.Size = new Size(191, 29);
            label1.TabIndex = 3;
            label1.Text = "Workspace Tuning";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(761, 64);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 4;
            label2.Text = "Monitor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(761, 120);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 5;
            label3.Text = "Mouse";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(761, 178);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 6;
            label4.Text = "Keyboard";
            // 
            // monitorComboBox
            // 
            monitorComboBox.Font = new Font("Segoe UI", 14F);
            monitorComboBox.FormattingEnabled = true;
            monitorComboBox.Items.AddRange(new object[] { "Old Monitor", "New Monitor" });
            monitorComboBox.Location = new Point(885, 61);
            monitorComboBox.Name = "monitorComboBox";
            monitorComboBox.Size = new Size(230, 33);
            monitorComboBox.TabIndex = 7;
            monitorComboBox.SelectedIndexChanged += monitorComboBox_SelectedIndexChanged;
            // 
            // mouseComboBox
            // 
            mouseComboBox.Font = new Font("Segoe UI", 14F);
            mouseComboBox.FormattingEnabled = true;
            mouseComboBox.Items.AddRange(new object[] { "Strange Mouse", "Cool Mouse" });
            mouseComboBox.Location = new Point(885, 117);
            mouseComboBox.Name = "mouseComboBox";
            mouseComboBox.Size = new Size(230, 33);
            mouseComboBox.TabIndex = 8;
            mouseComboBox.SelectedIndexChanged += mouseComboBox_SelectedIndexChanged;
            // 
            // keyboardComboBox
            // 
            keyboardComboBox.Font = new Font("Segoe UI", 14F);
            keyboardComboBox.FormattingEnabled = true;
            keyboardComboBox.Items.AddRange(new object[] { "Poor Keyboard", "Rich Keyboard" });
            keyboardComboBox.Location = new Point(885, 175);
            keyboardComboBox.Name = "keyboardComboBox";
            keyboardComboBox.Size = new Size(230, 33);
            keyboardComboBox.TabIndex = 9;
            keyboardComboBox.SelectedIndexChanged += keyboardComboBox_SelectedIndexChanged;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1238, 450);
            Controls.Add(keyboardComboBox);
            Controls.Add(mouseComboBox);
            Controls.Add(monitorComboBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "MainWindow";
            Text = "Form1";
            Paint += Form1_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox keyboardBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox monitorComboBox;
        private ComboBox mouseComboBox;
        private ComboBox keyboardComboBox;
    }
}
