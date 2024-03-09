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
        private int y;
        private int dx;
        private Bitmap image;
        private Bitmap gif;
        private Random random;

        public Character(Bitmap image, Bitmap gif, int y, Random random)
        {
            this.random = random;
            this.x = 40;
            this.y = y;
            this.image = image;
            this.gif = gif;
        }

        public void Move() => this.x += random.Next(0, 4);

        public bool IsFinished() => this.x >= 710;

        public void Draw(Graphics graph) => graph.DrawImage(image, this.x, this.y, 60, 60);

        public void MoveToStart() => this.x = 40;
        public int X
        {
            get { return this.x; }
            private set { this.x = value; }
        }
        public Bitmap Gif
        {
            get { return this.gif; }
        }
        public Bitmap Image
        {
            get { return this.image; }
        }
    }
}
