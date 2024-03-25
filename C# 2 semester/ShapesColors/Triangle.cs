using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesColors
{
    internal class Triangle : Shape
    {
        private PointF[] points;
        public Triangle(int x, int y, int width, int height, Color color) : base(x, y, width, height, color)
        {
            points = new PointF[] { new PointF(x, y + height), new PointF(x + width / 2, y), new PointF(x + width, y + height) };
            nodes = points;
        }

        public override void Draw(Graphics graph)
        {
            graph.DrawPolygon(new Pen(color), this.points);
            if (this.fillColor != Color.Empty)
            {
                graph.FillPolygon(new SolidBrush(fillColor), this.points);
            }
        }
        public override void Move(int deltaX, int deltaY)
        {
            base.Move(deltaX, deltaY);
            points = new PointF[] { new PointF(x, y + height), new PointF(x + width / 2, y), new PointF(x + width, y + height) };
        }
    }
}
