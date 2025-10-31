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

namespace ChatApp.Controls
{
    public partial class DocumentMessageControl : UserControl
    {
        private readonly ChatMessage _message;

        public DocumentMessageControl()
        {
            InitializeComponent();
        }

        public DocumentMessageControl(ChatMessage message)
            : this()
        {
            _message = message;
        }

        private void DocumentMessageControl_Load(object sender, EventArgs e)
        {
            if (_message != null)
            {
                lblSendTime.Text = _message.SendTime.ToString("dd/MM/yyyy HH:mm:ss");
                lblMessage.Text = _message.Data;
            }
        }
    }
}
