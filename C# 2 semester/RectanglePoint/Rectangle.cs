using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SeminarOOPForms
{
    internal class Rectangle
    {
        private int x;
        private int y;
        private int height;
        private int width;
        public Rectangle()
        {

        }
        public Rectangle(int x, int y, int height, int width)
        {
            this.x = x;
            this.y = y;
            this.height = height;
            this.width = width;
        }
        public enum RectanglesStatus
        {
            Contains,
            Intersect,
            Inner,
            No
        }
        public Rectangle(int height, int width)
        {
            this.height = height;
            this.width = width;
        }
        public override string ToString()
        {
            return $"Rectangle {this.width * this.height}";

        }
        public int[] GetCoords()
        {
            return new int[] { x, y };
        }
        public int[] GetHighCoords()
        {
            return new int[] { this.x + this.width, this.y + this.height };
        }
        public int CalcArea()
        {
            return this.height * this.width;
        }
        public bool IsPointContained(Point point)
        {
            int[] coords = point.GetCoords();
            if ((coords[0] >= this.x && coords[0] <= this.x + this.width) && (coords[1] >= this.y && coords[1] <= this.y + this.height))
            {
                return true;
            }
            return false;
        }
        public RectanglesStatus CheckStatus(Rectangle rec1)
        {
            int[] coords = rec1.GetCoords();
            int[] highCoords = rec1.GetHighCoords();
            Point x = new Point(coords[0], coords[1]);
            Point deltaX = new Point(highCoords[0], coords[1]);
            Point deltaXY = new Point(highCoords[0], highCoords[1]);
            Point deltaY = new Point(coords[0], highCoords[1]);
            if (this.IsPointContained(x) && this.IsPointContained(deltaXY))
            {
                return RectanglesStatus.Contains;
            }
            else if (rec1.IsPointContained(new Point(this.x, this.y)) && rec1.IsPointContained(new Point(this.x + this.width, this.y + this.width)))
            {
                return RectanglesStatus.Inner;
            }
            else if (this.IsPointContained(x) || this.IsPointContained(deltaX) || this.IsPointContained(deltaY) || this.IsPointContained(deltaXY))
            {
                return RectanglesStatus.Intersect;
            }
            return RectanglesStatus.No;

        }

        public void Draw(Graphics graph, Color color)
        {
            graph.FillRectangle(new SolidBrush(color), this.x, this.y, this.width, this.height);
            graph.DrawRectangle(new Pen(color), this.x, this.y, this.width, this.height);
        }
    }
}
