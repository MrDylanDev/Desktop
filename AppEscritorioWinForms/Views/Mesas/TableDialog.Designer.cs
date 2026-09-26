namespace app_escritorio.Views.Mesas
{
    partial class TableDialog
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
            this.root = new app_escritorio.UI.RPanel();
            this.lblTitle = new app_escritorio.UI.RLabel();
            this.lblName = new app_escritorio.UI.RLabel();
            this.txtName = new app_escritorio.UI.RTextBox();
            this.lblSector = new app_escritorio.UI.RLabel();
            this.cmbSector = new app_escritorio.UI.RComboBox();
            this.lblCapacity = new app_escritorio.UI.RLabel();
            this.cmbCapacity = new app_escritorio.UI.RComboBox();
            this.lblStatus = new app_escritorio.UI.RLabel();
            this.cmbStatus = new app_escritorio.UI.RComboBox();
            this.btnCancel = new app_escritorio.UI.RButton();
            this.btnSave = new app_escritorio.UI.RButton();
            this.root.SuspendLayout();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.Controls.Add(this.btnSave);
            this.root.Controls.Add(this.btnCancel);
            this.root.Controls.Add(this.cmbStatus);
            this.root.Controls.Add(this.lblStatus);
            this.root.Controls.Add(this.cmbCapacity);
            this.root.Controls.Add(this.lblCapacity);
            this.root.Controls.Add(this.cmbSector);
            this.root.Controls.Add(this.lblSector);
            this.root.Controls.Add(this.txtName);
            this.root.Controls.Add(this.lblName);
            this.root.Controls.Add(this.lblTitle);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(0, 0);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(444, 432);
            this.root.Surface = app_escritorio.UI.SurfaceLevel.Surface;
            this.root.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(22, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 36);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Nueva mesa";
            this.lblTitle.TextStyle = app_escritorio.UI.TextStyle.Display;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(22, 76);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(400, 20);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Nombre *";
            this.lblName.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(22, 98);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Ej: Mesa 12, Terraza 3...";
            this.txtName.Size = new System.Drawing.Size(400, 40);
            this.txtName.TabIndex = 0;
            // 
            // lblSector
            // 
            this.lblSector.Location = new System.Drawing.Point(22, 152);
            this.lblSector.Name = "lblSector";
            this.lblSector.Size = new System.Drawing.Size(400, 20);
            this.lblSector.TabIndex = 22;
            this.lblSector.Text = "Salón";
            this.lblSector.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // cmbSector
            // 
            this.cmbSector.Items.AddRange(new object[] {
            "Principal",
            "Terraza",
            "Barra",
            "VIP"});
            this.cmbSector.Location = new System.Drawing.Point(22, 174);
            this.cmbSector.Name = "cmbSector";
            this.cmbSector.Size = new System.Drawing.Size(400, 32);
            this.cmbSector.TabIndex = 1;
            // 
            // lblCapacity
            // 
            this.lblCapacity.Location = new System.Drawing.Point(22, 220);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(400, 20);
            this.lblCapacity.TabIndex = 23;
            this.lblCapacity.Text = "Capacidad";
            this.lblCapacity.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // cmbCapacity
            // 
            this.cmbCapacity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbCapacity.Items.AddRange(new object[] {
            "2 personas",
            "4 personas",
            "6 personas",
            "8 personas",
            "10 personas"});
            this.cmbCapacity.Location = new System.Drawing.Point(22, 242);
            this.cmbCapacity.Name = "cmbCapacity";
            this.cmbCapacity.Size = new System.Drawing.Size(400, 32);
            this.cmbCapacity.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(22, 288);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(400, 20);
            this.lblStatus.TabIndex = 24;
            this.lblStatus.Text = "Estado inicial";
            this.lblStatus.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Items.AddRange(new object[] {
            "Libre",
            "Ocupada",
            "Cuenta pedida",
            "Reservada",
            "Por limpiar"});
            this.cmbStatus.Location = new System.Drawing.Point(22, 310);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(400, 32);
            this.cmbStatus.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(192, 374);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Variant = app_escritorio.UI.ButtonVariant.Secondary;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(312, 374);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 40);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TableDialog
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(444, 432);
            this.Controls.Add(this.root);
            this.Name = "TableDialog";
            this.Text = "Mesa";
            this.root.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private app_escritorio.UI.RPanel root;
        private app_escritorio.UI.RLabel lblTitle;
        private app_escritorio.UI.RLabel lblName;
        private app_escritorio.UI.RTextBox txtName;
        private app_escritorio.UI.RLabel lblSector;
        private app_escritorio.UI.RComboBox cmbSector;
        private app_escritorio.UI.RLabel lblCapacity;
        private app_escritorio.UI.RComboBox cmbCapacity;
        private app_escritorio.UI.RLabel lblStatus;
        private app_escritorio.UI.RComboBox cmbStatus;
        private app_escritorio.UI.RButton btnCancel;
        private app_escritorio.UI.RButton btnSave;
    }
}
