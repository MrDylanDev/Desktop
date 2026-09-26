namespace app_escritorio.Forms
{
    partial class ReportesForm
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
            this.contentPanel = new System.Windows.Forms.Panel();
            this.mainLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.sidebarControl1 = new app_escritorio.Controls.SidebarControl();
                        this.topBar1 = new app_escritorio.Controls.TopBarControl();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            
            // 
            // sidebarControl1
            // 
            this.sidebarControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(22)))));
            this.sidebarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarControl1.Location = new System.Drawing.Point(0, 0);
            this.sidebarControl1.Name = "sidebarControl1";
            this.sidebarControl1.Size = new System.Drawing.Size(250, 900);
            this.sidebarControl1.TabIndex = 1;
            
            // 
            // contentPanel
            // 
            this.contentPanel.AutoScroll = true;
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(22)))));
            this.contentPanel.Controls.Add(this.mainLayout);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(250, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1300, 900);
            this.contentPanel.TabIndex = 0;
            
            // 
            // mainLayout
            // 
            this.mainLayout.AutoSize = true;
            this.mainLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.Padding = new System.Windows.Forms.Padding(30);
            this.mainLayout.Size = new System.Drawing.Size(1200, 0);
            this.mainLayout.TabIndex = 0;
            this.mainLayout.WrapContents = false;
            
            // 
            // ReportesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(1550, 900);
                        this.topBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar1.PageTitle = "Reportes · Solo Admin";
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.topBar1);
            this.Controls.Add(this.sidebarControl1);
            this.Name = "ReportesForm";
            this.Text = "Reportes";
            
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.FlowLayoutPanel mainLayout;
        private app_escritorio.Controls.SidebarControl sidebarControl1;
        private app_escritorio.Controls.TopBarControl topBar1;
    }
}
