using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarOOPForms
{
    public partial class Form1 : Form
    {
        int old_x, old_y;
        Graphics panelGraph;
        public Form1()
        {
            InitializeComponent();
            panelGraph = panel1.CreateGraphics();
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            //Graphics graph = this.CreateGraphics();
            //graph.DrawRectangle(new Pen(Color.Red), 50, 50, 200, 100);
            //graph.FillRectangle(new SolidBrush(Color.Blue), 51, 51, 199, 99);
            //Pen mainPen = new Pen(Color.Red, 10);
            //panelGraph.DrawRectangle(new Pen(Color.Red), 50, 50, 200, 100);
            //panelGraph.FillRectangle(new SolidBrush(Color.Blue), 51, 51, 199, 99);
            Rectangle rec1 = new Rectangle(50, 50, 100, 100);
            Rectangle rec2 = new Rectangle(100, 100, 50, 50);
            rec2.Draw(panelGraph, Color.Red);
            rec1.Draw(panelGraph, Color.Black);
            labelStatus.Text = rec1.CheckStatus(rec2).ToString();

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            int new_x = e.X;
            int new_y = e.Y;
            int highX = Math.Min(old_x, new_x);
            int highY = Math.Min(old_y, new_y);
            int lowX = Math.Max(old_x, new_x);
            int lowY = Math.Max(old_y, new_y);
            Rectangle rec3 = new Rectangle(highX, highY, lowY - highY, lowX - highX);
            rec3.Draw(panelGraph, Color.Red);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            old_x = e.X;
            old_y = e.Y;

        }
    }
}
