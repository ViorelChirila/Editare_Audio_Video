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
        private Mat m;

        public void LoadVideo()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                capture = new VideoCapture(ofd.FileName);
                m= new Mat();
                capture.Read(m);

                totalFrame = (int)capture.Get(CapProp.FrameCount);
                Fps = capture.Get(CapProp.Fps);
                frameNo = 1;
            }
        }

        public VideoCapture getCapture()
        {
            return capture;
        }

        public int getTotalFrames()
        {
            return totalFrame;
        }

        public int getFrameNo() 
        {
            return frameNo;
        }

        public double getFps()
        {
            return Fps;
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
