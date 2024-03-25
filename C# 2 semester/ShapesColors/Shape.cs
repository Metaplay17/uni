using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapesColors
{
    internal abstract class Shape
    {
        protected int x;
        protected int y;
        protected int width;
        protected int height;
        protected Color color;
        protected Color fillColor = Color.Empty;
        protected PointF[] nodes;
        public Shape(int x, int y, int width, int height, Color color)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.color = color;
        }
        public static bool IsIntersect(Shape shape1, Shape shape2)
        {
            bool instersectionX = shape1.X < shape2.X + shape2.Width && shape2.X < shape1.X + shape1.Width;
            bool instersectionY = shape1.Y < shape2.Y + shape2.Height && shape2.Y < shape1.Y + shape1.Height;
            return instersectionX && instersectionY;
        }
        public abstract void Draw(Graphics graph);

        public virtual void Move(int deltaX, int deltaY)
        {
            this.x += deltaX;
            this.y += deltaY;
        }

        public bool IsPointContained(int x, int y)
        {
            return this.x <= x && (this.x + this.width) >= x && this.y <= y && (this.y + this.height) >= y;
        }
        public Color FillColor { set { this.fillColor = value; } }

        public int X { get { return this.x; } }
        public int Y { get { return this.y; } }
        public int Width { get { return this.width; } }
        public int Height { get { return this.height; } }
    }
}
