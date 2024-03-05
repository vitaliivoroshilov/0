using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Lab0
{
    internal class BinaryFilter: Filters
    {
        int limit;
        public BinaryFilter(int _limit) 
        {
            limit = Clamp(_limit, 0, 255);
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            int r = Clamp(sourceColor.R, 0, 255);
            int g = Clamp(sourceColor.G, 0, 255);
            int b = Clamp(sourceColor.B, 0, 255);
            
            int avg = Clamp((r + g + b) / 3, 0, 255);

            Color resultColor;
            if (avg <= limit)
                resultColor = Color.FromArgb(0, 0, 0);
            else
                resultColor = Color.FromArgb(255, 255, 255);
            return resultColor;
        }
    }
}
