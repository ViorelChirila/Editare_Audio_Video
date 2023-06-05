using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.CvEnum;

namespace Proiect
{
    internal class VideoEdit
    {
        private Video firstVideo;
        private Video secondVideo;
        private String errorString;
        public VideoEdit()
        {
            firstVideo = new Video();
            secondVideo = new Video();
        }
        public void LoadFirstVideo()
        {
            firstVideo.LoadVideo();
            if (firstVideo.GetCapture() == null)
            {
                errorString = "First video not loaded!!";
                return;
            }
            errorString = null;
        }
        public void LoadSecondVideo()
        {
            secondVideo.LoadVideo();
            if (secondVideo.GetCapture() == null)
            {
                errorString = "Second video not loaded!!";
                return;
            }
            errorString = null;
        }

        public String GetErrorString()
        {
            return errorString;
        }

        public void PictureInPicture()
        {
            string destinationpath = @"D:\Laborator AudioVideo\Proiect\Video\Video.mp4";
            int width = firstVideo.GetWidth();
            int height = firstVideo.GetHeight();
            double fps = firstVideo.GetFps();
            using (VideoWriter writer = new VideoWriter(destinationpath, firstVideo.GetFourcc(), fps, new Size(width, height), true))
            {
                Mat m = new Mat();
                Mat m2 = new Mat();

                var FrameNo = 1;
                while (FrameNo < firstVideo.GetTotalFrames())
                {
                    firstVideo.GetCapture().Read(m);
                    secondVideo.GetCapture().Read(m2);
                    Image<Bgr, byte> secondVideoPicture = m2.ToImage<Bgr, byte>();
                    //secondVideoPicture.Resize(1000, 600, Inter.Linear);
                    Image<Bgr, byte> img = m.ToImage<Bgr, byte>();
                    img.ROI = new Rectangle(0, 0, secondVideoPicture.Width, secondVideoPicture.Height);
                    secondVideoPicture.CopyTo(img);

                    img.ROI = Rectangle.Empty;

                    writer.Write(img.Mat);
                    FrameNo++;
                }
            }
        }
    }
}
