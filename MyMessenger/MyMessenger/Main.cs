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
        public Entities.User user;
        public Login login;
        public Compose compose;
        public MessageList messageList;
        public BLL.bll BusinessLogic;

        public Main()
        {
            InitializeComponent();
            BusinessLogic = new BLL.bll();
        }

        private void Compose_Click(object sender, EventArgs e)
        {
            ShowCompose();

            Compose.Enabled = false;
            CheckMessage.Enabled = false;
            CloseMessageBox.Enabled = false;
            LogOut.Enabled = true;
        }

        public void AwaitingState()
        {
            Compose.Enabled = true;
            CheckMessage.Enabled = true;
            CloseMessageBox.Enabled = false;
            LogOut.Enabled = true;
        }


        private void ShowCompose()
        {
            compose = new Compose
            {
                MdiParent = this,
                parent = this,
                BusinessLogic = BusinessLogic,
                user = user
            };
            compose.Show();

            Compose.Enabled = false;
            CheckMessage.Enabled = false;
            CloseMessageBox.Enabled = false;
            LogOut.Enabled = true;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ShowLogin();
        }

        private void ShowLogin()
        {
            login = new Login
            {
                MdiParent = this,
                BusinessLogic = BusinessLogic,
                parent = this
            };
            login.Show();

            Compose.Enabled = false;
            CheckMessage.Enabled = false;
            CloseMessageBox.Enabled = false;
            LogOut.Enabled = false;
        }

        public void CheckMessage_Click(object sender, EventArgs e)
        {
            ShowMessageList();
        }

        public void ShowMessageList()
        {
            messageList = new MessageList
            {
                MdiParent = this,
                parent = this,
                BusinessLogic = BusinessLogic,
                user = user
            };
            messageList.Show();

            Compose.Enabled = false;
            CheckMessage.Enabled = false;
            CloseMessageBox.Enabled = true;
            LogOut.Enabled = true;
        }

        private void Main_MdiChildActivate(object sender, EventArgs e)
        {

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            user = null;
            if (ActiveMdiChild != null) ActiveMdiChild.Dispose();
            ShowLogin();
        }

        public void CloseMessageBox_Click(object sender, EventArgs e)
        {
            Compose.Enabled = true;
            CheckMessage.Enabled = true;
            CloseMessageBox.Enabled = false;
            LogOut.Enabled = true;

            messageList.Dispose();
        }
    }
}
