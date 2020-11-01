using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelfColorTest.Model
{
    class ComponentImage
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public ComponentImage(Image image)
        {
            Width = image.Width;
            Height = image.Height;
        }

    }
}
