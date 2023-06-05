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
        DateTime timestamp;
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
                timestamp = DateTime.Now;
                string timestampString = timestamp.ToString("yyyy-MM-dd HH:mm:ss");
                errorString += timestampString + ": First video not loaded!!";
                return;
            }
            errorString = null;
        }
        public void LoadSecondVideo()
        {
            secondVideo.LoadVideo();
            if (secondVideo.GetCapture() == null)
            {
                timestamp = DateTime.Now;
                string timestampString = timestamp.ToString("yyyy-MM-dd HH:mm:ss");
                errorString += timestampString + ": Second video not loaded!!";
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
            if(secondVideo.GetTotalFrames() < firstVideo.GetTotalFrames())
            {
                timestamp = DateTime.Now;
                string timestampString = timestamp.ToString("yyyy-MM-dd HH:mm:ss");
                errorString += timestampString + ": Second video must have at least the same length!!";
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Video Files|*.mp4;*.avi;*.mov|All Files|*.*";
            saveFileDialog.Title = "Save Video File";
            saveFileDialog.ShowDialog();
            
            if (saveFileDialog.FileName != "")
            {
                String destinationpath = saveFileDialog.FileName;
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
                        secondVideoPicture = secondVideoPicture.Resize(width / 2, height / 2, Inter.Cubic);
                        Image<Bgr, byte> img = m.ToImage<Bgr, byte>();
                        img.ROI = new Rectangle(0, 0, secondVideoPicture.Width,secondVideoPicture.Height );
                        secondVideoPicture.CopyTo(img);
                        img.ROI = Rectangle.Empty;
                        writer.Write(img.Mat);
                        FrameNo++;
                    }
                }
            }
            
        }
    }
}
