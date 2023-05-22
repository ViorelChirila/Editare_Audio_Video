using Emgu.CV;
using Emgu.CV.Structure;
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
        VideoOperations operation = new VideoOperations();
        bool IsReadingFrame;
        Video video = new Video();
        public Form1()
        {
            InitializeComponent();
            operation.FrameUpdated += Service_FrameUpdated;
            
        }

        private void btnLoadVideo_Click(object sender, EventArgs e)
        {
            
            video.LoadVideo();
            trackBarVideo.Minimum = 0;
            trackBarVideo.Maximum = video.getTotalFrames();
            pBVideo.Image = video.GetMat().ToBitmap();
        }
        
        private void Service_FrameUpdated(object sender, VideoEventArgs e)
        {
            labelFrame.Text= "Frame No: " + e.FrameNo.ToString() + "/" + video.getTotalFrames().ToString();
            trackBarVideo.Value = e.FrameNo;
            pBVideo.Image = e.Bitmap;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (video.getCapture() == null)
            {
                return;
            }
            IsReadingFrame = true;
            StartReadingFrames();
        }

        private async void StartReadingFrames()
        {
            await operation.ReadAllFrames(video);
        }

        

        private void radioButtonGray_CheckedChanged(object sender, EventArgs e)
        {
            operation.flags.grayFlag = radioButtonGray.Checked;
        }

        private void radioButtonRed_CheckedChanged(object sender, EventArgs e)
        {
            operation.flags.redFilterFlag = radioButtonRed.Checked;
        }

        private void radioButtonGreen_CheckedChanged(object sender, EventArgs e)
        {
            operation.flags.greenFilterFlag = radioButtonGreen.Checked;
        }

        private void radioButtonBlue_CheckedChanged(object sender, EventArgs e)
        {
            operation.flags.blueFilterFlag = radioButtonBlue.Checked;
        }
    }
}
