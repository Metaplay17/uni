using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dz_2_novella
{
    public partial class LastChallengeForm : Form
    {
        Random random;
        System.Windows.Forms.Timer timer;
        System.Windows.Forms.Timer buttonTimer;
        int elapsedMseconds;
        EndForm endForm;
        GoodEndingForm goodForm;
        public LastChallengeForm(EndForm endForm)
        {
            InitializeComponent();
            goodForm = new GoodEndingForm();
            random = new Random();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 100;
            timer.Start();

            buttonTimer = new System.Windows.Forms.Timer();
            buttonTimer.Interval = 50;

            this.endForm = endForm;

            timer.Tick += Timer_Tick;
            buttonTimer.Tick += ButtonTimer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            elapsedMseconds += 100;

            int seconds = elapsedMseconds / 1000;
            int milliseconds = elapsedMseconds % 100;

            timeLabel.Text = $"{seconds}:{milliseconds}";

            if (seconds == 30)
            {
                endForm.Show();
                this.Hide();
            }
        }

        private void ButtonTimer_Tick(object sender, EventArgs e)
        {
            int maxX = panel2.Width;
            int maxY = panel2.Height;
            
            int newY = Math.Max(Math.Abs(random.Next(0, 100) - challengeButton.Location.Y), Math.Abs(random.Next(200, maxY) - challengeButton.Location.Y));

            challengeButton.Location = new Point(newX, newY);
            buttonTimer.Stop();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            buttonTimer.Start();
        }

        private void challengeButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            this.Close();
            goodForm.Show();
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            buttonTimer.Stop();
        }
    }
}
