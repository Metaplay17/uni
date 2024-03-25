using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkspaceTuning
{
    internal abstract class Mouse
    {
        protected int x = 430;
        protected int y = 250;
        protected int width = 300;
        protected int height = 150;
        protected Bitmap image;

        public Mouse(Bitmap image)
        {
            this.image = image;
        }

        public abstract void Draw(Graphics graph);
    }
}
