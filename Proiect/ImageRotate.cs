using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Proiect
{
    internal class ImageRotate
    {
        private Image<Bgr, byte> image;

        public void ImageSet(Image<Bgr, byte> image)
        {
            this.image = image;
        }

        public Bitmap Rotate(double angle)
        {
            Image<Bgr, byte> rotate_Image = image;
            rotate_Image = rotate_Image.Rotate(angle, new Bgr(255, 0, 0), true);
            return rotate_Image.AsBitmap();
        }
    }
}
