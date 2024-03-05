using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Lab0
{
    internal class GreyFilter: Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            int r = Clamp(sourceColor.R, 0, 255);
            int g = Clamp(sourceColor.G, 0, 255);
            int b = Clamp(sourceColor.B, 0, 255);

            int grey = Clamp((int)(0.299*r + 0.587*g + 0.114*b), 0, 255);

            Color resultColor = Color.FromArgb(grey, grey, grey);
            return resultColor;
        }
    }
}
