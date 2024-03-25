using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarOOPForms
{
    internal class Triangle
    {
        private PointF[] points;
        public Triangle(PointF[] points)
        {
            this.points = points;
        }

        public void Draw(Graphics g, Color color)
        {
            g.DrawPolygon(new Pen(color), points);
        }
    }
}
