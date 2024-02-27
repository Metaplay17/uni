namespace Dz_2_novella
{
    partial class FinalChoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalChoiceForm));
            panel1 = new Panel();
            button2 = new Button();
            kickButton = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSalmon;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(kickButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 600);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 32F);
            button2.Location = new Point(437, 397);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(464, 187);
            button2.TabIndex = 3;
            button2.Text = "Just continue to ignore";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // kickButton
            // 
            kickButton.Font = new Font("Segoe UI", 32F);
            kickButton.Location = new Point(14, 397);
            kickButton.Margin = new Padding(3, 4, 3, 4);
            kickButton.Name = "kickButton";
            kickButton.Size = new Size(416, 187);
            kickButton.TabIndex = 2;
            kickButton.Text = "FINALLY KICK THIS";
            kickButton.UseVisualStyleBackColor = true;
            kickButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(102, 25);
            label1.Name = "label1";
            label1.Size = new Size(699, 123);
            label1.TabIndex = 1;
            label1.Text = "Now your coach is watching what you with this ball and now you have only two choices:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 171);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(887, 195);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FinalChoiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FinalChoiceForm";
            Text = "FinalChoiceForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button kickButton;
        private Button button2;
    }
}