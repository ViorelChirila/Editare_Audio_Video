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
    internal class ImageResize
    {
        private Image<Bgr, byte> image;

        public void ImageSet(Image<Bgr, byte> image)
        {
            this.image = image;
        }

        public Bitmap Resize(double size)
        {
            Image<Bgr, byte> resize_Image = image;
            resize_Image = resize_Image.Resize(size, Emgu.CV.CvEnum.Inter.Linear);
            return resize_Image.AsBitmap();
        }
    }
}
