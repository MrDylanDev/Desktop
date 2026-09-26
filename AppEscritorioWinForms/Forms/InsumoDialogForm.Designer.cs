namespace app_escritorio.Forms
{
    partial class InsumoDialogForm
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
            this.txtCost = new app_escritorio.UI.RTextBox();
            this.lblCost = new app_escritorio.UI.RLabel();
            this.txtMin = new app_escritorio.UI.RTextBox();
            this.lblMin = new app_escritorio.UI.RLabel();
            this.txtStock = new app_escritorio.UI.RTextBox();
            this.lblStock = new app_escritorio.UI.RLabel();
            this.cmbUnit = new app_escritorio.UI.RComboBox();
            this.lblUnit = new app_escritorio.UI.RLabel();
            this.cmbCategory = new app_escritorio.UI.RComboBox();
            this.lblCategory = new app_escritorio.UI.RLabel();
            this.txtName = new app_escritorio.UI.RTextBox();
            this.lblName = new app_escritorio.UI.RLabel();
            this.lblTitle = new app_escritorio.UI.RLabel();
            this.root.SuspendLayout();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.Controls.Add(this.btnSave);
            this.root.Controls.Add(this.btnCancel);
            this.root.Controls.Add(this.txtCost);
            this.root.Controls.Add(this.lblCost);
            this.root.Controls.Add(this.txtMin);
            this.root.Controls.Add(this.lblMin);
            this.root.Controls.Add(this.txtStock);
            this.root.Controls.Add(this.lblStock);
            this.root.Controls.Add(this.cmbUnit);
            this.root.Controls.Add(this.lblUnit);
            this.root.Controls.Add(this.cmbCategory);
            this.root.Controls.Add(this.lblCategory);
            this.root.Controls.Add(this.txtName);
            this.root.Controls.Add(this.lblName);
            this.root.Controls.Add(this.lblTitle);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(0, 0);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(444, 436);
            this.root.Surface = app_escritorio.UI.SurfaceLevel.Surface;
            this.root.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(312, 378);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Guardar";
            this.btnSave.Variant = app_escritorio.UI.ButtonVariant.Primary;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(192, 378);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 40);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Variant = app_escritorio.UI.ButtonVariant.Secondary;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(22, 318);
            this.txtCost.Name = "txtCost";
            this.txtCost.PlaceholderText = "0";
            this.txtCost.Size = new System.Drawing.Size(400, 40);
            this.txtCost.TabIndex = 5;
            // 
            // lblCost
            // 
            this.lblCost.Location = new System.Drawing.Point(22, 296);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(400, 20);
            this.lblCost.TabIndex = 65;
            this.lblCost.Text = "Costo unitario ($)";
            this.lblCost.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(228, 242);
            this.txtMin.Name = "txtMin";
            this.txtMin.PlaceholderText = "0";
            this.txtMin.Size = new System.Drawing.Size(194, 40);
            this.txtMin.TabIndex = 4;
            // 
            // lblMin
            // 
            this.lblMin.Location = new System.Drawing.Point(228, 220);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(194, 20);
            this.lblMin.TabIndex = 64;
            this.lblMin.Text = "Stock mínimo";
            this.lblMin.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(22, 242);
            this.txtStock.Name = "txtStock";
            this.txtStock.PlaceholderText = "0";
            this.txtStock.Size = new System.Drawing.Size(194, 40);
            this.txtStock.TabIndex = 3;
            // 
            // lblStock
            // 
            this.lblStock.Location = new System.Drawing.Point(22, 220);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(194, 20);
            this.lblStock.TabIndex = 63;
            this.lblStock.Text = "Stock actual";
            this.lblStock.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // cmbUnit
            // 
            this.cmbUnit.Items.AddRange(new object[] {
            "kg",
            "g",
            "L",
            "und"});
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbUnit.Location = new System.Drawing.Point(228, 174);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(194, 32);
            this.cmbUnit.TabIndex = 2;
            // 
            // lblUnit
            // 
            this.lblUnit.Location = new System.Drawing.Point(228, 152);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(194, 20);
            this.lblUnit.TabIndex = 62;
            this.lblUnit.Text = "Unidad";
            this.lblUnit.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Items.AddRange(new object[] {
            "Carnes",
            "Verduras",
            "Lácteos",
            "Bebidas",
            "Secos"});
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbCategory.Location = new System.Drawing.Point(22, 174);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(194, 32);
            this.cmbCategory.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.Location = new System.Drawing.Point(22, 152);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(194, 20);
            this.lblCategory.TabIndex = 61;
            this.lblCategory.Text = "Categoría";
            this.lblCategory.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(22, 98);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Ej: Queso mozzarella";
            this.txtName.Size = new System.Drawing.Size(400, 40);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(22, 76);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(400, 20);
            this.lblName.TabIndex = 60;
            this.lblName.Text = "Nombre *";
            this.lblName.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(22, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 36);
            this.lblTitle.TabIndex = 50;
            this.lblTitle.Text = "Nuevo insumo";
            this.lblTitle.TextStyle = app_escritorio.UI.TextStyle.Display;
            // 
            // InsumoDialogForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(444, 436);
            this.Name = "InsumoDialogForm";
            this.Text = "Nuevo insumo";
            this.Controls.Add(this.root);
            this.root.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private app_escritorio.UI.RPanel root;
        private app_escritorio.UI.RButton btnSave;
        private app_escritorio.UI.RButton btnCancel;
        private app_escritorio.UI.RTextBox txtCost;
        private app_escritorio.UI.RLabel lblCost;
        private app_escritorio.UI.RTextBox txtMin;
        private app_escritorio.UI.RLabel lblMin;
        private app_escritorio.UI.RTextBox txtStock;
        private app_escritorio.UI.RLabel lblStock;
        private app_escritorio.UI.RComboBox cmbUnit;
        private app_escritorio.UI.RLabel lblUnit;
        private app_escritorio.UI.RComboBox cmbCategory;
        private app_escritorio.UI.RLabel lblCategory;
        private app_escritorio.UI.RTextBox txtName;
        private app_escritorio.UI.RLabel lblName;
        private app_escritorio.UI.RLabel lblTitle;
    }
}
