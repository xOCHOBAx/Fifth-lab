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
            compose = new Compose();
            compose.MdiParent = this;
            compose.BusinessLogic = BusinessLogic;
            compose.user = user;
            compose.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            login = new Login();
            login.MdiParent = this;
            login.BusinessLogic = BusinessLogic;
            login.Show();
        }

        private void CheckMessage_Click(object sender, EventArgs e)
        {
            messageList = new MessageList();
            messageList.MdiParent = this;
            messageList.BusinessLogic = BusinessLogic;
            messageList.user = user;
            messageList.Show();
        }

        private void Main_MdiChildActivate(object sender, EventArgs e)
        {
            user = login.user;
        }
    }
}
