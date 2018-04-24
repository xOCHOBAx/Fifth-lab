namespace MyMessenger
{
    partial class MessageList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.InboxRadioButton = new System.Windows.Forms.RadioButton();
            this.SentRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(696, 133);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(38, 215);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(696, 133);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // InboxRadioButton
            // 
            this.InboxRadioButton.AutoSize = true;
            this.InboxRadioButton.Checked = true;
            this.InboxRadioButton.Location = new System.Drawing.Point(38, 11);
            this.InboxRadioButton.Name = "InboxRadioButton";
            this.InboxRadioButton.Size = new System.Drawing.Size(51, 17);
            this.InboxRadioButton.TabIndex = 2;
            this.InboxRadioButton.TabStop = true;
            this.InboxRadioButton.Text = "Inbox";
            this.InboxRadioButton.UseVisualStyleBackColor = true;
            this.InboxRadioButton.CheckedChanged += new System.EventHandler(this.InboxRadioButton_CheckedChanged);
            // 
            // SentRadioButton
            // 
            this.SentRadioButton.AutoSize = true;
            this.SentRadioButton.Location = new System.Drawing.Point(129, 11);
            this.SentRadioButton.Name = "SentRadioButton";
            this.SentRadioButton.Size = new System.Drawing.Size(47, 17);
            this.SentRadioButton.TabIndex = 2;
            this.SentRadioButton.TabStop = true;
            this.SentRadioButton.Text = "Sent";
            this.SentRadioButton.UseVisualStyleBackColor = true;
            this.SentRadioButton.CheckedChanged += new System.EventHandler(this.SentRadioButton_CheckedChanged);
            // 
            // MessageList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 372);
            this.Controls.Add(this.SentRadioButton);
            this.Controls.Add(this.InboxRadioButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MessageList";
            this.Text = "MessageList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MessageList_FormClosed);
            this.Load += new System.EventHandler(this.MessageList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton InboxRadioButton;
        private System.Windows.Forms.RadioButton SentRadioButton;
    }
}