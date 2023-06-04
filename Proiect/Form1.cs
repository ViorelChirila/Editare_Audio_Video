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
        Rectangle rect;
        Point StartROI;
        bool MouseDown;
        Array colorMapValues = Enum.GetValues(typeof(ColorMapType));
        public Form1()
        {
            InitializeComponent();
            ExtractColorMapValues();
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

        
    }
}
