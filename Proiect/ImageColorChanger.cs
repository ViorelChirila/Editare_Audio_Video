using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Proiect
{
    internal class ImageColorChanger
    {
        private Image<Bgr, byte> image;

        public void ImageSet(Image<Bgr, byte> image)
        { 
            this.image = image;
        }
        public Bitmap Gryscale()
        {
            Image<Gray, byte> gray_Image = image.Convert<Gray, byte>();
            return gray_Image.AsBitmap();
        }

    }
}
