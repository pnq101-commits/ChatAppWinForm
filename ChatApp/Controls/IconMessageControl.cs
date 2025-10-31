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
    public partial class IconMessageControl : UserControl
    {
        public IconMessageControl()
        {
            InitializeComponent();
        }

        public IconMessageControl(ChatMessage message)
            : this()
        {
            _message = message;
        }
        private ChatMessage _message;

        private void IconMessageControl_Load(object sender, EventArgs e)
        {
            picEmotion.Image = null;

            if (_message != null && _message.MsgType == MessageType.IconMessage)
            {
                string file = "Emotions/" + _message.Data + ".png";

                if (File.Exists(file))
                {
                    picEmotion.Image = Image.FromFile(file);
                }

                lblSendTime.Text = _message.SendTime.ToString("dd/MM/yyyy HH:mm:ss");
            }
        }
    }
}
