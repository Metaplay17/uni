using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapesColors
{
    internal class Ellipse : Shape
    {
        public Ellipse(int x, int  y, int width, int height, Color color) : base(x, y, width, height, color)
        {
            this.nodes = new PointF[] { new PointF(x, y + height / 2), new PointF(x + width / 2, y + height), new PointF(x + width, y + height / 2), new PointF(x + width / 2, y) };
        }

        public override void Draw(Graphics graph)
        {
            graph.DrawEllipse(new Pen(this.color), x, y, width, height);
            if (this.fillColor != Color.Empty)
            {
                graph.FillEllipse(new SolidBrush(this.fillColor), x, y, width, height);
            }
        }
    }
}
