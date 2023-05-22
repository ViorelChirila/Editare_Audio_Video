using Emgu.CV;
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
        public Flags flags = new Flags();
        public async Task ReadAllFrames(Video video)
        {
            ImageColorChanger changer = new ImageColorChanger();
            VideoEventArgs args = new VideoEventArgs();
            while (video.getFrameNo() < video.getTotalFrames())
            {
                video.IncreaseFrameNo();
                var mat = video.getCapture().QueryFrame();
                args.Bitmap = ApplyFlagsValues(changer, mat);
                args.FrameNo = video.getFrameNo();
                await Task.Delay(1000 / Convert.ToInt16(video.getFps()));
                OnFrameUpdated(args);
            }
        }

        protected virtual void OnFrameUpdated(VideoEventArgs e)
        {
            EventHandler<VideoEventArgs> handler = FrameUpdated;
            if(handler != null)
            {
                handler(this, e);
            }
        }

        private Bitmap ApplyFlagsValues(ImageColorChanger changer, Mat mat)
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
                default:
                    return mat.ToBitmap();
            }
        }
    }
}
