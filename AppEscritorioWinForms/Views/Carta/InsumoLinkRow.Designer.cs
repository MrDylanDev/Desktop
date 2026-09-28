namespace app_escritorio.Views.Carta
{
    partial class InsumoLinkRow
    {
        /// <summary>Variable del diseñador requerida.</summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador

        private void InitializeComponent()
        {
            this.lblNombre = new app_escritorio.UI.RLabel();
            this.chipCantidad = new app_escritorio.UI.RChip();
            this.btnQuitar = new app_escritorio.UI.RButton();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.lblNombre.AutoEllipsis = true;
            this.lblNombre.Location = new System.Drawing.Point(10, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(196, 34);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Ojo de bife madurado";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNombre.TextStyle = app_escritorio.UI.TextStyle.Body;
            // 
            // chipCantidad
            // 
            this.chipCantidad.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(171)))));
            this.chipCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.chipCantidad.ChipStyle = app_escritorio.UI.ChipStyle.Soft;
            this.chipCantidad.Location = new System.Drawing.Point(210, 6);
            this.chipCantidad.Name = "chipCantidad";
            this.chipCantidad.Size = new System.Drawing.Size(90, 22);
            this.chipCantidad.Small = true;
            this.chipCantidad.TabIndex = 1;
            this.chipCantidad.Text = "-0,4 kg";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnQuitar.Compact = true;
            this.btnQuitar.Location = new System.Drawing.Point(290, 4);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(26, 26);
            this.btnQuitar.TabIndex = 2;
            this.btnQuitar.Text = "×";
            this.btnQuitar.Variant = app_escritorio.UI.ButtonVariant.Icon;
            this.btnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
            // 
            // InsumoLinkRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CornerRadius = 8;
            this.HoverSurface = app_escritorio.UI.SurfaceLevel.Highest;
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.Name = "InsumoLinkRow";
            this.Size = new System.Drawing.Size(320, 34);
            this.Surface = app_escritorio.UI.SurfaceLevel.Highest;
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.chipCantidad);
            this.Controls.Add(this.btnQuitar);
            this.ResumeLayout(false);
        }

        #endregion

        private app_escritorio.UI.RLabel lblNombre;
        private app_escritorio.UI.RChip chipCantidad;
        private app_escritorio.UI.RButton btnQuitar;
    }
}
