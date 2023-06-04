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
            this.components = new System.ComponentModel.Container();
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
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            this.numericUpDownGamma = new System.Windows.Forms.NumericUpDown();
            this.labelGammaValue = new System.Windows.Forms.Label();
            this.radioButtonGamma = new System.Windows.Forms.RadioButton();
            this.comboBoxColorMap = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radioButtonColorMap = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pBVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVideo)).BeginInit();
            this.groupBoxColorModifier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
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
            this.groupBoxColorModifier.Controls.Add(this.radioButtonColorMap);
            this.groupBoxColorModifier.Controls.Add(this.radioButtonGamma);
            this.groupBoxColorModifier.Controls.Add(this.radioButtonNormal);
            this.groupBoxColorModifier.Controls.Add(this.radioButtonRed);
            this.groupBoxColorModifier.Controls.Add(this.radioButtonBlue);
            this.groupBoxColorModifier.Controls.Add(this.radioButtonGray);
            this.groupBoxColorModifier.Controls.Add(this.radioButtonGreen);
            this.groupBoxColorModifier.Location = new System.Drawing.Point(643, 12);
            this.groupBoxColorModifier.Name = "groupBoxColorModifier";
            this.groupBoxColorModifier.Size = new System.Drawing.Size(128, 288);
            this.groupBoxColorModifier.TabIndex = 11;
            this.groupBoxColorModifier.TabStop = false;
            this.groupBoxColorModifier.Text = "ColorModifiers";
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
            // radioButtonGamma
            // 
            this.radioButtonGamma.AutoSize = true;
            this.radioButtonGamma.Location = new System.Drawing.Point(18, 210);
            this.radioButtonGamma.Name = "radioButtonGamma";
            this.radioButtonGamma.Size = new System.Drawing.Size(76, 20);
            this.radioButtonGamma.TabIndex = 14;
            this.radioButtonGamma.TabStop = true;
            this.radioButtonGamma.Text = "Gamma";
            this.radioButtonGamma.UseVisualStyleBackColor = true;
            this.radioButtonGamma.CheckedChanged += new System.EventHandler(this.radioButtonGamma_CheckedChanged);
            // 
            // comboBoxColorMap
            // 
            this.comboBoxColorMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColorMap.FormattingEnabled = true;
            this.comboBoxColorMap.Location = new System.Drawing.Point(968, 146);
            this.comboBoxColorMap.Name = "comboBoxColorMap";
            this.comboBoxColorMap.Size = new System.Drawing.Size(125, 24);
            this.comboBoxColorMap.TabIndex = 14;
            this.comboBoxColorMap.SelectedIndexChanged += new System.EventHandler(this.comboBoxColorMap_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(852, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Color map mode:";
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(Proiect.Form1);
            // 
            // radioButtonColorMap
            // 
            this.radioButtonColorMap.AutoSize = true;
            this.radioButtonColorMap.Location = new System.Drawing.Point(18, 245);
            this.radioButtonColorMap.Name = "radioButtonColorMap";
            this.radioButtonColorMap.Size = new System.Drawing.Size(90, 20);
            this.radioButtonColorMap.TabIndex = 16;
            this.radioButtonColorMap.TabStop = true;
            this.radioButtonColorMap.Text = "Color Map";
            this.radioButtonColorMap.UseVisualStyleBackColor = true;
            this.radioButtonColorMap.CheckedChanged += new System.EventHandler(this.radioButtonColorMap_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 470);
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
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.RadioButton radioButtonColorMap;
    }
}

