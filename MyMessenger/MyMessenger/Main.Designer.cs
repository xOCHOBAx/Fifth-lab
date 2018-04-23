namespace MyMessenger
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Compose = new System.Windows.Forms.ToolStripButton();
            this.CheckMessage = new System.Windows.Forms.ToolStripButton();
            this.CloseMessageBox = new System.Windows.Forms.ToolStripButton();
            this.LogOut = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Compose,
            this.CheckMessage,
            this.CloseMessageBox,
            this.LogOut});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(989, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Compose
            // 
            this.Compose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Compose.Image = ((System.Drawing.Image)(resources.GetObject("Compose.Image")));
            this.Compose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Compose.Name = "Compose";
            this.Compose.Size = new System.Drawing.Size(23, 22);
            this.Compose.Text = "Compose";
            this.Compose.Click += new System.EventHandler(this.Compose_Click);
            // 
            // CheckMessage
            // 
            this.CheckMessage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CheckMessage.Image = ((System.Drawing.Image)(resources.GetObject("CheckMessage.Image")));
            this.CheckMessage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CheckMessage.Name = "CheckMessage";
            this.CheckMessage.Size = new System.Drawing.Size(23, 22);
            this.CheckMessage.Text = "Check Messages";
            this.CheckMessage.Click += new System.EventHandler(this.CheckMessage_Click);
            // 
            // CloseMessageBox
            // 
            this.CloseMessageBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CloseMessageBox.Image = ((System.Drawing.Image)(resources.GetObject("CloseMessageBox.Image")));
            this.CloseMessageBox.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloseMessageBox.Name = "CloseMessageBox";
            this.CloseMessageBox.Size = new System.Drawing.Size(23, 22);
            this.CloseMessageBox.Text = "Close Message Box";
            // 
            // LogOut
            // 
            this.LogOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LogOut.Image = ((System.Drawing.Image)(resources.GetObject("LogOut.Image")));
            this.LogOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(23, 22);
            this.LogOut.Text = "Log Out";
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 576);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = "Messenger";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MdiChildActivate += new System.EventHandler(this.Main_MdiChildActivate);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Compose;
        private System.Windows.Forms.ToolStripButton CheckMessage;
        private System.Windows.Forms.ToolStripButton CloseMessageBox;
        private System.Windows.Forms.ToolStripButton LogOut;
    }
}

