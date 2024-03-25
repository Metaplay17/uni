using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesColors
{
    internal class Rectangle : Shape
    {
        public Rectangle(int x, int y, int width, int height, Color color) : base(x, y, width, height, color)
        {
            this.nodes = new PointF[] { new PointF(x, y), new PointF(x + width, y), new PointF(x + width, y + height), new PointF(x, y + height) };
        }

        public override void Draw(Graphics graph)
        {
            graph.FillRectangle(new SolidBrush(this.color), x, y, width, height);
        }
    }
}
