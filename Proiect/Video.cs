using Emgu.CV;
using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    internal class Video
    {
        private VideoCapture capture;
        private double Fps;
        private int totalFrame;
        private int frameNo;
        private int width;
        private int height;
        private int fourcc;
        private Mat m;

        public void LoadVideo()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                capture = new VideoCapture(ofd.FileName);
                width = Convert.ToInt32(capture.Get(CapProp.FrameWidth));
                height = Convert.ToInt32(capture.Get(CapProp.FrameHeight));
                fourcc = Convert.ToInt32(capture.Get(CapProp.FourCC));
                m= new Mat();
                capture.Read(m);

                totalFrame = (int)capture.Get(CapProp.FrameCount);
                Fps = capture.Get(CapProp.Fps);
                frameNo = 1;
            }
        }

        public VideoCapture GetCapture()
        {
            return capture;
        }

        public int GetTotalFrames()
        {
            return totalFrame;
        }

        public int GetFrameNo() 
        {
            return frameNo;
        }

        public double GetFps()
        {
            return Fps;
        }

        public int GetWidth()
        {
            return width;
        }

        public int GetHeight()
        {
            return height;
        }

        public int GetFourcc()
        {
            return fourcc;
        }

        public Mat GetMat()
        {
            return m;
        }

        public void IncreaseFrameNo()
        {
            frameNo++;
        }
    }
}
