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
        private int edgeY = 70;
        private int edgeX = 15;
        private ShapeManager shapeManager;

        public MainWindow()
        {
            InitializeComponent();
            selectedColor = colorButton.BackColor;
            shapeManager = ShapeManager.GetInstance();
        }

        private bool IsDrawingAble(MouseEventArgs e)
        {
            return e.X >= 12 && e.X <= 910 && e.Y >= 88 && e.Y <= 610;
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            selectedColor = colorDialog1.Color;
            colorButton.BackColor = selectedColor;
        }

        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (!IsDrawingAble(e))
            {
                return;
            }
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
            if (!IsDrawingAble(e) || tempX == 0 || tempY == 0)
            {
                return;
            }
            int x = Math.Min(e.X, tempX);
            int y = Math.Min(e.Y, tempY);
            int width = Math.Max(e.X, tempX) - x;
            int height = Math.Max(e.Y, tempY) - y;
            int deltaX = e.X - tempX;
            int deltaY = e.Y - tempY;
            if (moveButton.Checked && shapeManager.IsSelectShape() && shapeManager.IsMoveAble(edgeX, edgeY, deltaX, deltaY) 
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
            else if (triangleButton.Checked)
            {
                Triangle testTriangle = new Triangle(x, y, width, height, selectedColor);
                if (shapeManager.CheckCollisions(testTriangle))
                {
                    shapeManager.AddShape(testTriangle);
                }
            }
            tempX = 0;
            tempY = 0;
            Refresh();
        }

        private void MainWindow_Paint(object sender, PaintEventArgs e)
        {
            shapeManager.Draw(e.Graphics);
        }

        private void MainWindow_Click(object sender, EventArgs e)
        {
            if (moveButton.Checked)
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
            Refresh();
        }
    }
}
