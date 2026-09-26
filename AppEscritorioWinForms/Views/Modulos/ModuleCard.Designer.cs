namespace app_escritorio.Views.Modulos
{
    partial class ModuleCard
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
            this.lblGlyph = new app_escritorio.UI.RLabel();
            this.lblTitle = new app_escritorio.UI.RLabel();
            this.lblDescription = new app_escritorio.UI.RLabel();
            this.swActive = new app_escritorio.UI.RSwitch();
            this.lblStatus = new app_escritorio.UI.RLabel();
            this.lblCore = new app_escritorio.UI.RLabel();
            this.SuspendLayout();
            // 
            // lblGlyph
            // 
            this.lblGlyph.ColorOverride = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(157)))));
            this.lblGlyph.Location = new System.Drawing.Point(20, 14);
            this.lblGlyph.Name = "lblGlyph";
            this.lblGlyph.Size = new System.Drawing.Size(80, 44);
            this.lblGlyph.TabIndex = 0;
            this.lblGlyph.Text = "▣";
            this.lblGlyph.TextStyle = app_escritorio.UI.TextStyle.Number;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 62);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(320, 30);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Punto de Venta Esencial (POS)";
            this.lblTitle.TextStyle = app_escritorio.UI.TextStyle.Heading;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(20, 96);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(320, 56);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Cobro, pedido, efectivo y tarjeta como método de registro.";
            this.lblDescription.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // swActive
            // 
            this.swActive.Checked = true;
            this.swActive.Location = new System.Drawing.Point(20, 160);
            this.swActive.Name = "swActive";
            this.swActive.Size = new System.Drawing.Size(220, 26);
            this.swActive.TabIndex = 3;
            this.swActive.Text = "Módulo activado";
            this.swActive.CheckedChanged += new System.EventHandler(this.SwActive_CheckedChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.ColorOverride = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(222)))), ((int)(((byte)(163)))));
            this.lblStatus.Location = new System.Drawing.Point(20, 194);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(320, 22);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Módulo activo";
            this.lblStatus.TextStyle = app_escritorio.UI.TextStyle.BodyBold;
            // 
            // lblCore
            // 
            this.lblCore.ColorOverride = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(222)))), ((int)(((byte)(163)))));
            this.lblCore.Location = new System.Drawing.Point(20, 164);
            this.lblCore.Name = "lblCore";
            this.lblCore.Size = new System.Drawing.Size(320, 22);
            this.lblCore.TabIndex = 5;
            this.lblCore.Text = "Núcleo del sistema · Activo";
            this.lblCore.TextStyle = app_escritorio.UI.TextStyle.BodyBold;
            this.lblCore.Visible = false;
            // 
            // ModuleCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CornerRadius = 14;
            this.HoverSurface = app_escritorio.UI.SurfaceLevel.Container;
            this.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            this.Name = "ModuleCard";
            this.Size = new System.Drawing.Size(360, 232);
            this.Surface = app_escritorio.UI.SurfaceLevel.Container;
            this.Controls.Add(this.lblGlyph);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.swActive);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCore);
            this.ResumeLayout(false);
        }

        #endregion

        private app_escritorio.UI.RLabel lblGlyph;
        private app_escritorio.UI.RLabel lblTitle;
        private app_escritorio.UI.RLabel lblDescription;
        private app_escritorio.UI.RSwitch swActive;
        private app_escritorio.UI.RLabel lblStatus;
        private app_escritorio.UI.RLabel lblCore;
    }
}
