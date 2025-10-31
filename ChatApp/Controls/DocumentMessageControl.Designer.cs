namespace ChatApp.Controls
{
    partial class DocumentMessageControl
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
            this.lblSendTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMessage = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // lblSendTime
            // 
            this.lblSendTime.BackColor = System.Drawing.Color.Transparent;
            this.lblSendTime.Font = new System.Drawing.Font("Arial", 12.5F);
            this.lblSendTime.ForeColor = System.Drawing.Color.Red;
            this.lblSendTime.Location = new System.Drawing.Point(13, 16);
            this.lblSendTime.Name = "lblSendTime";
            this.lblSendTime.Size = new System.Drawing.Size(154, 21);
            this.lblSendTime.TabIndex = 0;
            this.lblSendTime.Text = "00/00/0000 00:00:00";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = false;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Arial", 12.5F);
            this.lblMessage.ForeColor = System.Drawing.Color.MintCream;
            this.lblMessage.Location = new System.Drawing.Point(184, 16);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(324, 21);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Hello ! Welcome to my Chat App !";
            // 
            // DocumentMessageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblSendTime);
            this.Name = "DocumentMessageControl";
            this.Size = new System.Drawing.Size(525, 48);
            this.Load += new System.EventHandler(this.DocumentMessageControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblSendTime;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMessage;
    }
}
