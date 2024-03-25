using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkspaceTuning
{
    internal class OldMonitor : Monitor
    {
        public OldMonitor(Bitmap image) : base(image) { }

        public override void Draw(Graphics graph)
        {
            graph.DrawImage(image, x, y, width, height);
        }
    }
}
