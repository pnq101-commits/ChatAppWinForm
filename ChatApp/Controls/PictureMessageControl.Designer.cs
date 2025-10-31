namespace ChatApp.Controls
{
    partial class PictureMessageControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureMessageControl));
            this.lblSendTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.picImage = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSendTime
            // 
            this.lblSendTime.BackColor = System.Drawing.Color.Transparent;
            this.lblSendTime.Font = new System.Drawing.Font("Arial", 12.5F);
            this.lblSendTime.ForeColor = System.Drawing.Color.Red;
            this.lblSendTime.Location = new System.Drawing.Point(16, 23);
            this.lblSendTime.Name = "lblSendTime";
            this.lblSendTime.Size = new System.Drawing.Size(131, 21);
            this.lblSendTime.TabIndex = 3;
            this.lblSendTime.Text = "12/03/2024 05:17";
            // 
            // picImage
            // 
            this.picImage.Image = ((System.Drawing.Image)(resources.GetObject("picImage.Image")));
            this.picImage.ImageRotate = 0F;
            this.picImage.Location = new System.Drawing.Point(201, 13);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(160, 131);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 4;
            this.picImage.TabStop = false;
            // 
            // PictureMessageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.lblSendTime);
            this.Name = "PictureMessageControl";
            this.Size = new System.Drawing.Size(521, 157);
            this.Load += new System.EventHandler(this.PictureMessageControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblSendTime;
        private Guna.UI2.WinForms.Guna2PictureBox picImage;
    }
}
