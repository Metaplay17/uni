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
            buttonTimer.Interval = 400;

            this.endForm = endForm;

            timer.Tick += Timer_Tick;
            buttonTimer.Tick += ButtonTimer_Tick;

            buttonTimer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            elapsedMseconds += 100;

            int seconds = elapsedMseconds / 1000;
            int milliseconds = elapsedMseconds % 100;

            timeLabel.Text = $"{seconds}:{milliseconds}";

            if (seconds == 30)
            {
                timer.Stop();
                endForm.Show();
                this.Close();
            }
        }

        private void ButtonTimer_Tick(object sender, EventArgs e)
        {
            int maxX = panel2.Width - 10, newX;
            int maxY = panel2.Height - 10, newY;

            int randomLeftX = random.Next(30, 100);
            int randomRightX = random.Next(250, maxX);
            int randomLeftY = random.Next(30, 100);
            int randomRightY = random.Next(200, maxY);
            if (Math.Abs(randomLeftX - Cursor.Position.X) > Math.Abs(randomRightX - Cursor.Position.X))
            {
                newX = randomLeftX;
            }
            else
            {
                newX = randomRightX;
            }
            if (Math.Abs(randomLeftY - Cursor.Position.Y) > Math.Abs(randomRightY - Cursor.Position.Y))
            {
                newY = randomLeftY;
            }
            else
            {
                newY = randomRightY;
            }
            challengeButton.Location = new Point(newX, newY);
        }

        private void challengeButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            this.Close();
            goodForm.Show();
        }
    }
}
