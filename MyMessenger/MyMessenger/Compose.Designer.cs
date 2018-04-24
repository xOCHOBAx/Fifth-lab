namespace MyMessenger
{
    partial class Compose
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
            this.ToTextBox = new System.Windows.Forms.TextBox();
            this.SubjectTextBox = new System.Windows.Forms.TextBox();
            this.BodyRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ToLabel = new System.Windows.Forms.Label();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ToTextBox
            // 
            this.ToTextBox.Location = new System.Drawing.Point(129, 73);
            this.ToTextBox.Name = "ToTextBox";
            this.ToTextBox.Size = new System.Drawing.Size(446, 20);
            this.ToTextBox.TabIndex = 0;
            // 
            // SubjectTextBox
            // 
            this.SubjectTextBox.Location = new System.Drawing.Point(129, 109);
            this.SubjectTextBox.Name = "SubjectTextBox";
            this.SubjectTextBox.Size = new System.Drawing.Size(446, 20);
            this.SubjectTextBox.TabIndex = 1;
            // 
            // BodyRichTextBox
            // 
            this.BodyRichTextBox.Location = new System.Drawing.Point(41, 164);
            this.BodyRichTextBox.Name = "BodyRichTextBox";
            this.BodyRichTextBox.Size = new System.Drawing.Size(572, 166);
            this.BodyRichTextBox.TabIndex = 2;
            this.BodyRichTextBox.Text = "";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(79, 73);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(20, 13);
            this.ToLabel.TabIndex = 2;
            this.ToLabel.Text = "To";
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Location = new System.Drawing.Point(56, 109);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(43, 13);
            this.SubjectLabel.TabIndex = 2;
            this.SubjectLabel.Text = "Subject";
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(204, 337);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 4;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(355, 337);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Compose
            // 
            this.AcceptButton = this.SendButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelButton;
            this.ClientSize = new System.Drawing.Size(675, 385);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.BodyRichTextBox);
            this.Controls.Add(this.SubjectTextBox);
            this.Controls.Add(this.ToTextBox);
            this.Name = "Compose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Compose";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Compose_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Compose_FormClosed);
            this.Load += new System.EventHandler(this.Compose_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ToTextBox;
        private System.Windows.Forms.TextBox SubjectTextBox;
        private System.Windows.Forms.RichTextBox BodyRichTextBox;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button CancelButton;
    }
}