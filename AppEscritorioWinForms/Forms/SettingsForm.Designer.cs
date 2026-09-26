namespace app_escritorio.Forms
{
    partial class SettingsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.sidebarControl1 = new app_escritorio.Controls.SidebarControl();
            this.topBar1 = new app_escritorio.Controls.TopBarControl();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // sidebarControl1
            // 
            this.sidebarControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.sidebarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarControl1.Location = new System.Drawing.Point(0, 0);
            this.sidebarControl1.Name = "sidebarControl1";
            this.sidebarControl1.Size = new System.Drawing.Size(250, 900);
            this.sidebarControl1.TabIndex = 0;
            // 
            // contentPanel
            // 
            this.contentPanel.AutoScroll = true;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(250, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1300, 900);
            this.contentPanel.TabIndex = 1;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(1550, 900);
                        this.topBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar1.PageTitle = "Configuración · Solo Admin";
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.topBar1);
            this.Controls.Add(this.sidebarControl1);
            this.Name = "SettingsForm";
            this.Text = "Configuración";
            this.ResumeLayout(false);

        }

        private app_escritorio.Controls.SidebarControl sidebarControl1;
        private app_escritorio.Controls.TopBarControl topBar1;
        private System.Windows.Forms.Panel contentPanel;
    }
}
