using Emgu.CV;
using Emgu.CV.CvEnum;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect
{
    public partial class Form1 : Form
    {
        VideoOperations operation = new VideoOperations();
        VideoEdit videoEdit = new VideoEdit();
        Rectangle rect;
        Point StartROI;
        bool MouseDown;
        int numberOfVideos = 0;
        Array colorMapValues = Enum.GetValues(typeof(ColorMapType));
        DateTime timestamp;
        public Form1()
        {
            InitializeComponent();
            ExtractColorMapValues();
            numericUpDownResize.Value = 1;
        }

        private void btnLoadVideo_Click(object sender, EventArgs e)
        {
            operation.VideoLoad += Operation_VideoLoad;
            operation.LoadVideo();
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(this, "Do you want ROI", "ROI", buttons);
            if (result == DialogResult.Yes)
            {
                operation.flags.roiFlag = true;
                radioButtonResize.Enabled = false;
            }
            else
            {
                operation.flags.roiFlag = false;
            }
        }

        private void Operation_VideoLoad(object sender, VideoEventArgs e)
        {
            trackBarVideo.Minimum = 0;
            trackBarVideo.Maximum = e.TotalFrames;
            pBVideo.Image = e.m.ToBitmap();
        }

        private void Service_FrameUpdated(object sender, VideoEventArgs e)
        {
            labelFrame.Text= "Frame No: " + e.FrameNo.ToString() + "/" + e.TotalFrames.ToString();
            trackBarVideo.Value = e.FrameNo;
            pBVideo.Image = e.Bitmap;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            operation.FrameUpdated += Service_FrameUpdated;
            StartReadingFrames();
        }

        private async void StartReadingFrames()
        {
            await operation.ReadAllFrames();
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
        private void radioButtonCarousel_CheckedChanged(object sender, EventArgs e)
        {
            operation.flags.carouselFlag = radioButtonCarousel.Checked;
        }
        private void radioButtonColorMap_CheckedChanged(object sender, EventArgs e)
        {
            operation.flags.colorMapFlag = radioButtonColorMap.Checked;
        }
        private void radioButtonGamma_CheckedChanged(object sender, EventArgs e)
        {
            double gammaValue = (double)numericUpDownGamma.Value;
            operation.SetGammaValue(gammaValue);
            operation.flags.gammaFlag = radioButtonGamma.Checked;
        }
        private void radioButtonResize_CheckedChanged(object sender, EventArgs e)
        {
            operation.SetResizeValue((double)numericUpDownResize.Value);
            operation.flags.resizeFlag = radioButtonResize.Checked;
        }
        private void radioButtonRotate_CheckedChanged(object sender, EventArgs e)
        {
            operation.SetAngleValue((double)numericUpDownAngle.Value);
            operation.flags.rotateFlag = radioButtonRotate.Checked;
        }
        private void pBVideo_Paint(object sender, PaintEventArgs e)
        {
            if (MouseDown)
            {
                using (Pen pen = new Pen(Color.Yellow, 1))
                {
                    e.Graphics.DrawRectangle(pen, rect);
                }
            }
        }

        private void pBVideo_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown = true;
            StartROI = e.Location;
        }

        private void pBVideo_MouseMove(object sender, MouseEventArgs e)
        {
            if (pBVideo.Image == null)
            {
                return;
            }

            int width = Math.Max(StartROI.X, e.X) - Math.Min(StartROI.X, e.X);
            int height = Math.Max(StartROI.Y, e.Y) - Math.Min(StartROI.Y, e.Y);
            rect = new Rectangle(Math.Min(StartROI.X, e.X),
                Math.Min(StartROI.Y, e.Y),
                width,
                height);
            Refresh();

        }

        private void pBVideo_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDown = false;
            if (pBVideo.Image == null || rect == Rectangle.Empty)
            { return; }

            operation.rect = rect;
        }

        private void ExtractColorMapValues()
        {
            foreach (var value in colorMapValues)
            {
                comboBoxColorMap.Items.Add(value);
            }
        }

        private void comboBoxColorMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColorMapType selectedValue = (ColorMapType)comboBoxColorMap.SelectedItem;
            operation.SetColorMap(selectedValue);
        }

        private void btnSelectVideo_Click(object sender, EventArgs e)
        {
            
            videoEdit.LoadFirstVideo();
            if(videoEdit.GetErrorString() != null)
            {
                textBoxConsole.AppendText(videoEdit.GetErrorString());
                textBoxConsole.AppendText(Environment.NewLine);
                return;
            }
            else
            {
                timestamp = DateTime.Now;
                string timestampString = timestamp.ToString("yyyy-MM-dd HH:mm:ss");
                textBoxConsole.AppendText(timestampString+ ": First video loaded!") ;
                textBoxConsole.AppendText(Environment.NewLine);
                labelCountVideos.Text = "No. videos selected: 1/2";
                numberOfVideos++;
            }
            videoEdit.LoadSecondVideo();
            if(videoEdit.GetErrorString() != null)
            {
                textBoxConsole.AppendText(videoEdit.GetErrorString());
                textBoxConsole.AppendText(Environment.NewLine);
                return;
            }
            else
            {
                timestamp = DateTime.Now;
                string timestampString = timestamp.ToString("yyyy-MM-dd HH:mm:ss");
                textBoxConsole.AppendText(timestampString+": Second video loaded!");
                textBoxConsole.AppendText(Environment.NewLine);
                labelCountVideos.Text = "No. videos selected: 2/2";
                numberOfVideos++;
            }
            if(numberOfVideos == 2)
            {
                btnSelectVideo.Enabled = false;
                btnPictureInPicture.Enabled = true;
            }
            
            
        }

        private void btnPictureInPicture_Click(object sender, EventArgs e)
        {
            videoEdit.PictureInPicture();
            if(videoEdit.GetErrorString() != null)
            {
                textBoxConsole.AppendText(videoEdit.GetErrorString());
                textBoxConsole.AppendText(Environment.NewLine);
                return;
            }
            else
            {
                timestamp = DateTime.Now;
                string timestampString = timestamp.ToString("yyyy-MM-dd HH:mm:ss");
                textBoxConsole.AppendText(timestampString+ ": Picture in picture done!");
                textBoxConsole.AppendText(Environment.NewLine);
                btnPictureInPicture.Enabled = false;
            }
           
        }

    }
}
