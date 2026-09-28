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
            root = new app_escritorio.UI.RPanel();
            btnSave = new app_escritorio.UI.RButton();
            btnCancel = new app_escritorio.UI.RButton();
            txtCost = new app_escritorio.UI.RTextBox();
            lblCost = new app_escritorio.UI.RLabel();
            txtMin = new app_escritorio.UI.RTextBox();
            lblMin = new app_escritorio.UI.RLabel();
            txtStock = new app_escritorio.UI.RTextBox();
            lblStock = new app_escritorio.UI.RLabel();
            cmbUnit = new app_escritorio.UI.RComboBox();
            lblUnit = new app_escritorio.UI.RLabel();
            cmbCategory = new app_escritorio.UI.RComboBox();
            lblCategory = new app_escritorio.UI.RLabel();
            txtName = new app_escritorio.UI.RTextBox();
            lblName = new app_escritorio.UI.RLabel();
            lblTitle = new app_escritorio.UI.RLabel();
            root.SuspendLayout();
            SuspendLayout();
            // 
            // root
            // 
            root.Controls.Add(btnSave);
            root.Controls.Add(btnCancel);
            root.Controls.Add(txtCost);
            root.Controls.Add(lblCost);
            root.Controls.Add(txtMin);
            root.Controls.Add(lblMin);
            root.Controls.Add(txtStock);
            root.Controls.Add(lblStock);
            root.Controls.Add(cmbUnit);
            root.Controls.Add(lblUnit);
            root.Controls.Add(cmbCategory);
            root.Controls.Add(lblCategory);
            root.Controls.Add(txtName);
            root.Controls.Add(lblName);
            root.Controls.Add(lblTitle);
            root.Dock = DockStyle.Fill;
            root.Location = new Point(0, 0);
            root.Name = "root";
            root.Size = new Size(444, 436);
            root.Surface = UI.SurfaceLevel.Surface;
            root.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnSave.Location = new Point(312, 378);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 40);
            btnSave.TabIndex = 6;
            btnSave.Text = "Guardar";
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Font = new Font("Segoe UI", 9.75F);
            btnCancel.Location = new Point(192, 378);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 40);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancelar";
            btnCancel.Variant = UI.ButtonVariant.Secondary;
            // 
            // txtCost
            // 
            txtCost.Location = new Point(22, 318);
            txtCost.Name = "txtCost";
            txtCost.Padding = new Padding(10, 8, 10, 8);
            txtCost.PlaceholderText = "0";
            txtCost.Size = new Size(400, 40);
            txtCost.TabIndex = 5;
            // 
            // lblCost
            // 
            lblCost.Location = new Point(22, 296);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(400, 20);
            lblCost.TabIndex = 65;
            lblCost.Text = "Costo unitario ($)";
            lblCost.TextStyle = UI.TextStyle.Muted;
            // 
            // txtMin
            // 
            txtMin.Location = new Point(228, 242);
            txtMin.Name = "txtMin";
            txtMin.Padding = new Padding(10, 8, 10, 8);
            txtMin.PlaceholderText = "0";
            txtMin.Size = new Size(194, 40);
            txtMin.TabIndex = 4;
            // 
            // lblMin
            // 
            lblMin.Location = new Point(228, 220);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(194, 20);
            lblMin.TabIndex = 64;
            lblMin.Text = "Stock mínimo";
            lblMin.TextStyle = UI.TextStyle.Muted;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(22, 242);
            txtStock.Name = "txtStock";
            txtStock.Padding = new Padding(10, 8, 10, 8);
            txtStock.PlaceholderText = "0";
            txtStock.Size = new Size(194, 40);
            txtStock.TabIndex = 3;
            // 
            // lblStock
            // 
            lblStock.Location = new Point(22, 220);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(194, 20);
            lblStock.TabIndex = 63;
            lblStock.Text = "Stock actual";
            lblStock.TextStyle = UI.TextStyle.Muted;
            // 
            // cmbUnit
            // 
            cmbUnit.DropDownStyle = ComboBoxStyle.DropDown;
            cmbUnit.Items.AddRange(new object[] { "kg", "g", "L", "und" });
            cmbUnit.Location = new Point(228, 174);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(194, 32);
            cmbUnit.TabIndex = 2;
            // 
            // lblUnit
            // 
            lblUnit.Location = new Point(228, 152);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(194, 20);
            lblUnit.TabIndex = 62;
            lblUnit.Text = "Unidad";
            lblUnit.TextStyle = UI.TextStyle.Muted;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDown;
            cmbCategory.Items.AddRange(new object[] { "Carnes", "Verduras", "Lácteos", "Bebidas", "Secos" });
            cmbCategory.Location = new Point(22, 174);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(194, 32);
            cmbCategory.TabIndex = 1;
            // 
            // lblCategory
            // 
            lblCategory.Location = new Point(22, 152);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(194, 20);
            lblCategory.TabIndex = 61;
            lblCategory.Text = "Categoría";
            lblCategory.TextStyle = UI.TextStyle.Muted;
            // 
            // txtName
            // 
            txtName.Location = new Point(22, 98);
            txtName.Name = "txtName";
            txtName.Padding = new Padding(10, 8, 10, 8);
            txtName.PlaceholderText = "Ej: Queso mozzarella";
            txtName.Size = new Size(400, 40);
            txtName.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.Location = new Point(22, 76);
            lblName.Name = "lblName";
            lblName.Size = new Size(400, 20);
            lblName.TabIndex = 60;
            lblName.Text = "Nombre *";
            lblName.TextStyle = UI.TextStyle.Muted;
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(22, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 36);
            lblTitle.TabIndex = 50;
            lblTitle.Text = "Nuevo insumo";
            lblTitle.TextStyle = UI.TextStyle.Display;
            // 
            // InsumoDialogForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(444, 436);
            Controls.Add(root);
            Name = "InsumoDialogForm";
            Text = "Nuevo insumo";
            root.ResumeLayout(false);
            ResumeLayout(false);
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
