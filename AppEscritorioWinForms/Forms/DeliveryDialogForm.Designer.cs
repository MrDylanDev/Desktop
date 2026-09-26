namespace app_escritorio.Forms
{
    partial class DeliveryDialogForm
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
            this.txtTotal = new app_escritorio.UI.RTextBox();
            this.lblTotal = new app_escritorio.UI.RLabel();
            this.txtDetalle = new app_escritorio.UI.RTextBox();
            this.lblDetalle = new app_escritorio.UI.RLabel();
            this.txtCliente = new app_escritorio.UI.RTextBox();
            this.lblCliente = new app_escritorio.UI.RLabel();
            this.txtHora = new app_escritorio.UI.RTextBox();
            this.lblHora = new app_escritorio.UI.RLabel();
            this.txtFecha = new app_escritorio.UI.RTextBox();
            this.lblFecha = new app_escritorio.UI.RLabel();
            this.txtId = new app_escritorio.UI.RTextBox();
            this.lblId = new app_escritorio.UI.RLabel();
            this.cmbPlataforma = new app_escritorio.UI.RComboBox();
            this.lblPlataforma = new app_escritorio.UI.RLabel();
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
            this.root.Controls.Add(this.txtTotal);
            this.root.Controls.Add(this.lblTotal);
            this.root.Controls.Add(this.txtDetalle);
            this.root.Controls.Add(this.lblDetalle);
            this.root.Controls.Add(this.txtCliente);
            this.root.Controls.Add(this.lblCliente);
            this.root.Controls.Add(this.txtHora);
            this.root.Controls.Add(this.lblHora);
            this.root.Controls.Add(this.txtFecha);
            this.root.Controls.Add(this.lblFecha);
            this.root.Controls.Add(this.txtId);
            this.root.Controls.Add(this.lblId);
            this.root.Controls.Add(this.cmbPlataforma);
            this.root.Controls.Add(this.lblPlataforma);
            this.root.Controls.Add(this.lblTitle);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(0, 0);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(480, 552);
            this.root.Surface = app_escritorio.UI.SurfaceLevel.Surface;
            this.root.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(348, 494);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 40);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Guardar";
            this.btnSave.Variant = app_escritorio.UI.ButtonVariant.Primary;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(228, 494);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 40);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Variant = app_escritorio.UI.ButtonVariant.Secondary;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Items.AddRange(new object[] {
            "Nuevo",
            "En preparación",
            "Listo para rider",
            "Entregado"});
            this.cmbEstado.Location = new System.Drawing.Point(246, 434);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(212, 32);
            this.cmbEstado.TabIndex = 7;
            // 
            // lblEstado
            // 
            this.lblEstado.Location = new System.Drawing.Point(246, 412);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(212, 20);
            this.lblEstado.TabIndex = 67;
            this.lblEstado.Text = "Estado";
            this.lblEstado.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(22, 434);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PlaceholderText = "0";
            this.txtTotal.Size = new System.Drawing.Size(212, 40);
            this.txtTotal.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(22, 412);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(212, 20);
            this.lblTotal.TabIndex = 66;
            this.lblTotal.Text = "Total ($) *";
            this.lblTotal.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(22, 326);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.PlaceholderText = "x1 Pizza Napolitana, x1 Cerveza IPA";
            this.txtDetalle.Size = new System.Drawing.Size(436, 72);
            this.txtDetalle.TabIndex = 5;
            // 
            // lblDetalle
            // 
            this.lblDetalle.Location = new System.Drawing.Point(22, 304);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(436, 20);
            this.lblDetalle.TabIndex = 65;
            this.lblDetalle.Text = "Detalle *";
            this.lblDetalle.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(22, 250);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.PlaceholderText = "Nombre del cliente";
            this.txtCliente.Size = new System.Drawing.Size(436, 40);
            this.txtCliente.TabIndex = 4;
            // 
            // lblCliente
            // 
            this.lblCliente.Location = new System.Drawing.Point(22, 228);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(436, 20);
            this.lblCliente.TabIndex = 64;
            this.lblCliente.Text = "Cliente *";
            this.lblCliente.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(246, 174);
            this.txtHora.Name = "txtHora";
            this.txtHora.PlaceholderText = "12:00";
            this.txtHora.Size = new System.Drawing.Size(212, 40);
            this.txtHora.TabIndex = 3;
            // 
            // lblHora
            // 
            this.lblHora.Location = new System.Drawing.Point(246, 152);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(212, 20);
            this.lblHora.TabIndex = 63;
            this.lblHora.Text = "Hora (hh:mm)";
            this.lblHora.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(22, 174);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.PlaceholderText = "dd/mm/aaaa";
            this.txtFecha.Size = new System.Drawing.Size(212, 40);
            this.txtFecha.TabIndex = 2;
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(22, 152);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(212, 20);
            this.lblFecha.TabIndex = 62;
            this.lblFecha.Text = "Fecha (dd/mm/aaaa)";
            this.lblFecha.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(246, 98);
            this.txtId.Name = "txtId";
            this.txtId.PlaceholderText = "#R-0000";
            this.txtId.Size = new System.Drawing.Size(212, 40);
            this.txtId.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(246, 76);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(212, 20);
            this.lblId.TabIndex = 61;
            this.lblId.Text = "ID del pedido";
            this.lblId.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // cmbPlataforma
            // 
            this.cmbPlataforma.Items.AddRange(new object[] {
            "Rappi",
            "Uber Eats",
            "DiDi Food"});
            this.cmbPlataforma.Location = new System.Drawing.Point(22, 98);
            this.cmbPlataforma.Name = "cmbPlataforma";
            this.cmbPlataforma.Size = new System.Drawing.Size(212, 32);
            this.cmbPlataforma.TabIndex = 0;
            // 
            // lblPlataforma
            // 
            this.lblPlataforma.Location = new System.Drawing.Point(22, 76);
            this.lblPlataforma.Name = "lblPlataforma";
            this.lblPlataforma.Size = new System.Drawing.Size(212, 20);
            this.lblPlataforma.TabIndex = 60;
            this.lblPlataforma.Text = "Plataforma";
            this.lblPlataforma.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(22, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(436, 36);
            this.lblTitle.TabIndex = 50;
            this.lblTitle.Text = "Nuevo pedido";
            this.lblTitle.TextStyle = app_escritorio.UI.TextStyle.Display;
            // 
            // DeliveryDialogForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(480, 552);
            this.Name = "DeliveryDialogForm";
            this.Text = "Nuevo pedido";
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
        private app_escritorio.UI.RTextBox txtTotal;
        private app_escritorio.UI.RLabel lblTotal;
        private app_escritorio.UI.RTextBox txtDetalle;
        private app_escritorio.UI.RLabel lblDetalle;
        private app_escritorio.UI.RTextBox txtCliente;
        private app_escritorio.UI.RLabel lblCliente;
        private app_escritorio.UI.RTextBox txtHora;
        private app_escritorio.UI.RLabel lblHora;
        private app_escritorio.UI.RTextBox txtFecha;
        private app_escritorio.UI.RLabel lblFecha;
        private app_escritorio.UI.RTextBox txtId;
        private app_escritorio.UI.RLabel lblId;
        private app_escritorio.UI.RComboBox cmbPlataforma;
        private app_escritorio.UI.RLabel lblPlataforma;
        private app_escritorio.UI.RLabel lblTitle;
    }
}
