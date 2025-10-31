using ChatApp.DAL;
using ChatApp.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegister frm = new FormRegister();
            frm.ShowDialog();
            this.Show();
        }

        UserDAL _userDAL = new UserDAL();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show(ConfigHelper.L("LOGIN_ALERT_EMAIL_EMPTY")
                                    , ConfigHelper.L("LOGIN_ALERT_BOX_CAPTION"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show(ConfigHelper.L("LOGIN_ALERT_PASSWORD_EMPTY")
                                    , ConfigHelper.L("LOGIN_ALERT_BOX_CAPTION"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            
            User user = _userDAL.Login(txtEmail.Text, txtPassword.Text);
            
            if (user != null)
            {
                this.Hide();

                ClientForm frm = new ClientForm(user);
                frm.ShowDialog();

                this.Show();

            }
            else
            {
                MessageBox.Show(ConfigHelper.L("LOGIN_ALERT_LOGIN_FAIL")
                                    , ConfigHelper.L("LOGIN_ALERT_BOX_CAPTION"), MessageBoxButtons.OK, MessageBoxIcon.Error);

            } 

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            lblLoginTitle.Text = ConfigHelper.L("LOGIN_TITLE");
            lblLoginEmail.Text = ConfigHelper.L("LOGIN_EMAIL");
            lblLoginPassword.Text = ConfigHelper.L("LOGIN_PASSWORD");
            btnDangKy.Text = ConfigHelper.L("LOGIN_BTN_DANGKY");
            btnDangNhap.Text = ConfigHelper.L("LOGIN_BTN_DANGNHAP");
        }
    }
}
