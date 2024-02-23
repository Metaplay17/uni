namespace Dz_2_novella
{
    partial class Next1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Next1));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            kickButton1 = new Button();
            kickButton2 = new Button();
            ignoreButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(ignoreButton);
            panel1.Controls.Add(kickButton2);
            panel1.Controls.Add(kickButton1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(75, 52);
            label1.Name = "label1";
            label1.Size = new Size(614, 54);
            label1.TabIndex = 0;
            label1.Text = "You hear somebody tells \"Kick this\"";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 130);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // kickButton1
            // 
            kickButton1.Font = new Font("Segoe UI", 16F);
            kickButton1.Location = new Point(12, 369);
            kickButton1.Name = "kickButton1";
            kickButton1.Size = new Size(160, 53);
            kickButton1.TabIndex = 2;
            kickButton1.Text = "Kick It";
            kickButton1.UseVisualStyleBackColor = true;
            // 
            // kickButton2
            // 
            kickButton2.Font = new Font("Segoe UI", 16F);
            kickButton2.Location = new Point(626, 369);
            kickButton2.Name = "kickButton2";
            kickButton2.Size = new Size(162, 53);
            kickButton2.TabIndex = 3;
            kickButton2.Text = "KICK IT!!!";
            kickButton2.UseVisualStyleBackColor = true;
            // 
            // ignoreButton
            // 
            ignoreButton.Font = new Font("Segoe UI", 16F);
            ignoreButton.Location = new Point(270, 369);
            ignoreButton.Name = "ignoreButton";
            ignoreButton.Size = new Size(277, 53);
            ignoreButton.TabIndex = 4;
            ignoreButton.Text = "Still ignore";
            ignoreButton.UseVisualStyleBackColor = true;
            // 
            // Next1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Next1";
            Text = "Next1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button ignoreButton;
        private Button kickButton2;
        private Button kickButton1;
    }
}