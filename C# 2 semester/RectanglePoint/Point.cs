using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarOOPForms
{
    internal class Point
    {
        private int x;
        private int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int[] GetCoords()
        {
            return new int[] { x, y };
        }
        public void Draw(Graphics graph, Color color)
        {
            graph.DrawEllipse(new Pen(color), this.x, this.y, 10, 10);
            graph.FillEllipse(new SolidBrush(color), this.x, this.y, 10, 10);
        }
    }
}
