﻿using System;
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
    public partial class Compose : Form
    {
        public Entities.User user;
        public BLL.bll BusinessLogic;

        public Compose()
        {
            InitializeComponent();
        }

        private void Compose_Load(object sender, EventArgs e)
        {

        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            Entities.User To = BusinessLogic.GetUserByName(ToTextBox.Text);
            if (To != null)
                if (BusinessLogic.AddMessage(user.Id, To.Id, SubjectTextBox.Text, BodyRichTextBox.Text))
                {
                    this.Dispose();
                }


        }
    }
}
