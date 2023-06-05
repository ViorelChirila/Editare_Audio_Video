namespace Proiect
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pBVideo = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnLoadVideo = new System.Windows.Forms.Button();
            this.labelFrame = new System.Windows.Forms.Label();
            this.trackBarVideo = new System.Windows.Forms.TrackBar();
            this.radioButtonGray = new System.Windows.Forms.RadioButton();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.radioButtonBlue = new System.Windows.Forms.RadioButton();
            this.groupBoxColorModifier = new System.Windows.Forms.GroupBox();
            this.radioButtonColorMap = new System.Windows.Forms.RadioButton();
            this.radioButtonGamma = new System.Windows.Forms.RadioButton();
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            this.numericUpDownGamma = new System.Windows.Forms.NumericUpDown();
            this.labelGammaValue = new System.Windows.Forms.Label();
            this.comboBoxColorMap = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxVideoEdit = new System.Windows.Forms.GroupBox();
            this.labelCountVideos = new System.Windows.Forms.Label();
            this.btnTransition = new System.Windows.Forms.Button();
            this.textBoxConsole = new System.Windows.Forms.TextBox();
            this.btnPictureInPicture = new System.Windows.Forms.Button();
            this.btnSelectVideo = new System.Windows.Forms.Button();
            this.radioButtonResize = new System.Windows.Forms.RadioButton();
            this.numericUpDownResize = new System.Windows.Forms.NumericUpDown();
            this.labelResize = new System.Windows.Forms.Label();
            this.labelRotate = new System.Windows.Forms.Label();
            this.numericUpDownAngle = new System.Windows.Forms.NumericUpDown();
            this.radioButtonRotate = new System.Windows.Forms.RadioButton();
            this.groupBoxResizeRotate = new System.Windows.Forms.GroupBox();
            this.radioButtonDefault = new System.Windows.Forms.RadioButton();
            this.radioButtonCarousel = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pBVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVideo)).BeginInit();
            this.groupBoxColorModifier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGamma)).BeginInit();
            this.groupBoxVideoEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngle)).BeginInit();
            this.groupBoxResizeRotate.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBVideo
            // 
            this.pBVideo.Location = new System.Drawing.Point(12, 12);
            this.pBVideo.Name = "pBVideo";
            this.pBVideo.Size = new System.Drawing.Size(610, 297);
            this.pBVideo.TabIndex = 0;
            this.pBVideo.TabStop = false;
            this.pBVideo.Paint += new System.Windows.Forms.PaintEventHandler(this.pBVideo_Paint);
            this.pBVideo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBVideo_MouseDown);
            this.pBVideo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pBVideo_MouseMove);
            this.pBVideo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pBVideo_MouseUp);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(12, 393);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(125, 44);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnLoadVideo
            // 
            this.btnLoadVideo.Location = new System.Drawing.Point(968, 12);
            this.btnLoadVideo.Name = "btnLoadVideo";
            this.btnLoadVideo.Size = new System.Drawing.Size(125, 44);
            this.btnLoadVideo.TabIndex = 2;
            this.btnLoadVideo.Text = "Load Video";
            this.btnLoadVideo.UseVisualStyleBackColor = true;
            this.btnLoadVideo.Click += new System.EventHandler(this.btnLoadVideo_Click);
            // 
            // labelFrame
            // 
            this.labelFrame.AutoSize = true;
            this.labelFrame.Location = new System.Drawing.Point(12, 374);
            this.labelFrame.Name = "labelFrame";
            this.labelFrame.Size = new System.Drawing.Size(73, 16);
            this.labelFrame.TabIndex = 3;
            this.labelFrame.Text = "Frame No :";
            // 
            // trackBarVideo
            // 
            this.trackBarVideo.Location = new System.Drawing.Point(12, 315);
            this.trackBarVideo.Name = "trackBarVideo";
            this.trackBarVideo.Size = new System.Drawing.Size(610, 56);
            this.trackBarVideo.TabIndex = 4;
            // 
            // radioButtonGray
            // 
            this.radioButtonGray.AutoSize = true;
            this.radioButtonGray.Location = new System.Drawing.Point(18, 68);
            this.radioButtonGray.Name = "radioButtonGray";
            this.radioButtonGray.Size = new System.Drawing.Size(57, 20);
            this.radioButtonGray.TabIndex = 7;
            this.radioButtonGray.TabStop = true;
            this.radioButtonGray.Text = "Gray";
            this.radioButtonGray.UseVisualStyleBackColor = true;
            this.radioButtonGray.CheckedChanged += new System.EventHandler(this.radioButtonGray_CheckedChanged);
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Location = new System.Drawing.Point(18, 103);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(54, 20);
            this.radioButtonRed.TabIndex = 8;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "Red";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            this.radioButtonRed.CheckedChanged += new System.EventHandler(this.radioButtonRed_CheckedChanged);
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.AutoSize = true;
            this.radioButtonGreen.Location = new System.Drawing.Point(18, 138);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(65, 20);
            this.radioButtonGreen.TabIndex = 9;
            this.radioButtonGreen.TabStop = true;
            this.radioButtonGreen.Text = "Green";
            this.radioButtonGreen.UseVisualStyleBackColor = true;
            this.radioButtonGreen.CheckedChanged += new System.EventHandler(this.radioButtonGreen_CheckedChanged);
            // 
            // radioButtonBlue
            // 
            this.radioButtonBlue.AutoSize = true;
            this.radioButtonBlue.Location = new System.Drawing.Point(18, 175);
            this.radioButtonBlue.Name = "radioButtonBlue";
            this.radioButtonBlue.Size = new System.Drawing.Size(55, 20);
            this.radioButtonBlue.TabIndex = 10;
            this.radioButtonBlue.TabStop = true;
            this.radioButtonBlue.Text = "Blue";
            this.radioButtonBlue.UseVisualStyleBackColor = true;
            this.radioButtonBlue.CheckedChanged += new System.EventHandler(this.radioButtonBlue_CheckedChanged);
            // 
            // groupBoxColorModifier
            // 
            this.groupBoxColorModifier.Controls.Add(this.radioButtonCarousel);
            this.groupBoxColorModifier.Controls.Add(this.radioButtonColorMap);
            this.groupBoxColorModifier.Controls.Add(this.radioButtonGamma);
            this.groupBoxColorModifier.Controls.Add(this.radioButtonNormal);
            this.groupBoxColorModifier.Controls.Add(this.radioButtonRed);
            this.groupBoxColorModifier.Controls.Add(this.radioButtonBlue);
            this.groupBoxColorModifier.Controls.Add(this.radioButtonGray);
            this.groupBoxColorModifier.Controls.Add(this.radioButtonGreen);
            this.groupBoxColorModifier.Location = new System.Drawing.Point(643, 12);
            this.groupBoxColorModifier.Name = "groupBoxColorModifier";
            this.groupBoxColorModifier.Size = new System.Drawing.Size(128, 317);
            this.groupBoxColorModifier.TabIndex = 11;
            this.groupBoxColorModifier.TabStop = false;
            this.groupBoxColorModifier.Text = "Color Modifiers";
            // 
            // radioButtonColorMap
            // 
            this.radioButtonColorMap.AutoSize = true;
            this.radioButtonColorMap.Location = new System.Drawing.Point(18, 275);
            this.radioButtonColorMap.Name = "radioButtonColorMap";
            this.radioButtonColorMap.Size = new System.Drawing.Size(90, 20);
            this.radioButtonColorMap.TabIndex = 16;
            this.radioButtonColorMap.TabStop = true;
            this.radioButtonColorMap.Text = "Color Map";
            this.radioButtonColorMap.UseVisualStyleBackColor = true;
            this.radioButtonColorMap.CheckedChanged += new System.EventHandler(this.radioButtonColorMap_CheckedChanged);
            // 
            // radioButtonGamma
            // 
            this.radioButtonGamma.AutoSize = true;
            this.radioButtonGamma.Location = new System.Drawing.Point(18, 240);
            this.radioButtonGamma.Name = "radioButtonGamma";
            this.radioButtonGamma.Size = new System.Drawing.Size(76, 20);
            this.radioButtonGamma.TabIndex = 14;
            this.radioButtonGamma.TabStop = true;
            this.radioButtonGamma.Text = "Gamma";
            this.radioButtonGamma.UseVisualStyleBackColor = true;
            this.radioButtonGamma.CheckedChanged += new System.EventHandler(this.radioButtonGamma_CheckedChanged);
            // 
            // radioButtonNormal
            // 
            this.radioButtonNormal.AutoSize = true;
            this.radioButtonNormal.Location = new System.Drawing.Point(18, 33);
            this.radioButtonNormal.Name = "radioButtonNormal";
            this.radioButtonNormal.Size = new System.Drawing.Size(72, 20);
            this.radioButtonNormal.TabIndex = 12;
            this.radioButtonNormal.TabStop = true;
            this.radioButtonNormal.Text = "Normal";
            this.radioButtonNormal.UseVisualStyleBackColor = true;
            // 
            // numericUpDownGamma
            // 
            this.numericUpDownGamma.DecimalPlaces = 1;
            this.numericUpDownGamma.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownGamma.Location = new System.Drawing.Point(968, 90);
            this.numericUpDownGamma.Name = "numericUpDownGamma";
            this.numericUpDownGamma.Size = new System.Drawing.Size(125, 22);
            this.numericUpDownGamma.TabIndex = 12;
            // 
            // labelGammaValue
            // 
            this.labelGammaValue.AutoSize = true;
            this.labelGammaValue.Location = new System.Drawing.Point(868, 96);
            this.labelGammaValue.Name = "labelGammaValue";
            this.labelGammaValue.Size = new System.Drawing.Size(94, 16);
            this.labelGammaValue.TabIndex = 13;
            this.labelGammaValue.Text = "Gamma value:";
            // 
            // comboBoxColorMap
            // 
            this.comboBoxColorMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColorMap.FormattingEnabled = true;
            this.comboBoxColorMap.Location = new System.Drawing.Point(968, 118);
            this.comboBoxColorMap.Name = "comboBoxColorMap";
            this.comboBoxColorMap.Size = new System.Drawing.Size(125, 24);
            this.comboBoxColorMap.TabIndex = 14;
            this.comboBoxColorMap.SelectedIndexChanged += new System.EventHandler(this.comboBoxColorMap_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(852, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Color map mode:";
            // 
            // groupBoxVideoEdit
            // 
            this.groupBoxVideoEdit.Controls.Add(this.labelCountVideos);
            this.groupBoxVideoEdit.Controls.Add(this.btnTransition);
            this.groupBoxVideoEdit.Controls.Add(this.textBoxConsole);
            this.groupBoxVideoEdit.Controls.Add(this.btnPictureInPicture);
            this.groupBoxVideoEdit.Controls.Add(this.btnSelectVideo);
            this.groupBoxVideoEdit.Location = new System.Drawing.Point(788, 222);
            this.groupBoxVideoEdit.Name = "groupBoxVideoEdit";
            this.groupBoxVideoEdit.Size = new System.Drawing.Size(305, 269);
            this.groupBoxVideoEdit.TabIndex = 16;
            this.groupBoxVideoEdit.TabStop = false;
            this.groupBoxVideoEdit.Text = "Video Edit Controlls";
            // 
            // labelCountVideos
            // 
            this.labelCountVideos.AutoSize = true;
            this.labelCountVideos.Location = new System.Drawing.Point(110, 82);
            this.labelCountVideos.Name = "labelCountVideos";
            this.labelCountVideos.Size = new System.Drawing.Size(171, 16);
            this.labelCountVideos.TabIndex = 19;
            this.labelCountVideos.Text = "Number of videos selected:";
            // 
            // btnTransition
            // 
            this.btnTransition.Enabled = false;
            this.btnTransition.Location = new System.Drawing.Point(7, 72);
            this.btnTransition.Name = "btnTransition";
            this.btnTransition.Size = new System.Drawing.Size(100, 35);
            this.btnTransition.TabIndex = 18;
            this.btnTransition.Text = "Transition";
            this.btnTransition.UseVisualStyleBackColor = true;
            // 
            // textBoxConsole
            // 
            this.textBoxConsole.Location = new System.Drawing.Point(7, 126);
            this.textBoxConsole.Multiline = true;
            this.textBoxConsole.Name = "textBoxConsole";
            this.textBoxConsole.ReadOnly = true;
            this.textBoxConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxConsole.Size = new System.Drawing.Size(292, 131);
            this.textBoxConsole.TabIndex = 18;
            // 
            // btnPictureInPicture
            // 
            this.btnPictureInPicture.Enabled = false;
            this.btnPictureInPicture.Location = new System.Drawing.Point(113, 30);
            this.btnPictureInPicture.Name = "btnPictureInPicture";
            this.btnPictureInPicture.Size = new System.Drawing.Size(133, 35);
            this.btnPictureInPicture.TabIndex = 17;
            this.btnPictureInPicture.Text = "Picture in Picture";
            this.btnPictureInPicture.UseVisualStyleBackColor = true;
            this.btnPictureInPicture.Click += new System.EventHandler(this.btnPictureInPicture_Click);
            // 
            // btnSelectVideo
            // 
            this.btnSelectVideo.Location = new System.Drawing.Point(7, 30);
            this.btnSelectVideo.Name = "btnSelectVideo";
            this.btnSelectVideo.Size = new System.Drawing.Size(100, 35);
            this.btnSelectVideo.TabIndex = 0;
            this.btnSelectVideo.Text = "Select Video";
            this.btnSelectVideo.UseVisualStyleBackColor = true;
            this.btnSelectVideo.Click += new System.EventHandler(this.btnSelectVideo_Click);
            // 
            // radioButtonResize
            // 
            this.radioButtonResize.AutoSize = true;
            this.radioButtonResize.Location = new System.Drawing.Point(18, 44);
            this.radioButtonResize.Name = "radioButtonResize";
            this.radioButtonResize.Size = new System.Drawing.Size(70, 20);
            this.radioButtonResize.TabIndex = 17;
            this.radioButtonResize.TabStop = true;
            this.radioButtonResize.Text = "Resize";
            this.radioButtonResize.UseVisualStyleBackColor = true;
            this.radioButtonResize.CheckedChanged += new System.EventHandler(this.radioButtonResize_CheckedChanged);
            // 
            // numericUpDownResize
            // 
            this.numericUpDownResize.DecimalPlaces = 1;
            this.numericUpDownResize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownResize.Location = new System.Drawing.Point(968, 150);
            this.numericUpDownResize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownResize.Name = "numericUpDownResize";
            this.numericUpDownResize.Size = new System.Drawing.Size(125, 22);
            this.numericUpDownResize.TabIndex = 17;
            this.numericUpDownResize.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // labelResize
            // 
            this.labelResize.AutoSize = true;
            this.labelResize.Location = new System.Drawing.Point(868, 152);
            this.labelResize.Name = "labelResize";
            this.labelResize.Size = new System.Drawing.Size(88, 16);
            this.labelResize.TabIndex = 18;
            this.labelResize.Text = "Resize scale:";
            // 
            // labelRotate
            // 
            this.labelRotate.AutoSize = true;
            this.labelRotate.Location = new System.Drawing.Point(868, 180);
            this.labelRotate.Name = "labelRotate";
            this.labelRotate.Size = new System.Drawing.Size(87, 16);
            this.labelRotate.TabIndex = 20;
            this.labelRotate.Text = "Rotate angle:";
            // 
            // numericUpDownAngle
            // 
            this.numericUpDownAngle.DecimalPlaces = 1;
            this.numericUpDownAngle.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownAngle.Location = new System.Drawing.Point(968, 178);
            this.numericUpDownAngle.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDownAngle.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.numericUpDownAngle.Name = "numericUpDownAngle";
            this.numericUpDownAngle.Size = new System.Drawing.Size(125, 22);
            this.numericUpDownAngle.TabIndex = 19;
            // 
            // radioButtonRotate
            // 
            this.radioButtonRotate.AutoSize = true;
            this.radioButtonRotate.Location = new System.Drawing.Point(18, 79);
            this.radioButtonRotate.Name = "radioButtonRotate";
            this.radioButtonRotate.Size = new System.Drawing.Size(68, 20);
            this.radioButtonRotate.TabIndex = 21;
            this.radioButtonRotate.TabStop = true;
            this.radioButtonRotate.Text = "Rotate";
            this.radioButtonRotate.UseVisualStyleBackColor = true;
            this.radioButtonRotate.CheckedChanged += new System.EventHandler(this.radioButtonRotate_CheckedChanged);
            // 
            // groupBoxResizeRotate
            // 
            this.groupBoxResizeRotate.Controls.Add(this.radioButtonDefault);
            this.groupBoxResizeRotate.Controls.Add(this.radioButtonResize);
            this.groupBoxResizeRotate.Controls.Add(this.radioButtonRotate);
            this.groupBoxResizeRotate.Location = new System.Drawing.Point(643, 348);
            this.groupBoxResizeRotate.Name = "groupBoxResizeRotate";
            this.groupBoxResizeRotate.Size = new System.Drawing.Size(128, 143);
            this.groupBoxResizeRotate.TabIndex = 22;
            this.groupBoxResizeRotate.TabStop = false;
            this.groupBoxResizeRotate.Text = "Resize and Rotate";
            // 
            // radioButtonDefault
            // 
            this.radioButtonDefault.AutoSize = true;
            this.radioButtonDefault.Location = new System.Drawing.Point(18, 111);
            this.radioButtonDefault.Name = "radioButtonDefault";
            this.radioButtonDefault.Size = new System.Drawing.Size(70, 20);
            this.radioButtonDefault.TabIndex = 23;
            this.radioButtonDefault.TabStop = true;
            this.radioButtonDefault.Text = "Default";
            this.radioButtonDefault.UseVisualStyleBackColor = true;
            // 
            // radioButtonCarousel
            // 
            this.radioButtonCarousel.AutoSize = true;
            this.radioButtonCarousel.Location = new System.Drawing.Point(18, 210);
            this.radioButtonCarousel.Name = "radioButtonCarousel";
            this.radioButtonCarousel.Size = new System.Drawing.Size(82, 20);
            this.radioButtonCarousel.TabIndex = 17;
            this.radioButtonCarousel.TabStop = true;
            this.radioButtonCarousel.Text = "Carousel";
            this.radioButtonCarousel.UseVisualStyleBackColor = true;
            this.radioButtonCarousel.CheckedChanged += new System.EventHandler(this.radioButtonCarousel_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 509);
            this.Controls.Add(this.groupBoxResizeRotate);
            this.Controls.Add(this.labelRotate);
            this.Controls.Add(this.numericUpDownAngle);
            this.Controls.Add(this.labelResize);
            this.Controls.Add(this.numericUpDownResize);
            this.Controls.Add(this.groupBoxVideoEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxColorMap);
            this.Controls.Add(this.labelGammaValue);
            this.Controls.Add(this.numericUpDownGamma);
            this.Controls.Add(this.groupBoxColorModifier);
            this.Controls.Add(this.trackBarVideo);
            this.Controls.Add(this.labelFrame);
            this.Controls.Add(this.btnLoadVideo);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pBVideo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pBVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVideo)).EndInit();
            this.groupBoxColorModifier.ResumeLayout(false);
            this.groupBoxColorModifier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGamma)).EndInit();
            this.groupBoxVideoEdit.ResumeLayout(false);
            this.groupBoxVideoEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngle)).EndInit();
            this.groupBoxResizeRotate.ResumeLayout(false);
            this.groupBoxResizeRotate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBVideo;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnLoadVideo;
        private System.Windows.Forms.Label labelFrame;
        private System.Windows.Forms.TrackBar trackBarVideo;
        private System.Windows.Forms.RadioButton radioButtonGray;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.RadioButton radioButtonGreen;
        private System.Windows.Forms.RadioButton radioButtonBlue;
        private System.Windows.Forms.GroupBox groupBoxColorModifier;
        private System.Windows.Forms.RadioButton radioButtonNormal;
        private System.Windows.Forms.RadioButton radioButtonGamma;
        private System.Windows.Forms.NumericUpDown numericUpDownGamma;
        private System.Windows.Forms.Label labelGammaValue;
        private System.Windows.Forms.ComboBox comboBoxColorMap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonColorMap;
        private System.Windows.Forms.GroupBox groupBoxVideoEdit;
        private System.Windows.Forms.Label labelCountVideos;
        private System.Windows.Forms.Button btnTransition;
        private System.Windows.Forms.TextBox textBoxConsole;
        private System.Windows.Forms.Button btnPictureInPicture;
        private System.Windows.Forms.Button btnSelectVideo;
        private System.Windows.Forms.RadioButton radioButtonResize;
        private System.Windows.Forms.NumericUpDown numericUpDownResize;
        private System.Windows.Forms.Label labelResize;
        private System.Windows.Forms.Label labelRotate;
        private System.Windows.Forms.NumericUpDown numericUpDownAngle;
        private System.Windows.Forms.RadioButton radioButtonRotate;
        private System.Windows.Forms.GroupBox groupBoxResizeRotate;
        private System.Windows.Forms.RadioButton radioButtonDefault;
        private System.Windows.Forms.RadioButton radioButtonCarousel;
    }
}

