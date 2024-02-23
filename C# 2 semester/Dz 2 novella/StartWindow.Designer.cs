namespace Dz_2_novella
{
    partial class StartWindow
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartWindow));
            panel1 = new Panel();
            button3 = new Button();
            KickButton2 = new Button();
            KickButton1 = new Button();
            mainPicture1 = new PictureBox();
            label1 = new Label();
            imageList1 = new ImageList(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainPicture1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Plum;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(KickButton2);
            panel1.Controls.Add(KickButton1);
            panel1.Controls.Add(mainPicture1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 338);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F);
            button3.Location = new Point(290, 266);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(112, 40);
            button3.TabIndex = 4;
            button3.Text = "Ignore.";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // KickButton2
            // 
            KickButton2.Font = new Font("Segoe UI", 14F);
            KickButton2.Location = new Point(573, 266);
            KickButton2.Margin = new Padding(3, 2, 3, 2);
            KickButton2.Name = "KickButton2";
            KickButton2.Size = new Size(108, 40);
            KickButton2.TabIndex = 3;
            KickButton2.Text = "KICK IT!!!";
            KickButton2.UseVisualStyleBackColor = true;
            KickButton2.Click += KickButton1_Click;
            // 
            // KickButton1
            // 
            KickButton1.Font = new Font("Segoe UI", 14F);
            KickButton1.Location = new Point(10, 266);
            KickButton1.Margin = new Padding(3, 2, 3, 2);
            KickButton1.Name = "KickButton1";
            KickButton1.Size = new Size(112, 40);
            KickButton1.TabIndex = 2;
            KickButton1.Text = "Kick It!";
            KickButton1.UseVisualStyleBackColor = true;
            KickButton1.Click += KickButton1_Click;
            // 
            // mainPicture1
            // 
            mainPicture1.Image = (Image)resources.GetObject("mainPicture1.Image");
            mainPicture1.Location = new Point(10, 82);
            mainPicture1.Margin = new Padding(3, 2, 3, 2);
            mainPicture1.Name = "mainPicture1";
            mainPicture1.Size = new Size(679, 144);
            mainPicture1.SizeMode = PictureBoxSizeMode.StretchImage;
            mainPicture1.TabIndex = 1;
            mainPicture1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(178, 46);
            label1.Name = "label1";
            label1.Size = new Size(362, 34);
            label1.TabIndex = 0;
            label1.Text = "You see volleyball ball";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // StartWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StartWindow";
            Text = "Start";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainPicture1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ImageList imageList1;
        private PictureBox mainPicture1;
        private Button button3;
        private Button KickButton2;
        private Button KickButton1;
    }
}
