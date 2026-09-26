namespace app_escritorio.Forms
{
    partial class ReservaDialogForm
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
            this.cmbEstado = new app_escritorio.UI.RComboBox();
            this.lblEstado = new app_escritorio.UI.RLabel();
            this.txtTel = new app_escritorio.UI.RTextBox();
            this.lblTel = new app_escritorio.UI.RLabel();
            this.cmbMesa = new app_escritorio.UI.RComboBox();
            this.lblMesa = new app_escritorio.UI.RLabel();
            this.cmbPersonas = new app_escritorio.UI.RComboBox();
            this.lblPersonas = new app_escritorio.UI.RLabel();
            this.txtHora = new app_escritorio.UI.RTextBox();
            this.lblHora = new app_escritorio.UI.RLabel();
            this.txtFecha = new app_escritorio.UI.RTextBox();
            this.lblFecha = new app_escritorio.UI.RLabel();
            this.txtCliente = new app_escritorio.UI.RTextBox();
            this.lblCliente = new app_escritorio.UI.RLabel();
            this.lblTitle = new app_escritorio.UI.RLabel();
            this.root.SuspendLayout();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.Controls.Add(this.btnSave);
            this.root.Controls.Add(this.btnCancel);
            this.root.Controls.Add(this.cmbEstado);
            this.root.Controls.Add(this.lblEstado);
            this.root.Controls.Add(this.txtTel);
            this.root.Controls.Add(this.lblTel);
            this.root.Controls.Add(this.cmbMesa);
            this.root.Controls.Add(this.lblMesa);
            this.root.Controls.Add(this.cmbPersonas);
            this.root.Controls.Add(this.lblPersonas);
            this.root.Controls.Add(this.txtHora);
            this.root.Controls.Add(this.lblHora);
            this.root.Controls.Add(this.txtFecha);
            this.root.Controls.Add(this.lblFecha);
            this.root.Controls.Add(this.txtCliente);
            this.root.Controls.Add(this.lblCliente);
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
            this.btnSave.TabIndex = 7;
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
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Variant = app_escritorio.UI.ButtonVariant.Secondary;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Items.AddRange(new object[] {
            "Confirmada",
            "En curso",
            "Cancelada"});
            this.cmbEstado.Location = new System.Drawing.Point(228, 318);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(194, 32);
            this.cmbEstado.TabIndex = 6;
            // 
            // lblEstado
            // 
            this.lblEstado.Location = new System.Drawing.Point(228, 296);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(194, 20);
            this.lblEstado.TabIndex = 66;
            this.lblEstado.Text = "Estado";
            this.lblEstado.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(22, 318);
            this.txtTel.Name = "txtTel";
            this.txtTel.PlaceholderText = "300 000 0000";
            this.txtTel.Size = new System.Drawing.Size(194, 40);
            this.txtTel.TabIndex = 5;
            // 
            // lblTel
            // 
            this.lblTel.Location = new System.Drawing.Point(22, 296);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(194, 20);
            this.lblTel.TabIndex = 65;
            this.lblTel.Text = "Teléfono";
            this.lblTel.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // cmbMesa
            // 
            this.cmbMesa.Items.AddRange(new object[] {
            "Mesa 1",
            "Mesa 2",
            "Mesa 3",
            "Mesa 4",
            "Mesa 5",
            "Terraza 1",
            "Barra 1",
            "VIP 1"});
            this.cmbMesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbMesa.Location = new System.Drawing.Point(228, 250);
            this.cmbMesa.Name = "cmbMesa";
            this.cmbMesa.Size = new System.Drawing.Size(194, 32);
            this.cmbMesa.TabIndex = 4;
            // 
            // lblMesa
            // 
            this.lblMesa.Location = new System.Drawing.Point(228, 228);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(194, 20);
            this.lblMesa.TabIndex = 64;
            this.lblMesa.Text = "Mesa";
            this.lblMesa.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // cmbPersonas
            // 
            this.cmbPersonas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "8",
            "10",
            "12"});
            this.cmbPersonas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbPersonas.Location = new System.Drawing.Point(22, 250);
            this.cmbPersonas.Name = "cmbPersonas";
            this.cmbPersonas.Size = new System.Drawing.Size(194, 32);
            this.cmbPersonas.TabIndex = 3;
            // 
            // lblPersonas
            // 
            this.lblPersonas.Location = new System.Drawing.Point(22, 228);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(194, 20);
            this.lblPersonas.TabIndex = 63;
            this.lblPersonas.Text = "Personas";
            this.lblPersonas.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(228, 174);
            this.txtHora.Name = "txtHora";
            this.txtHora.PlaceholderText = "19:00";
            this.txtHora.Size = new System.Drawing.Size(194, 40);
            this.txtHora.TabIndex = 2;
            // 
            // lblHora
            // 
            this.lblHora.Location = new System.Drawing.Point(228, 152);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(194, 20);
            this.lblHora.TabIndex = 62;
            this.lblHora.Text = "Hora (hh:mm)";
            this.lblHora.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(22, 174);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.PlaceholderText = "dd/mm/aaaa";
            this.txtFecha.Size = new System.Drawing.Size(194, 40);
            this.txtFecha.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(22, 152);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(194, 20);
            this.lblFecha.TabIndex = 61;
            this.lblFecha.Text = "Fecha (dd/mm/aaaa)";
            this.lblFecha.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(22, 98);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.PlaceholderText = "Nombre del cliente";
            this.txtCliente.Size = new System.Drawing.Size(400, 40);
            this.txtCliente.TabIndex = 0;
            // 
            // lblCliente
            // 
            this.lblCliente.Location = new System.Drawing.Point(22, 76);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(400, 20);
            this.lblCliente.TabIndex = 60;
            this.lblCliente.Text = "Cliente *";
            this.lblCliente.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(22, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 36);
            this.lblTitle.TabIndex = 50;
            this.lblTitle.Text = "Nueva reserva";
            this.lblTitle.TextStyle = app_escritorio.UI.TextStyle.Display;
            // 
            // ReservaDialogForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(444, 436);
            this.Name = "ReservaDialogForm";
            this.Text = "Nueva reserva";
            this.Controls.Add(this.root);
            this.root.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private app_escritorio.UI.RPanel root;
        private app_escritorio.UI.RButton btnSave;
        private app_escritorio.UI.RButton btnCancel;
        private app_escritorio.UI.RComboBox cmbEstado;
        private app_escritorio.UI.RLabel lblEstado;
        private app_escritorio.UI.RTextBox txtTel;
        private app_escritorio.UI.RLabel lblTel;
        private app_escritorio.UI.RComboBox cmbMesa;
        private app_escritorio.UI.RLabel lblMesa;
        private app_escritorio.UI.RComboBox cmbPersonas;
        private app_escritorio.UI.RLabel lblPersonas;
        private app_escritorio.UI.RTextBox txtHora;
        private app_escritorio.UI.RLabel lblHora;
        private app_escritorio.UI.RTextBox txtFecha;
        private app_escritorio.UI.RLabel lblFecha;
        private app_escritorio.UI.RTextBox txtCliente;
        private app_escritorio.UI.RLabel lblCliente;
        private app_escritorio.UI.RLabel lblTitle;
    }
}
