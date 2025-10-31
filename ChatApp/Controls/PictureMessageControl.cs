using ChatApp.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp.Controls
{
    public partial class PictureMessageControl : UserControl
    {
        private readonly ChatMessage _message;

        public PictureMessageControl()
        {
            InitializeComponent();
        }

        public PictureMessageControl(ChatMessage message)
            : this()
        {
            _message = message;
        }

        private void PictureMessageControl_Load(object sender, EventArgs e)
        {
            if (_message != null 
                && _message.MsgType == MessageType.PictureMessage)
            {
                lblSendTime.Text = _message.SendTime.ToString("dd/MM/yyyy HH:mm:ss");
                
                if (File.Exists(_message.Data))
                {
                    picImage.Image = Image.FromFile(_message.Data);
                }
            }
        }
    }
}
