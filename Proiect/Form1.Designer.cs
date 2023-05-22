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
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pBVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVideo)).BeginInit();
            this.groupBoxColorModifier.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBVideo
            // 
            this.pBVideo.Location = new System.Drawing.Point(12, 12);
            this.pBVideo.Name = "pBVideo";
            this.pBVideo.Size = new System.Drawing.Size(610, 297);
            this.pBVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBVideo.TabIndex = 0;
            this.pBVideo.TabStop = false;
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
            this.groupBoxColorModifier.Controls.Add(this.radioButtonNormal);
            this.groupBoxColorModifier.Controls.Add(this.radioButtonRed);
            this.groupBoxColorModifier.Controls.Add(this.radioButtonBlue);
            this.groupBoxColorModifier.Controls.Add(this.radioButtonGray);
            this.groupBoxColorModifier.Controls.Add(this.radioButtonGreen);
            this.groupBoxColorModifier.Location = new System.Drawing.Point(643, 12);
            this.groupBoxColorModifier.Name = "groupBoxColorModifier";
            this.groupBoxColorModifier.Size = new System.Drawing.Size(128, 214);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 470);
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
    }
}

