﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    internal class VideoEventArgs : EventArgs
    {
        public int FrameNo;
        public Bitmap Bitmap;
    }
}