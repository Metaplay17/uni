using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapesColors
{
    public partial class MainWindow : Form
    {
        private Color selectedColor;
        private int tempX;
        private int tempY;

        public MainWindow()
        {
            InitializeComponent();
            selectedColor = colorButton.BackColor;
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            selectedColor = colorDialog1.Color;
            colorButton.BackColor = selectedColor;
        }

        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (moveButton.Checked && ShapeManager.CheckShape(e.X, e.Y) != -1)
            {
                int ind = ShapeManager.CheckShape(e.X, e.Y);
                ShapeManager.SelectShape(ind);
            }
            tempX = e.X;
            tempY = e.Y;
        }

        private void MainWindow_MouseUp(object sender, MouseEventArgs e)
        {
            if (ShapeManager.IsSelectShape())
            {
                ShapeManager.MoveShape(e.X - tempX, e.Y - tempY);
                ShapeManager.UnselectShape();
            }
            else if (rectangleButton.Checked)
            {
                int x = Math.Min(e.X, tempX);
                int y = Math.Min(e.Y, tempY);
                int width = Math.Max(e.X, tempX) - x;
                int height = Math.Max(e.Y, tempY) - y;
                ShapeManager.AddShape(new Rectangle(x, y, width, height, selectedColor));
            }
            else if (ellipseButton.Checked)
            {
                ShapeManager.AddShape(new Ellipse(tempX, tempY, e.X - tempX, e.Y - tempY, selectedColor));
            }
            Refresh();
        }

        private void MainWindow_Paint(object sender, PaintEventArgs e)
        {
            ShapeManager.Draw(e.Graphics);
        }
    }
}
