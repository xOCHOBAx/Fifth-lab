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
            dataGridView1.DataSource = BusinessLogic.GetMessagesFromById(user.Id);
            dataGridView1.Columns["Body"].Visible = false;
            dataGridView1.Columns["MsgTo"].Visible = false;
            dataGridView1.Columns["MsgFrom"].Visible = false;
            dataGridView1.Columns["MsgToName"].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = dataGridView1.CurrentRow.Cells["Body"].Value.ToString();
            //richTextBox1.Text = dataGridView1.CurrentRow.Cells["Body"].Value.ToString();
        }

        private void InboxRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BusinessLogic.GetMessagesFromById(user.Id);
            dataGridView1.Columns["MsgFromName"].Visible = true;
            dataGridView1.Columns["MsgToName"].Visible = false;

        }

        private void SentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BusinessLogic.GetMessagesToById(user.Id);
            dataGridView1.Columns["MsgToName"].Visible = true;
            dataGridView1.Columns["MsgFromName"].Visible = false;

        }
    }
}
