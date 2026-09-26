namespace app_escritorio.Forms
{
    partial class ModulesForm
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
            this.contentPanel = new System.Windows.Forms.Panel();
            this.lblBreadcrumb = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.flowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFuturos = new System.Windows.Forms.Label();
            this.flowFuturos = new System.Windows.Forms.FlowLayoutPanel();
                        this.topBar1 = new app_escritorio.Controls.TopBarControl();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarControl1
            // 
            this.sidebarControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
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
            this.contentPanel.Controls.Add(this.flowFuturos);
            this.contentPanel.Controls.Add(this.lblFuturos);
            this.contentPanel.Controls.Add(this.flowLayout);
            this.contentPanel.Controls.Add(this.lblSubtitle);
            this.contentPanel.Controls.Add(this.lblTitle);
            this.contentPanel.Controls.Add(this.lblBreadcrumb);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(250, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1300, 900);
            this.contentPanel.TabIndex = 2;
            // 
            // lblBreadcrumb
            // 
            this.lblBreadcrumb.AutoSize = true;
            this.lblBreadcrumb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBreadcrumb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(146)))), ((int)(((byte)(0)))));
            this.lblBreadcrumb.Location = new System.Drawing.Point(40, 20);
            this.lblBreadcrumb.Name = "lblBreadcrumb";
            this.lblBreadcrumb.Size = new System.Drawing.Size(70, 21);
            this.lblBreadcrumb.TabIndex = 0;
            this.lblBreadcrumb.Text = "Módulos";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(36, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(235, 47);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Escalabilidad";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitle.Location = new System.Drawing.Point(40, 100);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(564, 20);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Activa solo lo que tu restaurante necesita hoy. Los módulos no disponibles se muestran como próximos pasos.";
            // 
            // flowLayout
            // 
            this.flowLayout.AutoSize = true;
            this.flowLayout.Location = new System.Drawing.Point(40, 140);
            this.flowLayout.MaximumSize = new System.Drawing.Size(1040, 0);
            this.flowLayout.MinimumSize = new System.Drawing.Size(1040, 100);
            this.flowLayout.Name = "flowLayout";
            this.flowLayout.Size = new System.Drawing.Size(1040, 500);
            this.flowLayout.TabIndex = 3;
            // 
            // lblFuturos
            // 
            this.lblFuturos.AutoSize = true;
            this.lblFuturos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFuturos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(146)))), ((int)(((byte)(0)))));
            this.lblFuturos.Location = new System.Drawing.Point(40, 660);
            this.lblFuturos.Name = "lblFuturos";
            this.lblFuturos.Size = new System.Drawing.Size(130, 21);
            this.lblFuturos.TabIndex = 4;
            this.lblFuturos.Text = "Módulos futuros";
            // 
            // flowFuturos
            // 
            this.flowFuturos.AutoSize = true;
            this.flowFuturos.Location = new System.Drawing.Point(40, 690);
            this.flowFuturos.Name = "flowFuturos";
            this.flowFuturos.Size = new System.Drawing.Size(980, 150);
            this.flowFuturos.TabIndex = 5;
            // 
            // ModulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(1550, 900);
                        this.topBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar1.PageTitle = "Módulos";
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.topBar1);
            this.Controls.Add(this.sidebarControl1);
            this.Name = "ModulesForm";
            this.Text = "Módulos";
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private app_escritorio.Controls.SidebarControl sidebarControl1;
        private app_escritorio.Controls.TopBarControl topBar1;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label lblBreadcrumb;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayout;
        private System.Windows.Forms.Label lblFuturos;
        private System.Windows.Forms.FlowLayoutPanel flowFuturos;
    }
}
