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
            this.checkBoxGray = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVideo)).BeginInit();
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
            // checkBoxGray
            // 
            this.checkBoxGray.AutoSize = true;
            this.checkBoxGray.Location = new System.Drawing.Point(658, 64);
            this.checkBoxGray.Name = "checkBoxGray";
            this.checkBoxGray.Size = new System.Drawing.Size(58, 20);
            this.checkBoxGray.TabIndex = 5;
            this.checkBoxGray.Text = "Gray";
            this.checkBoxGray.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 470);
            this.Controls.Add(this.checkBoxGray);
            this.Controls.Add(this.trackBarVideo);
            this.Controls.Add(this.labelFrame);
            this.Controls.Add(this.btnLoadVideo);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pBVideo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pBVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBVideo;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnLoadVideo;
        private System.Windows.Forms.Label labelFrame;
        private System.Windows.Forms.TrackBar trackBarVideo;
        private System.Windows.Forms.CheckBox checkBoxGray;
    }
}

