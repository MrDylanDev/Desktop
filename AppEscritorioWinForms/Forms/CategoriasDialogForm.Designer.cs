namespace app_escritorio.Forms
{
    partial class CategoriasDialogForm
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
            this.root = new app_escritorio.UI.RPanel();
            this.btnListo = new app_escritorio.UI.RButton();
            this.btnAgregar = new app_escritorio.UI.RButton();
            this.txtNueva = new app_escritorio.UI.RTextBox();
            this.btnQuitar = new app_escritorio.UI.RButton();
            this.btnBajar = new app_escritorio.UI.RButton();
            this.btnSubir = new app_escritorio.UI.RButton();
            this.grid = new app_escritorio.UI.RDataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlatos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSub = new app_escritorio.UI.RLabel();
            this.lblTitle = new app_escritorio.UI.RLabel();
            this.root.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.Controls.Add(this.btnListo);
            this.root.Controls.Add(this.btnAgregar);
            this.root.Controls.Add(this.txtNueva);
            this.root.Controls.Add(this.btnQuitar);
            this.root.Controls.Add(this.btnBajar);
            this.root.Controls.Add(this.btnSubir);
            this.root.Controls.Add(this.grid);
            this.root.Controls.Add(this.lblSub);
            this.root.Controls.Add(this.lblTitle);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(0, 0);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(420, 454);
            this.root.Surface = app_escritorio.UI.SurfaceLevel.Surface;
            this.root.TabIndex = 0;
            // 
            // btnListo
            // 
            this.btnListo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnListo.Location = new System.Drawing.Point(288, 394);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(110, 40);
            this.btnListo.TabIndex = 6;
            this.btnListo.Text = "Listo";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(316, 334);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(82, 40);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Variant = app_escritorio.UI.ButtonVariant.Primary;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // txtNueva
            // 
            this.txtNueva.Location = new System.Drawing.Point(22, 334);
            this.txtNueva.Name = "txtNueva";
            this.txtNueva.PlaceholderText = "Nueva categoría";
            this.txtNueva.Size = new System.Drawing.Size(286, 40);
            this.txtNueva.TabIndex = 4;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Compact = true;
            this.btnQuitar.Location = new System.Drawing.Point(328, 172);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(70, 36);
            this.btnQuitar.TabIndex = 3;
            this.btnQuitar.Text = "Eliminar";
            this.btnQuitar.Variant = app_escritorio.UI.ButtonVariant.Danger;
            this.btnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
            // 
            // btnBajar
            // 
            this.btnBajar.Compact = true;
            this.btnBajar.Location = new System.Drawing.Point(328, 130);
            this.btnBajar.Name = "btnBajar";
            this.btnBajar.Size = new System.Drawing.Size(70, 36);
            this.btnBajar.TabIndex = 2;
            this.btnBajar.Text = "▼  Bajar";
            this.btnBajar.Variant = app_escritorio.UI.ButtonVariant.Secondary;
            this.btnBajar.Click += new System.EventHandler(this.BtnBajar_Click);
            // 
            // btnSubir
            // 
            this.btnSubir.Compact = true;
            this.btnSubir.Location = new System.Drawing.Point(328, 88);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(70, 36);
            this.btnSubir.TabIndex = 1;
            this.btnSubir.Text = "▲  Subir";
            this.btnSubir.Variant = app_escritorio.UI.ButtonVariant.Secondary;
            this.btnSubir.Click += new System.EventHandler(this.BtnSubir_Click);
            // 
            // grid
            // 
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colPlatos});
            this.grid.Location = new System.Drawing.Point(22, 88);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(296, 232);
            this.grid.TabIndex = 0;
            // 
            // colNombre
            // 
            this.colNombre.FillWeight = 200F;
            this.colNombre.HeaderText = "Categoría";
            this.colNombre.Name = "colNombre";
            // 
            // colPlatos
            // 
            this.colPlatos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPlatos.HeaderText = "Platos";
            this.colPlatos.Name = "colPlatos";
            this.colPlatos.Width = 70;
            // 
            // lblSub
            // 
            this.lblSub.Location = new System.Drawing.Point(22, 58);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(376, 20);
            this.lblSub.TabIndex = 51;
            this.lblSub.Text = "Ordena, agrega o elimina las categorías de la carta.";
            this.lblSub.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(22, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(376, 36);
            this.lblTitle.TabIndex = 50;
            this.lblTitle.Text = "Categorías";
            this.lblTitle.TextStyle = app_escritorio.UI.TextStyle.Display;
            // 
            // CategoriasDialogForm
            // 
            this.AcceptButton = this.btnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnListo;
            this.ClientSize = new System.Drawing.Size(420, 454);
            this.Name = "CategoriasDialogForm";
            this.Text = "Categorías";
            this.Controls.Add(this.root);
            this.root.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private app_escritorio.UI.RPanel root;
        private app_escritorio.UI.RButton btnListo;
        private app_escritorio.UI.RButton btnAgregar;
        private app_escritorio.UI.RTextBox txtNueva;
        private app_escritorio.UI.RButton btnQuitar;
        private app_escritorio.UI.RButton btnBajar;
        private app_escritorio.UI.RButton btnSubir;
        private app_escritorio.UI.RDataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlatos;
        private app_escritorio.UI.RLabel lblSub;
        private app_escritorio.UI.RLabel lblTitle;
    }
}
