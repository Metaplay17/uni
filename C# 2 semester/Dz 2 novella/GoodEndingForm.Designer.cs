namespace Dz_2_novella
{
    partial class GoodEndingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            exitButton = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Linen;
            panel1.Controls.Add(exitButton);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 256);
            panel1.TabIndex = 0;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI", 32F);
            exitButton.Location = new Point(217, 147);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(301, 71);
            exitButton.TabIndex = 1;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(129, 30);
            label1.Name = "label1";
            label1.Size = new Size(498, 105);
            label1.TabIndex = 0;
            label1.Text = "You complete the challenge. Seems like success, my congratulations!";
            // 
            // GoodEndingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 256);
            Controls.Add(panel1);
            Name = "GoodEndingForm";
            Text = "GoodEndingForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button exitButton;
        private Label label1;
    }
}