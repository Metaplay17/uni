using System;
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
        Panel[] panels;
        Character[] characters;
        Label[] placeLabels;
        int[] positions;
        short place;
        int maxX;
        short leadInd;
        Bitmap backgroundGif;
        public MainForm()
        {
            InitializeComponent();
            positions = new int[] { 56, 147, 231, 321 };
            // positions = positions.OrderBy(x => RandomGenerator.GetRandomNumber(0, 100)).ToArray();
            maxX = 0;
            leadInd = 0;
            characters = new Character[] { new Character(Properties.Resources.furina, Properties.Resources.FurinaGif, positions[0]), new Character(Properties.Resources.zhongli, Properties.Resources.zhongliGif, positions[1]), new Character(Properties.Resources.raiden, Properties.Resources.RaidenShogunGif, positions[2]), new Character(Properties.Resources.keqing, Properties.Resources.KeqingGif, positions[3]) };
            placeLabels = new Label[] { placeLabel1, placeLabel2, placeLabel3, placeLabel4 };
            place = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            againButton.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            if (timer1.Enabled)
            {
                for (short i = 0; i < characters.Length; i++)
                {
                    if (!characters[i].IsFinished())
                    {
                        characters[i].Move();
                        if (characters[i].GetX() >= maxX)
                        {
                            maxX = characters[i].GetX();
                            leadInd = (short)(i + 1);
                        }
                    }
                    if (characters[i].IsFinished() && placeLabels[i].Enabled)
                    {
                        placeLabels[i].Text = place.ToString();
                        if (place == 1)
                        {
                            backgroundGif = characters[i].GetGif();
                        }
                        placeLabels[i].Visible = true;
                        placeLabels[i].Enabled = false;
                        place++;
                    }
                    characters[i].Draw(e.Graphics);
                }
                leadLabel.Text = leadInd.ToString();
                if (place == 5)
                {
                    leadLabel.Visible = false;
                    label1.Visible = false;
                    timer1.Stop();
                }
            }
            else
            {
                for (short i = 0; i < characters.Length; i++)
                {
                    characters[i].MoveToStart();
                    characters[i].Draw(e.Graphics);
                }
            }
        }

        private void againButton_Click(object sender, EventArgs e)
        {
            Refresh();
            for (short i = 0; i < characters.Length; i++)
            {
                characters[i].MoveToStart();
                placeLabel1.Visible = false;
                placeLabel1.Enabled = true;

                placeLabel2.Visible = false;
                placeLabel2.Enabled = true;

                placeLabel3.Visible = false;
                placeLabel3.Enabled = true;

                placeLabel4.Visible = false;
                placeLabel4.Enabled = true;
            }
            leadLabel.Visible = true;
            leadLabel.Text = "Not started";
            label1.Visible = true;
            place = 1;
            maxX = 0;
            leadInd = 0;
            button1.Enabled = true;
            pictureBox1.Image = backgroundGif;
        }
    }
}
