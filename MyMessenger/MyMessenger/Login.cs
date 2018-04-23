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
    public partial class Login : Form
    {
        public Entities.User user;
        public BLL.bll BusinessLogic;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(BusinessLogic.Authorize(LoginTextBox.Text,PasswordTextBox.Text))
            {
                user = BusinessLogic.GetUserByName(LoginTextBox.Text);
                this.Dispose();
            }
        }
    }
}
