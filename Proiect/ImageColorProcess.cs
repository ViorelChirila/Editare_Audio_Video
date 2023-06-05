using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Emgu.CV.CvEnum;

namespace Proiect
{
    internal class ImageColorProcess
    {
        private Image<Bgr, byte> image;
        int carouselIndex;

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

        public Bitmap GammaCorrection(double value)
        {
            Image<Bgr, byte> gamma_Image = image;
            gamma_Image._GammaCorrect(value);
            return gamma_Image.AsBitmap();
        }

        public Bitmap ColorMap(ColorMapType colorMapType)
        {
            Image<Bgr, byte> colorMapImage = new Image<Bgr, byte>(image.Width, image.Height);
            CvInvoke.ApplyColorMap(image, colorMapImage, colorMapType);
            return colorMapImage.AsBitmap();
        }

        public void UpdateCarouselIndex()
        {
            carouselIndex = (carouselIndex + 1) % 4;
        }
        public Bitmap Carousel()
        {
            Bitmap processedFrame = image.AsBitmap();

            switch (carouselIndex)
            {
                case 0:
                    processedFrame = this.RedFilter();
                    break;
                case 1:
                    processedFrame= this.GreenFilter();
                    break;
                case 2:
                    processedFrame= this.BlueFilter();
                    break;
                case 3:
                    processedFrame= this.Gryscale();
                    break;
            }

            return processedFrame;
        }
    }
}
