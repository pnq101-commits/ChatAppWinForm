using ChatApp.Controls;
using ChatApp.DAL;
using ChatApp.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace ChatApp
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        public static List<User> Receivers;


        // Khởi tạo Form với thông tin người dùng đăng nhập
        public ClientForm(User user)
            : this()
        {
            User = user;
        }

        public static User User;
        public static User Receiver;
        ChatMessageDAL _chatMessageDAL = new ChatMessageDAL();
        UserDAL _userDAL = new UserDAL();
        // Sự kiện xảy ra khi người dùng nhấn nút gửi
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMessage.Text))
                return;

            if (Receiver == null)
            {
                MessageBox.Show(ConfigHelper.L("CLIENT_ALERT_SELECT_PEOPLE_FROM_LIST")
                    , ConfigHelper.L("CLIENT_ALERT_CAPTION"), MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }

            // Tạo mới một thông điệp có kiểu Document
            ChatMessage msg = new ChatMessage();
            msg.SenderId = User.UserId;
            msg.SendTime = DateTime.Now;
            msg.MsgType = MessageType.DocumentMessage;
            msg.Data = txtMessage.Text;
            msg.ReceiverId = Receiver.UserId;
            _chatMessageDAL.Insert(msg);
            // Khởi tạo Control truyền tham số là thông điệp
            DocumentMessageControl control = new DocumentMessageControl(msg);
            // Thêm Control vào khung layout hiển thị
            layoutMessages.Controls.Add(control);
            layoutMessages.ScrollControlIntoView(control);
            txtMessage.Text = "";
        }

        private void LoadGUI()
        {
            btnHome.Text = ConfigHelper.L("CLIENT_BTN_HOME");
            btnChat.Text = ConfigHelper.L("CLIENT_BTN_CHAT");
            btnSettings.Text = ConfigHelper.L("CLIENT_BTN_SETTINGS");
            btnHelp.Text = ConfigHelper.L("CLIENT_BTN_HELP");
            btnExit.Text = ConfigHelper.L("CLIENT_BTN_EXIT");
            btnSendFile.Text = ConfigHelper.L("CLIENT_BTN_SEND_FILE");
            lblClientTitle.Text = ConfigHelper.L("CLIENT_LBL_TITLE");

        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

            LoadGUI();
            LoadColors();

            if (User != null)
            {
                Receivers = _userDAL.GetAllReceiverExcept(User.UserId);

                lblEmail.Text = User.Email;
                if (File.Exists("Avatars/" + User.AvatarUrl))
                {
                    picUserAvatar.Image = Image.FromFile("Avatars/" + User.AvatarUrl);
                }

                layoutMessages.Controls.Clear();
            }

            LoadReceivers();
        }

        private void LoadReceivers()
        {
            pnlUsers.Controls.Clear();

            if (Receivers == null)
                return;

            foreach (var receiver in Receivers)
            {
                UserOnlineControl control = new UserOnlineControl(receiver);
                control.ReceiverSelectedHandler += Control_ReceiverSelectedHandler;
                pnlUsers.Controls.Add(control);
            }
        }

        private void Control_ReceiverSelectedHandler(User receiver)
        {
            ctrCurrentReceiver.SetUser(receiver);
            Receiver = receiver;
            layoutMessages.Controls.Clear();
            LoadChatMessages();
            // Load Old Message base on current receiver
        }

        private void LoadChatMessages()
        {
            List<ChatMessage> messages = _chatMessageDAL.GetBy(User.UserId, Receiver.UserId);
            
            foreach (ChatMessage message in messages)
            { 
                if (message.MsgType == MessageType.DocumentMessage)
                {
                    DocumentMessageControl control = new DocumentMessageControl(message);
                    layoutMessages.Controls.Add(control);
                    layoutMessages.ScrollControlIntoView(control);
                }

                if (message.MsgType == MessageType.IconMessage)
                {
                    IconMessageControl control = new IconMessageControl(message);
                    layoutMessages.Controls.Add(control);
                    layoutMessages.ScrollControlIntoView(control);
                }

                if (message.MsgType == MessageType.PictureMessage)
                {
                    PictureMessageControl control = new PictureMessageControl(message);
                    layoutMessages.Controls.Add(control);
                    layoutMessages.ScrollControlIntoView(control);
                }

                if (message.MsgType == MessageType.VideoMessage)
                {
                    VideoMessageControl control = new VideoMessageControl(message);
                    layoutMessages.Controls.Add(control);
                    layoutMessages.ScrollControlIntoView(control);
                }
            }
        }

        private void btnEmotionSad_Click(object sender, EventArgs e)
        {
            if (Receiver == null)
            {
                MessageBox.Show(ConfigHelper.L("CLIENT_ALERT_SELECT_PEOPLE_FROM_LIST")
                    , ConfigHelper.L("CLIENT_ALERT_CAPTION"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ChatMessage msg = new ChatMessage();
            msg.SenderId = User.UserId;
            msg.SendTime = DateTime.Now;
            msg.MsgType = MessageType.IconMessage;
            msg.Data = "sad";
            msg.ReceiverId = Receiver.UserId;
            _chatMessageDAL.Insert(msg);
            IconMessageControl control = new IconMessageControl(msg);
            layoutMessages.Controls.Add(control);
            layoutMessages.ScrollControlIntoView(control);
        }

        private void btnEmotionLove_Click(object sender, EventArgs e)
        {
            if (Receiver == null)
            {
                MessageBox.Show(ConfigHelper.L("CLIENT_ALERT_SELECT_PEOPLE_FROM_LIST")
                    , ConfigHelper.L("CLIENT_ALERT_CAPTION"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ChatMessage msg = new ChatMessage();
            msg.SenderId = User.UserId;
            msg.SendTime = DateTime.Now;
            msg.MsgType = MessageType.IconMessage;
            msg.ReceiverId = Receiver.UserId;
            msg.Data = "love";
            _chatMessageDAL.Insert(msg);
            IconMessageControl control = new IconMessageControl(msg);
            layoutMessages.Controls.Add(control);
            layoutMessages.ScrollControlIntoView(control);
        }

        private void btnEmotionSmile_Click(object sender, EventArgs e)
        {
            if (Receiver == null)
            {
                MessageBox.Show(ConfigHelper.L("CLIENT_ALERT_SELECT_PEOPLE_FROM_LIST")
                    , ConfigHelper.L("CLIENT_ALERT_CAPTION"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ChatMessage msg = new ChatMessage();
            msg.SenderId = User.UserId;
            msg.SendTime = DateTime.Now;
            msg.MsgType = MessageType.IconMessage;
            msg.ReceiverId = Receiver.UserId;
            msg.Data = "smile";
            _chatMessageDAL.Insert(msg);
            IconMessageControl control = new IconMessageControl(msg);
            layoutMessages.Controls.Add(control);
            layoutMessages.ScrollControlIntoView(control);
        }

        private void btnEmotionHungry_Click(object sender, EventArgs e)
        {
            if (Receiver == null)
            {
                MessageBox.Show(ConfigHelper.L("CLIENT_ALERT_SELECT_PEOPLE_FROM_LIST")
                    , ConfigHelper.L("CLIENT_ALERT_CAPTION"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ChatMessage msg = new ChatMessage();
            msg.SenderId = User.UserId;
            msg.SendTime = DateTime.Now;
            msg.MsgType = MessageType.IconMessage;
            msg.ReceiverId = Receiver.UserId;
            msg.Data = "hungry";
            _chatMessageDAL.Insert(msg);
            IconMessageControl control = new IconMessageControl(msg);
            layoutMessages.Controls.Add(control);
            layoutMessages.ScrollControlIntoView(control);
        }

        private void btnEmotionThink_Click(object sender, EventArgs e)
        {
            if (Receiver == null)
            {
                MessageBox.Show(ConfigHelper.L("CLIENT_ALERT_SELECT_PEOPLE_FROM_LIST")
                    , ConfigHelper.L("CLIENT_ALERT_CAPTION"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ChatMessage msg = new ChatMessage();
            msg.SenderId = User.UserId;
            msg.SendTime = DateTime.Now;
            msg.MsgType = MessageType.IconMessage;
            msg.ReceiverId = Receiver.UserId;
            msg.Data = "think";
            _chatMessageDAL.Insert(msg);
            IconMessageControl control = new IconMessageControl(msg);
            layoutMessages.Controls.Add(control);
            layoutMessages.ScrollControlIntoView(control);
        }

        private void ClientForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend_Click(sender, e);
            }
        }

        static string[] imageExtensions = {
            ".PNG", ".JPG", ".JPEG", ".BMP" //etc
        };

        static string[] videoExtensions =
        {
            ".WAV", ".WMA", ".MP3", //etc
            ".AVI", ".MP4", ".DIVX", ".WMV", //etc
        };

        static bool IsImageFile(string path)
        {
            return -1 != Array.IndexOf(imageExtensions, Path.GetExtension(path).ToUpperInvariant());
        }

        static bool IsVideoFile(string path)
        {
            return -1 != Array.IndexOf(videoExtensions, Path.GetExtension(path).ToUpperInvariant());
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            if (Receiver == null)
            {
                MessageBox.Show(ConfigHelper.L("CLIENT_ALERT_SELECT_PEOPLE_FROM_LIST")
                    , ConfigHelper.L("CLIENT_ALERT_CAPTION"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OpenFileDialog res = new OpenFileDialog();

            StringBuilder sb = new StringBuilder();

            foreach (var str in imageExtensions)
            {
                sb.Append("*" + str.ToLowerInvariant() + ";");
            }

            res.Filter =  ConfigHelper.L("CLIENT_SELECT_FILE_FILTER_PICTURE") + "|" + sb.ToString();

            sb.Clear();

            foreach(var str in videoExtensions)
            {
                sb.Append("*" + str.ToLowerInvariant() + ";");
            }

            res.Filter += "|" + ConfigHelper.L("CLIENT_SELECT_FILE_FILTER_VIDEO") + "|" + sb.ToString();

            res.CheckFileExists = true;

            //When the user select the file
            if (res.ShowDialog() != DialogResult.OK)
                return;

            //Get the file's path
            var filePath = res.FileName;

            if (!(IsImageFile(filePath) || IsVideoFile(filePath)))
                return;

            // Tạo thư mục chứa tập tin tương ứng với người dùng

            if (!Directory.Exists(User.UserId))
            {
                Directory.CreateDirectory(User.UserId);
            }


            string saveFilePath = Path.Combine(User.UserId
                , Guid.NewGuid().ToString() + Path.GetExtension(filePath).ToLowerInvariant());
            
            if (!File.Exists(saveFilePath))
            {
                File.Copy(filePath, saveFilePath);
            }

            ChatMessage msg = new ChatMessage();
            msg.SenderId = User.UserId;
            msg.SendTime = DateTime.Now;

            if (IsImageFile(filePath))
                msg.MsgType = MessageType.PictureMessage;

            if (IsVideoFile(filePath))
                msg.MsgType = MessageType.VideoMessage;
            msg.ReceiverId = Receiver.UserId;
            msg.Data = saveFilePath;
            _chatMessageDAL.Insert(msg);
            if (IsImageFile(filePath))
            {
                PictureMessageControl control = new PictureMessageControl(msg);
                layoutMessages.Controls.Add(control);
                layoutMessages.ScrollControlIntoView(control);
            }

            if (IsVideoFile(filePath))
            {
                VideoMessageControl control = new VideoMessageControl(msg);
                layoutMessages.Controls.Add(control);
                layoutMessages.ScrollControlIntoView(control);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show(ConfigHelper.L("CLIENT_LOGOUT_ALERT")
                , ConfigHelper.L("CLIENT_ALERT_CAPTION"), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (answer == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FormSettings frm = new FormSettings();
            
            var result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadGUI();
                LoadColors();
            }
        }

        private void LoadColors()
        {
            pnlTitle.BackColor = ConfigHelper.C("CHAT_TITLE_BACKGROUND");
            panelLeft.BackColor = ConfigHelper.C("CHAT_LEFT_PANEL_BACKGROUND");
            layoutMessages.BackColor = ConfigHelper.C("CHAT_CENTER_PANEL_BACKGROUND");
            pnlUsers.BackColor = ConfigHelper.C("CHAT_RIGHT_PANEL_BACKGROUND");
            btnHome.FillColor = ConfigHelper.C("CHAT_BUTTON_FROM_COLOR");
            btnHome.FillColor2 = ConfigHelper.C("CHAT_BUTTON_TO_COLOR");
            btnChat.FillColor = ConfigHelper.C("CHAT_BUTTON_FROM_COLOR");
            btnChat.FillColor2 = ConfigHelper.C("CHAT_BUTTON_TO_COLOR");
            btnSettings.FillColor = ConfigHelper.C("CHAT_BUTTON_FROM_COLOR");
            btnSettings.FillColor2 = ConfigHelper.C("CHAT_BUTTON_TO_COLOR");
            btnExit.FillColor = ConfigHelper.C("CHAT_BUTTON_FROM_COLOR");
            btnExit.FillColor2 = ConfigHelper.C("CHAT_BUTTON_TO_COLOR");
            btnSendFile.FillColor = ConfigHelper.C("CHAT_BUTTON_FROM_COLOR");
            btnSendFile.FillColor2 = ConfigHelper.C("CHAT_BUTTON_TO_COLOR");
            btnHelp.FillColor = ConfigHelper.C("CHAT_BUTTON_FROM_COLOR");
            btnHelp.FillColor2 = ConfigHelper.C("CHAT_BUTTON_TO_COLOR");
        }
    }
}
