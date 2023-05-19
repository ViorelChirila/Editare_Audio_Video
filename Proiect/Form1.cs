using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Video video = new Video();
        bool IsReadingFrame;

        private void btnLoadVideo_Click(object sender, EventArgs e)
        {
            
            video.LoadVideo();
            
            pBVideo.Image = video.GetMat().ToBitmap();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (video.getCapture() == null)
            {
                return;
            }
            IsReadingFrame = true;
            ReadAllFrames();
        }

        private async void ReadAllFrames()
        {
            trackBarVideo.Minimum = 0;
            trackBarVideo.Maximum = video.getTotalFrames();
            Mat m = new Mat();
            while (IsReadingFrame == true && video.getFrameNo() < video.getTotalFrames())
            {
                video.IncreaseFrameNo();
                var mat = video.getCapture().QueryFrame();
                pBVideo.Image = mat.ToBitmap();
                await Task.Delay(800 / Convert.ToInt16(video.getFps()));
                labelFrame.Text ="Frame No: "+ video.getFrameNo().ToString() + "/" + video.getTotalFrames().ToString();
                trackBarVideo.Value = video.getFrameNo();
                
            }
        }
    }
}
