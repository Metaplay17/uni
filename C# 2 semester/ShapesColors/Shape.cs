﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesColors
{
    internal abstract class Shape
    {
        protected int x;
        protected int y;
        protected int width;
        protected int height;
        protected Color color;
        public Shape(int x, int y, int width, int height, Color color)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.color = color;
        }
        public abstract void Draw(Graphics graph);

        public void Move(int deltaX, int deltaY)
        {
            this.x += deltaX;
            this.y += deltaY;
        }

        public bool IsPointContained(int x, int y)
        {
            return this.x <= x && (this.x + this.width) >= x && this.y <= y && (this.y + this.height) >= y;
        }
    }
}
