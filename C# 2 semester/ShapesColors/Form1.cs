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
        private int edge = 70;
        private ShapeManager shapeManager;

        public MainWindow()
        {
            InitializeComponent();
            selectedColor = colorButton.BackColor;
            shapeManager = ShapeManager.GetInstance();
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            selectedColor = colorDialog1.Color;
            colorButton.BackColor = selectedColor;
        }

        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (moveButton.Checked && shapeManager.CheckShape(e.X, e.Y) != -1)
            {
                int ind = shapeManager.CheckShape(e.X, e.Y);
                shapeManager.SelectShape(ind);
            }
            tempX = e.X;
            tempY = e.Y;
        }

        private void MainWindow_MouseUp(object sender, MouseEventArgs e)
        {
            int x = Math.Min(e.X, tempX);
            int y = Math.Min(e.Y, tempY);
            int width = Math.Max(e.X, tempX) - x;
            int height = Math.Max(e.Y, tempY) - y;
            int deltaX = e.X - tempX;
            int deltaY = e.Y - tempY;
            if (moveButton.Checked && shapeManager.IsSelectShape() && shapeManager.IsMoveAble(edge, e.Y - tempY) 
                && shapeManager.CheckCollisions(deltaX, deltaY))
            {   
                shapeManager.MoveShape(deltaX, deltaY);
                shapeManager.UnselectShape();
            }
            else if (rectangleButton.Checked && e.Y >= edge)
            {
                Rectangle testRect = new Rectangle(x, y, width, height, selectedColor);
                if (shapeManager.CheckCollisions(testRect))
                {
                    shapeManager.AddShape(testRect);
                }
            }
            else if (ellipseButton.Checked && e.Y >= edge)
            {
                Ellipse testEllipse = new Ellipse(x, y, width, height, selectedColor);
                if (shapeManager.CheckCollisions(testEllipse))
                {
                    shapeManager.AddShape(testEllipse);
                }
            }
            Refresh();
        }

        private void MainWindow_Paint(object sender, PaintEventArgs e)
        {
            shapeManager.Draw(e.Graphics);
        }

        private void MainWindow_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            int x = me.Location.X;
            int y = me.Location.Y;
            int ind = shapeManager.PointInShape(x, y);
            if (ind != -1)
            {
                shapeManager.SelectShape(ind);
                shapeManager.PaintSelectedShape(selectedColor);
                shapeManager.UnselectShape();
            }
        }
    }
}
