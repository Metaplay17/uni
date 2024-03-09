using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace Roaches
{
    internal class Character
    {
        private int x;
        public int y { get; set; }
        private int dx;
        public Bitmap image { get; set; }
        public Bitmap gif { get; set; }
        private Random random;

        public Character(Bitmap image, Bitmap gif, int y, Random random)
        {
            this.random = random;
            this.x = 40;
            this.y = y;
            this.dx = 0;
            this.image = image;
            this.gif = gif;
        }

        public void Move()
        {
            this.dx = random.Next(0, 4);
            this.x += dx;
        }

        public bool IsFinished()
        {
            return this.x >= 710;
        }

        public void Draw(Graphics graph)
        {
            graph.DrawImage(image, this.x, this.y, 60, 60);
        }

        public void MoveToStart()
        {
            this.x = 40;
        }
        public int X
        {
            get
            {
                return this.x;
            }
            private set
            {
                this.x = value;
            }
        }
    }
}
