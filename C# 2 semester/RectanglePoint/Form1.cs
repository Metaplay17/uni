using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarOOPForms
{
    public partial class Form1 : Form
    {
        int old_x, old_y;
        List<Point> points;
        List<Rectangle> rectangles;
        public Form1()
        {
            InitializeComponent();
            rectangleButton.Checked = true;
            points = new List<Point>();
            rectangles = new List<Rectangle>();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (rectangleButton.Checked)
            {
                int new_x = e.X;
                int new_y = e.Y;
                int highX = Math.Min(old_x, new_x);
                int highY = Math.Min(old_y, new_y);
                int lowX = Math.Max(old_x, new_x);
                int lowY = Math.Max(old_y, new_y);
                Rectangle rec3 = new Rectangle(highX, highY, lowY - highY, lowX - highX);
                rectangles.Add(rec3);
                Refresh();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Rectangle rectangle in rectangles)
            {
                rectangle.Draw(e.Graphics, Color.Purple);
            }
            foreach (Point point in points)
            {
                point.Draw(e.Graphics, Color.Purple);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (rectangleButton.Checked)
            {
                old_x = e.X;
                old_y = e.Y;
            }
            else
            {
                Point point = new Point(e.X, e.Y);
                points.Add(point);
                Refresh();
            }
        }
        
    }
}
