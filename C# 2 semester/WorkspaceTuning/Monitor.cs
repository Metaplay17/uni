using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkspaceTuning
{
    internal abstract class Monitor
    {
        protected int x = 233;
        protected int y = 12;
        protected int width = 335;
        protected int height = 249;
        protected Bitmap image;

        public Monitor(Bitmap image)
        {
            this.image = image;
        }
        public abstract void Draw(Graphics graph);
    }
}
