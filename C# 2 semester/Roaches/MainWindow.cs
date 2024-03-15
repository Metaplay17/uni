using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roaches
{
    public partial class MainForm : Form
    {
        private Label[] placeLabels;
        private Bitmap backgroundGif;
        private Game game;
        public MainForm()
        {
            InitializeComponent();
            placeLabels = new Label[] { placeLabel1, placeLabel2, placeLabel3, placeLabel4 };
            timer1.Tick += timer1_Tick;
            game = new Game(710, timer1);
        }
        private void HideLabels()
        {
            foreach (Label label in placeLabels)
            {
                label.Visible = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            againButton.Enabled = true;
            game.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            game.Draw(e.Graphics);
            if (game.GameActive)
            {
                game.Move();
                byte[] result = game.Results();
                for (byte i = 0; i < result.Length; i++)
                {
                    if (result[i] == 1)
                    {
                        backgroundGif = game.GetGif(i);
                    }
                    if (result[i] != 0) {
                        placeLabels[i].Text = result[i].ToString();
                        placeLabels[i].Visible = true;
                    }
                }
                if (game.CheckEnd())
                {
                    game.Stop();
                }
            }
        }

        private void againButton_Click(object sender, EventArgs e)
        {
            Refresh();
            if (!game.GameActive)
            {
                HideLabels();
                game.MoveToStart();
                Refresh();
                startButton.Enabled = true;
                againButton.Enabled = false;
                pictureBox1.Image = backgroundGif;
            }
        }
    }
}
