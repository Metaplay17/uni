namespace Dz_2_novella
{
    partial class LastChallengeForm
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
            panel2 = new Panel();
            challengeButton = new Button();
            timeLabel = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(timeLabel);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Wheat;
            panel2.Controls.Add(challengeButton);
            panel2.Location = new Point(12, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 317);
            panel2.TabIndex = 2;
            panel2.MouseHover += panel2_MouseHover;
            panel2.MouseMove += panel2_MouseMove;
            // 
            // challengeButton
            // 
            challengeButton.Location = new Point(60, 47);
            challengeButton.Name = "challengeButton";
            challengeButton.Size = new Size(27, 27);
            challengeButton.TabIndex = 0;
            challengeButton.UseVisualStyleBackColor = true;
            challengeButton.Click += challengeButton_Click;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Segoe UI", 14F);
            timeLabel.Location = new Point(305, 76);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(66, 25);
            timeLabel.TabIndex = 1;
            timeLabel.Text = "30:000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(10, 20);
            label1.Name = "label1";
            label1.Size = new Size(778, 37);
            label1.TabIndex = 0;
            label1.Text = "You deserve this try. You have only 30 seconds to click on button";
            // 
            // LastChallengeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "LastChallengeForm";
            Text = "LastChallengeForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label timeLabel;
        private Label label1;
        private Panel panel2;
        private Button challengeButton;
    }
}