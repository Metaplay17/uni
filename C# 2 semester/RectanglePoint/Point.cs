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
            graph.FillEllipse(new SolidBrush(color), this.x - 5, this.y - 5, 10, 10);
            graph.DrawEllipse(new Pen(Color.Black), this.x - 5, this.y - 5, 10, 10);
        }
    }
}
