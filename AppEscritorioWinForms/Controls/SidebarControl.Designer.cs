namespace app_escritorio.Controls
{
    partial class SidebarControl
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
            this.SuspendLayout();
            // 
            // SidebarControl
            // 
            this.Name = "SidebarControl";
            this.Size = new System.Drawing.Size(250, 720);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnModulos;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Button btnDelivery;
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnKds;
        private System.Windows.Forms.Button btnPos;
        private System.Windows.Forms.Button btnMesas;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblSidebarTitle;
    }
}