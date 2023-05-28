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
    internal class ImageColorProcess
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

        public Bitmap RedFilter() 
        {
            Image<Bgr, byte> red_Image = image;
            red_Image[0] = new Image<Gray, byte>(red_Image.Width, red_Image.Height, new Gray(0));
            red_Image[1] = new Image<Gray, byte>(red_Image.Width, red_Image.Height, new Gray(0));
            return red_Image.AsBitmap();
        }

        public Bitmap GreenFilter()
        {
            Image<Bgr, byte> green_Image = image;
            green_Image[0] = new Image<Gray, byte>(green_Image.Width, green_Image.Height, new Gray(0));
            green_Image[2] = new Image<Gray, byte>(green_Image.Width, green_Image.Height, new Gray(0));
            return green_Image.AsBitmap();
        }

        public Bitmap BlueFilter()
        {
            Image<Bgr, byte> blue_Image = image;
            blue_Image[1] = new Image<Gray, byte>(blue_Image.Width, blue_Image.Height, new Gray(0));
            blue_Image[2] = new Image<Gray, byte>(blue_Image.Width, blue_Image.Height, new Gray(0));
            return blue_Image.AsBitmap();
        }
    }
}
