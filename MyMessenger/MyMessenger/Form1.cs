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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dal = new DAL.DataAccesLayer();
            label1.Text = dal.AddUser("admin1488", "admin", "admin").ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dal = new DAL.DataAccesLayer();
            label1.Text = dal.AddMessage(1,2,"tema","text", DateTime.Now).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var dal = new DAL.DataAccesLayer();
            label3.Text = dal.GetMessage(16).Body;
            var list = new List<Entities.Message>();
            dal = new DAL.DataAccesLayer();
            list.Add(dal.GetMessage(16));
            dataGridView1.DataSource = list;
        }
    }
}
