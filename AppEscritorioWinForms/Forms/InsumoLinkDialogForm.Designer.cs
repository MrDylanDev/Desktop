namespace app_escritorio.Forms
{
    partial class InsumoLinkDialogForm
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
            this.btnSave = new app_escritorio.UI.RButton();
            this.btnCancel = new app_escritorio.UI.RButton();
            this.cmbUnidad = new app_escritorio.UI.RComboBox();
            this.lblUnidad = new app_escritorio.UI.RLabel();
            this.txtCantidad = new app_escritorio.UI.RTextBox();
            this.lblCantidad = new app_escritorio.UI.RLabel();
            this.cmbInsumo = new app_escritorio.UI.RComboBox();
            this.lblInsumo = new app_escritorio.UI.RLabel();
            this.lblTitle = new app_escritorio.UI.RLabel();
            this.root.SuspendLayout();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.Controls.Add(this.btnSave);
            this.root.Controls.Add(this.btnCancel);
            this.root.Controls.Add(this.cmbUnidad);
            this.root.Controls.Add(this.lblUnidad);
            this.root.Controls.Add(this.txtCantidad);
            this.root.Controls.Add(this.lblCantidad);
            this.root.Controls.Add(this.cmbInsumo);
            this.root.Controls.Add(this.lblInsumo);
            this.root.Controls.Add(this.lblTitle);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(0, 0);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(444, 284);
            this.root.Surface = app_escritorio.UI.SurfaceLevel.Surface;
            this.root.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(312, 226);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 40);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Vincular";
            this.btnSave.Variant = app_escritorio.UI.ButtonVariant.Primary;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(192, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 40);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Variant = app_escritorio.UI.ButtonVariant.Secondary;
            // 
            // cmbUnidad
            // 
            this.cmbUnidad.Items.AddRange(new object[] {
            "kg",
            "g",
            "L",
            "ml",
            "und"});
            this.cmbUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbUnidad.Location = new System.Drawing.Point(228, 166);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(194, 32);
            this.cmbUnidad.TabIndex = 2;
            // 
            // lblUnidad
            // 
            this.lblUnidad.Location = new System.Drawing.Point(228, 144);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(194, 20);
            this.lblUnidad.TabIndex = 62;
            this.lblUnidad.Text = "Unidad";
            this.lblUnidad.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(22, 166);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PlaceholderText = "0,25";
            this.txtCantidad.Size = new System.Drawing.Size(194, 40);
            this.txtCantidad.TabIndex = 1;
            // 
            // lblCantidad
            // 
            this.lblCantidad.Location = new System.Drawing.Point(22, 144);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(194, 20);
            this.lblCantidad.TabIndex = 61;
            this.lblCantidad.Text = "Cantidad por plato *";
            this.lblCantidad.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // cmbInsumo
            // 
            this.cmbInsumo.Items.AddRange(new object[] {
            "Carne de res (lomo)",
            "Queso mozzarella",
            "Tomate chonto",
            "Cerveza artesanal",
            "Harina trigo",
            "Lechuga crespa",
            "Pollo entero",
            "Aceite vegetal",
            "Papa criolla",
            "Salmón fresco",
            "Limón",
            "Pan brioche"});
            this.cmbInsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbInsumo.Location = new System.Drawing.Point(22, 98);
            this.cmbInsumo.Name = "cmbInsumo";
            this.cmbInsumo.Size = new System.Drawing.Size(400, 32);
            this.cmbInsumo.TabIndex = 0;
            // 
            // lblInsumo
            // 
            this.lblInsumo.Location = new System.Drawing.Point(22, 76);
            this.lblInsumo.Name = "lblInsumo";
            this.lblInsumo.Size = new System.Drawing.Size(400, 20);
            this.lblInsumo.TabIndex = 60;
            this.lblInsumo.Text = "Insumo del almacén *";
            this.lblInsumo.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(22, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 36);
            this.lblTitle.TabIndex = 50;
            this.lblTitle.Text = "Vincular insumo";
            this.lblTitle.TextStyle = app_escritorio.UI.TextStyle.Display;
            // 
            // InsumoLinkDialogForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(444, 284);
            this.Name = "InsumoLinkDialogForm";
            this.Text = "Vincular insumo";
            this.Controls.Add(this.root);
            this.root.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private app_escritorio.UI.RPanel root;
        private app_escritorio.UI.RButton btnSave;
        private app_escritorio.UI.RButton btnCancel;
        private app_escritorio.UI.RComboBox cmbUnidad;
        private app_escritorio.UI.RLabel lblUnidad;
        private app_escritorio.UI.RTextBox txtCantidad;
        private app_escritorio.UI.RLabel lblCantidad;
        private app_escritorio.UI.RComboBox cmbInsumo;
        private app_escritorio.UI.RLabel lblInsumo;
        private app_escritorio.UI.RLabel lblTitle;
    }
}
