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
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        public class LanguageModel
        {
            public string Key { get; set; }
            public string Value { get; set; }
        }

        bool isFormLoaded = false;
        private void FormSettings_Load(object sender, EventArgs e)
        {
            isFormLoaded = true;
            LoadGui();
            cboLanguages.DataSource = new List<LanguageModel>()
            {
                new LanguageModel() { Key = "en", Value = "English" },
                new LanguageModel() { Key = "vn", Value = "Tiếng Việt" },
            };

            cboLanguages.DisplayMember = "Value";
            cboLanguages.ValueMember = "Key";
            cboLanguages.SelectedValue = ConfigHelper.CURRENT_LANG;
            pnlTitle.BackColor = ConfigHelper.C("CHAT_TITLE_BACKGROUND");
            pnlTrai.BackColor = ConfigHelper.C("CHAT_LEFT_PANEL_BACKGROUND");
            pnlTrungTam.BackColor = ConfigHelper.C("CHAT_CENTER_PANEL_BACKGROUND");
            pnlPhai.BackColor = ConfigHelper.C("CHAT_RIGHT_PANEL_BACKGROUND");
            pnlButtonFromColor.BackColor = ConfigHelper.C("CHAT_BUTTON_FROM_COLOR");
            pnlButtonToColor.BackColor = ConfigHelper.C("CHAT_BUTTON_TO_COLOR");
            isFormLoaded = false;
        }

        private void LoadGui()
        {
            lblSettingTitle.Text = ConfigHelper.L("SETTING_FORM_TITLE");
            lblLanguage.Text = ConfigHelper.L("SETTING_FORM_LABEL_LANGUAGE");
            btnApply.Text = ConfigHelper.L("SETTING_FORM_BTN_APPLY");
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            var current = cboLanguages.SelectedItem as LanguageModel;
            
            if (current != null)
            {
                ConfigHelper.CURRENT_LANG = current.Key;
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void pnlTitle_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pnlTitle_DoubleClick(object sender, EventArgs e)
        {
            var result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                pnlTitle.BackColor = colorDialog1.Color;
                ConfigHelper.SET_C("CHAT_TITLE_BACKGROUND", pnlTitle.BackColor);
            }
        }

        private void pnlTrai_DoubleClick(object sender, EventArgs e)
        {
            var result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                pnlTrai.BackColor = colorDialog1.Color;
                ConfigHelper.SET_C("CHAT_LEFT_PANEL_BACKGROUND", pnlTrai.BackColor);
            }
        }

        private void pnlTrungTam_DoubleClick(object sender, EventArgs e)
        {
            var result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                pnlTrungTam.BackColor = colorDialog1.Color;
                ConfigHelper.SET_C("CHAT_CENTER_PANEL_BACKGROUND", pnlTrungTam.BackColor);
            }
        }

        private void pnlPhai_DoubleClick(object sender, EventArgs e)
        {
            var result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                pnlPhai.BackColor = colorDialog1.Color;
                ConfigHelper.SET_C("CHAT_RIGHT_PANEL_BACKGROUND", pnlPhai.BackColor);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var current = cboLanguages.SelectedItem as LanguageModel;

            if (current != null)
            {
                ConfigHelper.CURRENT_LANG = current.Key;
            }

            ConfigHelper.Save();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pnlButtonFromColor_DoubleClick(object sender, EventArgs e)
        {
            var result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                pnlButtonFromColor.BackColor = colorDialog1.Color;
                ConfigHelper.SET_C("CHAT_BUTTON_FROM_COLOR", pnlButtonFromColor.BackColor);
            }
        }

        private void pnlButtonToColor_DoubleClick(object sender, EventArgs e)
        {
            var result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                pnlButtonToColor.BackColor = colorDialog1.Color;
                ConfigHelper.SET_C("CHAT_BUTTON_TO_COLOR", pnlButtonToColor.BackColor);
            }
        }
    }
}
