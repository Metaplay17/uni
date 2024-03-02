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
        int x;
        int y;
        int dx;
        Bitmap image;
        Bitmap gif;

        public Character(Bitmap image, Bitmap gif, int y)
        {
            this.x = 40;
            this.y = y;
            this.dx = 0;
            this.image = image;
            this.gif = gif;
        }

        public void Move()
        {
            this.dx = RandomGenerator.GetRandomNumber(0, 10);
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

        public int GetX()
        {
            return this.x;
        }

        public void MoveToStart()
        {
            this.x = 40;
        }

        public Bitmap GetGif()
        {
            return this.gif;
        }
    }
}
