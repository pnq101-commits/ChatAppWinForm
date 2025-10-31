using ChatApp.Entity;
using ChatApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp.Controls
{
    public partial class VideoMessageControl : UserControl
    {
        private readonly ChatMessage _message;

        public VideoMessageControl()
        {
            InitializeComponent();
        }

        public VideoMessageControl(ChatMessage message)
            : this()
        {
            _message = message;
        }

        private void VideoMessageControl_Load(object sender, EventArgs e)
        {
            if (_message != null
                && _message.MsgType == MessageType.VideoMessage)
            {
                lblSendTime.Text = _message.SendTime.ToString("dd/MM/yyyy HH:mm:ss");
                
                if (File.Exists("Images/play.png"))
                {
                    picVideoThumb.Image = Image.FromFile("Images/play.png");
                    lblInfo.Text = "Nhấn vào để play !";
                }
            }
        }

        private void picVideoThumb_Click(object sender, EventArgs e)
        {
            if (_message != null 
                &&  _message.MsgType == MessageType.VideoMessage)
            {
                if (File.Exists(_message.Data))
                {
                    FormPlayer player = new FormPlayer();
                    player.Show();
                    player.PlayFile(_message.Data);
                }
            }
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {
            picVideoThumb_Click(sender, e);
        }
    }
}
