namespace app_escritorio.Shell
{
    partial class ShellTopBar
    {
        /// <summary>Variable del diseñador requerida.</summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.root = new app_escritorio.UI.RPanel();
            this.flowRight = new System.Windows.Forms.FlowLayoutPanel();
            this.badgeRole = new app_escritorio.UI.RBadge();
            this.lblApp = new app_escritorio.UI.RLabel();
            this.avatar = new app_escritorio.UI.RBadge();
            this.btnCambiarPerfil = new app_escritorio.UI.RButton();
            this.lblRoute = new app_escritorio.UI.RLabel();
            this.badgeClock = new app_escritorio.UI.RBadge();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.root.SuspendLayout();
            this.flowRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.BottomBorder = true;
            this.root.Controls.Add(this.flowRight);
            this.root.Controls.Add(this.lblRoute);
            this.root.Controls.Add(this.badgeClock);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(0, 0);
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(20, 0, 20, 1);
            this.root.Size = new System.Drawing.Size(1000, 64);
            this.root.TabIndex = 0;
            // 
            // flowRight
            // 
            this.flowRight.AutoSize = true;
            this.flowRight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowRight.Controls.Add(this.badgeRole);
            this.flowRight.Controls.Add(this.lblApp);
            this.flowRight.Controls.Add(this.avatar);
            this.flowRight.Controls.Add(this.btnCambiarPerfil);
            this.flowRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowRight.Location = new System.Drawing.Point(582, 0);
            this.flowRight.Name = "flowRight";
            this.flowRight.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.flowRight.Size = new System.Drawing.Size(398, 63);
            this.flowRight.TabIndex = 2;
            this.flowRight.WrapContents = false;
            // 
            // badgeRole
            // 
            this.badgeRole.Kind = app_escritorio.UI.BadgeKind.Accent;
            this.badgeRole.Location = new System.Drawing.Point(0, 18);
            this.badgeRole.Margin = new System.Windows.Forms.Padding(0, 3, 10, 0);
            this.badgeRole.Name = "badgeRole";
            this.badgeRole.Size = new System.Drawing.Size(104, 26);
            this.badgeRole.TabIndex = 0;
            this.badgeRole.Text = "Administrador";
            // 
            // lblApp
            // 
            this.lblApp.AutoSize = true;
            this.lblApp.Location = new System.Drawing.Point(114, 22);
            this.lblApp.Margin = new System.Windows.Forms.Padding(0, 7, 14, 0);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(54, 17);
            this.lblApp.TabIndex = 1;
            this.lblApp.Text = "RestoOS";
            this.lblApp.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // avatar
            // 
            this.avatar.CornerRadius = 16;
            this.avatar.Kind = app_escritorio.UI.BadgeKind.Primary;
            this.avatar.Location = new System.Drawing.Point(182, 15);
            this.avatar.Margin = new System.Windows.Forms.Padding(0);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(32, 32);
            this.avatar.TabIndex = 2;
            this.avatar.Text = "●";
            // 
            // btnCambiarPerfil
            // 
            this.btnCambiarPerfil.Location = new System.Drawing.Point(224, 15);
            this.btnCambiarPerfil.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCambiarPerfil.Name = "btnCambiarPerfil";
            this.btnCambiarPerfil.Size = new System.Drawing.Size(140, 32);
            this.btnCambiarPerfil.TabIndex = 3;
            this.btnCambiarPerfil.Text = "↻ Cambiar perfil";
            this.btnCambiarPerfil.Variant = app_escritorio.UI.ButtonVariant.Secondary;
            this.btnCambiarPerfil.Click += new System.EventHandler(this.BtnCambiarPerfil_Click);
            // 
            // lblRoute
            // 
            this.lblRoute.AutoSize = true;
            this.lblRoute.Location = new System.Drawing.Point(126, 22);
            this.lblRoute.Name = "lblRoute";
            this.lblRoute.Size = new System.Drawing.Size(62, 19);
            this.lblRoute.TabIndex = 1;
            this.lblRoute.Text = "Módulos";
            this.lblRoute.TextStyle = app_escritorio.UI.TextStyle.Subtle;
            // 
            // badgeClock
            // 
            this.badgeClock.CornerRadius = 8;
            this.badgeClock.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.badgeClock.Location = new System.Drawing.Point(20, 16);
            this.badgeClock.Name = "badgeClock";
            this.badgeClock.Size = new System.Drawing.Size(96, 32);
            this.badgeClock.TabIndex = 0;
            this.badgeClock.Text = "00:00:00";
            // 
            // clockTimer
            // 
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // ShellTopBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.root);
            this.Name = "ShellTopBar";
            this.Size = new System.Drawing.Size(1000, 64);
            this.root.ResumeLayout(false);
            this.root.PerformLayout();
            this.flowRight.ResumeLayout(false);
            this.flowRight.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private app_escritorio.UI.RPanel root;
        private System.Windows.Forms.FlowLayoutPanel flowRight;
        private app_escritorio.UI.RBadge badgeRole;
        private app_escritorio.UI.RLabel lblApp;
        private app_escritorio.UI.RBadge avatar;
        private app_escritorio.UI.RButton btnCambiarPerfil;
        private app_escritorio.UI.RLabel lblRoute;
        private app_escritorio.UI.RBadge badgeClock;
        private System.Windows.Forms.Timer clockTimer;
    }
}
