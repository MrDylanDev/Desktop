namespace app_escritorio.Shell
{
    partial class ShellForm
    {
        /// <summary>Variable del diseñador requerida.</summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.contentHost = new app_escritorio.UI.RPanel();
            this.topBar = new app_escritorio.Shell.ShellTopBar();
            this.sidebar = new app_escritorio.Shell.ShellSidebar();
            this.SuspendLayout();
            // 
            // contentHost
            // 
            this.contentHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentHost.Location = new System.Drawing.Point(272, 64);
            this.contentHost.Name = "contentHost";
            this.contentHost.Size = new System.Drawing.Size(1152, 797);
            this.contentHost.Surface = app_escritorio.UI.SurfaceLevel.Surface;
            this.contentHost.TabIndex = 2;
            // 
            // topBar
            // 
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(272, 0);
            this.topBar.Name = "topBar";
            this.topBar.RoleText = "Administrador";
            this.topBar.RouteText = "Módulos";
            this.topBar.Size = new System.Drawing.Size(1152, 64);
            this.topBar.TabIndex = 1;
            this.topBar.CambiarPerfilClicked += new System.EventHandler(this.TopBar_CambiarPerfilClicked);
            // 
            // sidebar
            // 
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(272, 861);
            this.sidebar.TabIndex = 0;
            this.sidebar.NavigateRequested += new app_escritorio.Shell.NavigateEventHandler(this.Sidebar_NavigateRequested);
            // 
            // ShellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.contentHost);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.sidebar);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "ShellForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RestoOS - Modular Core";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
        }

        #endregion

        private app_escritorio.UI.RPanel contentHost;
        private app_escritorio.Shell.ShellTopBar topBar;
        private app_escritorio.Shell.ShellSidebar sidebar;
    }
}
