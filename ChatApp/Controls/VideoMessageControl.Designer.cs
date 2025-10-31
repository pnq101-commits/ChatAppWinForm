namespace ChatApp.Controls
{
    partial class VideoMessageControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoMessageControl));
            this.picVideoThumb = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblSendTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblInfo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picVideoThumb)).BeginInit();
            this.SuspendLayout();
            // 
            // picVideoThumb
            // 
            this.picVideoThumb.Image = ((System.Drawing.Image)(resources.GetObject("picVideoThumb.Image")));
            this.picVideoThumb.ImageRotate = 0F;
            this.picVideoThumb.Location = new System.Drawing.Point(206, 19);
            this.picVideoThumb.Name = "picVideoThumb";
            this.picVideoThumb.Size = new System.Drawing.Size(160, 131);
            this.picVideoThumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVideoThumb.TabIndex = 6;
            this.picVideoThumb.TabStop = false;
            this.picVideoThumb.Click += new System.EventHandler(this.picVideoThumb_Click);
            // 
            // lblSendTime
            // 
            this.lblSendTime.BackColor = System.Drawing.Color.Transparent;
            this.lblSendTime.Font = new System.Drawing.Font("Arial", 12.5F);
            this.lblSendTime.ForeColor = System.Drawing.Color.Red;
            this.lblSendTime.Location = new System.Drawing.Point(21, 29);
            this.lblSendTime.Name = "lblSendTime";
            this.lblSendTime.Size = new System.Drawing.Size(131, 21);
            this.lblSendTime.TabIndex = 5;
            this.lblSendTime.Text = "12/03/2024 05:17";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = false;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Arial", 12.5F);
            this.lblInfo.ForeColor = System.Drawing.Color.Green;
            this.lblInfo.Location = new System.Drawing.Point(372, 70);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(211, 50);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // VideoMessageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picVideoThumb);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblSendTime);
            this.Name = "VideoMessageControl";
            this.Size = new System.Drawing.Size(597, 170);
            this.Load += new System.EventHandler(this.VideoMessageControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picVideoThumb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picVideoThumb;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSendTime;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblInfo;
    }
}
