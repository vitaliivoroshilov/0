using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Lab0
{
    internal class IncBrightnessFilter: Filters
    {
        int deltaBrightness;
        public IncBrightnessFilter(int _deltaBrightness)
        {
            deltaBrightness = Clamp(_deltaBrightness, 0, 255);
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            int r = Clamp(sourceColor.R + deltaBrightness, 0, 255);
            int g = Clamp(sourceColor.G + deltaBrightness, 0, 255);
            int b = Clamp(sourceColor.B + deltaBrightness, 0, 255);

            Color resultColor = Color.FromArgb(r, g, b);
            return resultColor;
        }
    }
}
