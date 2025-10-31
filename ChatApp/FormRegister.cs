using ChatApp.DAL;
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

namespace ChatApp
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        UserDAL _userDal = new UserDAL();
        string selectedAvatar = null;
        string currentAvatar = null;
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show(ConfigHelper.L("REGISTER_ALERT_FULLNAME_EMPTY")
                                    , ConfigHelper.L("REGISTER_ALERT_BOX_CAPTION"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show(ConfigHelper.L("REGISTER_ALERT_EMAIL_EMPTY")
                                    , ConfigHelper.L("REGISTER_ALERT_BOX_CAPTION"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show(ConfigHelper.L("REGISTER_ALERT_PASSWORD_EMPTY")
                                    , ConfigHelper.L("REGISTER_ALERT_BOX_CAPTION"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (_userDal.GetBy().Any(x => x.Email == txtEmail.Text))
            {
                MessageBox.Show( ConfigHelper.L("REGISTER_ALERT_EMAIL_EXISTS")
                    , ConfigHelper.L("REGISTER_ALERT_BOX_CAPTION"), MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }

            User user = new User();
            user.FullName = txtFullName.Text;
            user.Email = txtEmail.Text;
            user.Password = txtPassword.Text;

            if (!string.IsNullOrWhiteSpace(selectedAvatar))
                user.AvatarUrl = selectedAvatar;
            else
                user.AvatarUrl = "4.jpg";
            
            _userDal.Insert(user);

            this.Close();
        }

        static string[] imageExtensions = {
            ".PNG", ".JPG", ".JPEG", ".BMP" //etc
        };

        static bool IsImageFile(string path)
        {
            return -1 != Array.IndexOf(imageExtensions
                , Path.GetExtension(path).ToUpperInvariant());
        }

        private void btnChonAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog res = new OpenFileDialog();

            StringBuilder sb = new StringBuilder();

            foreach (var str in imageExtensions)
            {
                sb.Append("*" + str.ToLowerInvariant() + ";");
            }

            res.Filter =  ConfigHelper.L("REGISTER_OPEN_AVARTA_DIALOG_FILTER") + "|" + sb.ToString();

            res.CheckFileExists = true;

            //When the user select the file
            if (res.ShowDialog() != DialogResult.OK)
                return;

            //Get the file's path
            var filePath = res.FileName;

            if (!(IsImageFile(filePath)))
                return;

            selectedAvatar = Guid.NewGuid().ToString() + Path.GetExtension(filePath).ToLowerInvariant();
            string saveFilePath = Path.Combine("Avatars"
                , selectedAvatar);

            if (!File.Exists(saveFilePath))
            {
                File.Copy(filePath, saveFilePath);
                picAvatar.Image = Image.FromFile(saveFilePath);
            }
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            lblRegisterTitle.Text = ConfigHelper.L("REGISTER_TITLE");
            lblFullName.Text = ConfigHelper.L("REGISTER_FULLNAME");
            lblEmail.Text = ConfigHelper.L("REGISTER_EMAIL");
            lblPassword.Text = ConfigHelper.L("REGISTER_PASSWORD");
            btnDangKy.Text = ConfigHelper.L("REGISTER_BTN_DANGKY");
            lblLabelAvatar.Text = ConfigHelper.L("REGISTER_LABEL_AVATAR");
            btnChonAvatar.Text = ConfigHelper.L("REGISTER_SELECT_AVATAR");
        }
    }
}
