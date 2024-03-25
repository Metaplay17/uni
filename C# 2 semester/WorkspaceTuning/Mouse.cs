using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkspaceTuning
{
    internal abstract class Mouse
    {
        protected int x = 374;
        protected int y = 12;
        protected int width = 381;
        protected int height = 249;
        protected Bitmap image;

        public Mouse(Bitmap image)
        {
            this.image = image;
        }

        public abstract void Draw(Graphics graph);
    }
}
