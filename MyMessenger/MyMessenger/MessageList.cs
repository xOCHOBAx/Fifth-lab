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
    public partial class MessageList : Form
    {
        public BLL.bll BusinessLogic;
        public Entities.User user;

        public MessageList()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MessageList_Load(object sender, EventArgs e)
        {

        }
    }
}
