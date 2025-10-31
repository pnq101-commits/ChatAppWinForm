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
    public partial class FormPlayer : Form
    {
        public FormPlayer()
        {
            InitializeComponent();
        }

        private void FormPlayer_Load(object sender, EventArgs e)
        {
            lblLabel.Text = ConfigHelper.L("PLAYER_TITLE");
        }

        public void PlayFile(string url)
        {
            try
            {
                player.URL = url;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ! " + ex.Message
                    , "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
