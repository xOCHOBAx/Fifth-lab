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
        public MessageList()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MessageList_Load(object sender, EventArgs e)
        {
            DAL.DataAccesLayer dal = new DAL.DataAccesLayer();
            List<Entities.Message> messages = new List<Entities.Message>();
            messages = dal.GetMessagesFromById(1);
            dataGridView1.DataSource = messages;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            
        }
    }
}
