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
    public partial class UserOnlineControl : UserControl
    {
        public delegate void ReceiverSelectDelegate(User user);
        public event ReceiverSelectDelegate ReceiverSelectedHandler;

        private  User _user;

        public UserOnlineControl()
        {
            InitializeComponent();
        }

        public UserOnlineControl(User user)
            : this()
        {
            _user = user;
        }

        private void UserOnlineControl_Load(object sender, EventArgs e)
        {
            if (_user == null) { return; }

            lblName.Text = _user.FullName;

            if (File.Exists("Avatars/" + _user.AvatarUrl))
            {
                picAvatar.Image = Image.FromFile("Avatars/" + _user.AvatarUrl);
            }
        }

        private void picAvatar_Click(object sender, EventArgs e)
        {
            UserOnlineControl_Click(sender, e);
        }

        private void UserOnlineControl_Click(object sender, EventArgs e)
        {
            if (_user == null)
                return;

            if (ReceiverSelectedHandler != null)
                ReceiverSelectedHandler(_user);
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            UserOnlineControl_Click(sender, e);
        }

        public void SetUser(User user)
        {
            if (user == null)
                return;

            _user = user;
            
            lblName.Text = _user.FullName;

            if (File.Exists("Avatars/" + _user.AvatarUrl))
            {
                picAvatar.Image = Image.FromFile("Avatars/" + _user.AvatarUrl);
            }
        }
    }
}
