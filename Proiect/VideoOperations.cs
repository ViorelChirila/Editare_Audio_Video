﻿using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    internal class VideoOperations
    {
        public event EventHandler<VideoEventArgs> FrameUpdated;
        public event EventHandler<VideoEventArgs> VideoLoad;
        public Flags flags = new Flags();
        ImageResize imageResize = new ImageResize();
        ImageRotate imageRotate = new ImageRotate();
        public Rectangle rect;
        private Video video;
        private double gammaValue;
        private ColorMapType colorMap;
        private double resizeValue;
        private double angleValue;

        public void LoadVideo()
        {
            video = new Video();
            video.LoadVideo();
            if (video.GetCapture() == null)
            {
                return;
            }
            VideoEventArgs args = new VideoEventArgs();
            args.TotalFrames = video.GetTotalFrames();
            args.m = video.GetMat();
            OnVideoLoad(args);
        }
        public async Task ReadAllFrames()
        {
            ImageColorProcess colorChanger = new ImageColorProcess();
            VideoEventArgs args = new VideoEventArgs();
            while (video.GetFrameNo() < video.GetTotalFrames())
            {
                if(video.GetFrameNo()%5 == 0)
                {
                    colorChanger.UpdateCarouselIndex();
                }
                video.IncreaseFrameNo();
                var mat = video.GetCapture().QueryFrame();
                if (flags.roiFlag)
                {
                    args.Bitmap = SubstractROI(colorChanger, mat);
                }
                else
                {
                    args.Bitmap = ApplyFlagsOperations(colorChanger, mat);
                }
                args.FrameNo = video.GetFrameNo();
                args.TotalFrames = video.GetTotalFrames();
                await Task.Delay(1000 / Convert.ToInt16(video.GetFps()));
                OnFrameUpdated(args);
            }
        }

        protected virtual void OnVideoLoad(VideoEventArgs args)
        {
            VideoLoad?.Invoke(this, args);
        }
        protected virtual void OnFrameUpdated(VideoEventArgs e)
        {
            FrameUpdated?.Invoke(this, e);
        }

        public Bitmap SubstractROI(ImageColorProcess changer, Mat mat)
        {
            var img = mat.ToImage<Bgr, byte>();
            img.ROI = rect;
            var imgROI = img.Copy();
            Image<Bgr, byte> imgGrayRoi;
            var m = imgROI.Mat;
            imgGrayRoi = ApplyFlagsOperations(changer, m).ToImage<Bgr, byte>();
            img.ROI = Rectangle.Empty;
            img.ROI = rect;
            imgGrayRoi.CopyTo(img);
            img.ROI = Rectangle.Empty;
            return img.ToBitmap();
        }

        public void SetGammaValue(double value)
        {
            gammaValue = value;
        }

        public void SetColorMap(ColorMapType value)
        {
            colorMap = value;
        }

        public void SetResizeValue(double value)
        {
            resizeValue = value;
        }

        public void SetAngleValue(double value)
        {
            angleValue = value;
        }

        private Bitmap ApplyFlagsOperations(ImageColorProcess changer, Mat mat)
        {
            switch(true)
            {
                case bool isChecked when flags.grayFlag:
                    changer.ImageSet(mat.ToImage<Bgr, byte>());
                    return changer.Gryscale();
                case bool isChecked when flags.redFilterFlag:
                    changer.ImageSet(mat.ToImage<Bgr, byte>());
                    return changer.RedFilter();
                case bool isChecked when flags.greenFilterFlag:
                    changer.ImageSet(mat.ToImage<Bgr, byte>());
                    return changer.GreenFilter();
                case bool isChecked when flags.blueFilterFlag:
                    changer.ImageSet(mat.ToImage<Bgr, byte>());
                    return changer.BlueFilter();
                case bool isChecked when flags.carouselFlag:
                    changer.ImageSet(mat.ToImage<Bgr, byte>());
                    return changer.Carousel();
                case bool isChecked when flags.gammaFlag:
                    changer.ImageSet(mat.ToImage<Bgr, byte>());
                    return changer.GammaCorrection(gammaValue);
                case bool isChecked when flags.colorMapFlag:
                    changer.ImageSet(mat.ToImage<Bgr, byte>());
                    return changer.ColorMap(colorMap);
                case bool isChecked when flags.resizeFlag:
                    imageResize.ImageSet(mat.ToImage<Bgr, byte>());
                    return imageResize.Resize(resizeValue);
                case bool isChecked when flags.rotateFlag:
                    imageRotate.ImageSet(mat.ToImage<Bgr, byte>());
                    return imageRotate.Rotate(angleValue);
                default:
                    return mat.ToBitmap();
            }
        }
    }
}
