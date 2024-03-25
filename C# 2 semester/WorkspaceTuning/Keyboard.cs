using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkspaceTuning
{
    internal abstract class Keyboard
    {
        protected int x = 33;
        protected int y = 267;
        protected int width = 722;
        protected int height = 171;
        protected Bitmap image;

        public Keyboard(Bitmap image)
        {
            this.image = image;
        }

        public abstract void Draw(Graphics graph);
    }
}
