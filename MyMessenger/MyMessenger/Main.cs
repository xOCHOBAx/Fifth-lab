using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMessenger
{
    public partial class Main : Form
    {
        public Login login;

        public Main()
        {
            InitializeComponent();
        }

        private void Compose_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            login = new Login();
            login.MdiParent = this;
            login.Show();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {

        }

        private void CheckMessage_Click(object sender, EventArgs e)
        {
            MessageList messageList = new MessageList();
            messageList.Show();
        }
    }
}
