namespace ChatApp.Controls
{
    partial class IconMessageControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IconMessageControl));
            this.lblSendTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.picEmotion = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picEmotion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSendTime
            // 
            this.lblSendTime.BackColor = System.Drawing.Color.Transparent;
            this.lblSendTime.Font = new System.Drawing.Font("Arial", 12.5F);
            this.lblSendTime.ForeColor = System.Drawing.Color.Red;
            this.lblSendTime.Location = new System.Drawing.Point(16, 16);
            this.lblSendTime.Name = "lblSendTime";
            this.lblSendTime.Size = new System.Drawing.Size(154, 21);
            this.lblSendTime.TabIndex = 2;
            this.lblSendTime.Text = "00/00/0000 00:00:00";
            // 
            // picEmotion
            // 
            this.picEmotion.Image = ((System.Drawing.Image)(resources.GetObject("picEmotion.Image")));
            this.picEmotion.ImageRotate = 0F;
            this.picEmotion.Location = new System.Drawing.Point(205, 4);
            this.picEmotion.Name = "picEmotion";
            this.picEmotion.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picEmotion.Size = new System.Drawing.Size(40, 38);
            this.picEmotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEmotion.TabIndex = 3;
            this.picEmotion.TabStop = false;
            // 
            // IconMessageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picEmotion);
            this.Controls.Add(this.lblSendTime);
            this.Name = "IconMessageControl";
            this.Size = new System.Drawing.Size(545, 47);
            this.Load += new System.EventHandler(this.IconMessageControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picEmotion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblSendTime;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picEmotion;
    }
}
