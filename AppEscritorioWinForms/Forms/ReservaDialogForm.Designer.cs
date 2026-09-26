namespace app_escritorio.Forms
{
    partial class ReservaDialogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.fechaPicker = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.horaBox = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.clienteBox = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.personasBox = new System.Windows.Forms.TextBox();
            this.lblPersonas = new System.Windows.Forms.Label();
            this.mesaBox = new System.Windows.Forms.ComboBox();
            this.lblMesa = new System.Windows.Forms.Label();
            this.telBox = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.estadoBox = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(20, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(161, 30);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Nueva reserva";
            // 
            // fechaPicker
            // 
            this.fechaPicker.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fechaPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaPicker.Location = new System.Drawing.Point(20, 90);
            this.fechaPicker.Name = "fechaPicker";
            this.fechaPicker.Size = new System.Drawing.Size(340, 29);
            this.fechaPicker.TabIndex = 2;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.ForeColor = System.Drawing.Color.LightGray;
            this.lblFecha.Location = new System.Drawing.Point(20, 70);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(42, 15);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha";
            // 
            // horaBox
            // 
            this.horaBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.horaBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.horaBox.ForeColor = System.Drawing.Color.White;
            this.horaBox.Location = new System.Drawing.Point(20, 150);
            this.horaBox.Name = "horaBox";
            this.horaBox.Size = new System.Drawing.Size(340, 29);
            this.horaBox.TabIndex = 4;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.ForeColor = System.Drawing.Color.LightGray;
            this.lblHora.Location = new System.Drawing.Point(20, 130);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(84, 15);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "Hora (HH:mm)";
            // 
            // clienteBox
            // 
            this.clienteBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.clienteBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.clienteBox.ForeColor = System.Drawing.Color.White;
            this.clienteBox.Location = new System.Drawing.Point(20, 210);
            this.clienteBox.Name = "clienteBox";
            this.clienteBox.Size = new System.Drawing.Size(340, 29);
            this.clienteBox.TabIndex = 6;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.ForeColor = System.Drawing.Color.LightGray;
            this.lblCliente.Location = new System.Drawing.Point(20, 190);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(56, 15);
            this.lblCliente.TabIndex = 5;
            this.lblCliente.Text = "Cliente *";
            // 
            // personasBox
            // 
            this.personasBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.personasBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.personasBox.ForeColor = System.Drawing.Color.White;
            this.personasBox.Location = new System.Drawing.Point(20, 270);
            this.personasBox.Name = "personasBox";
            this.personasBox.Size = new System.Drawing.Size(340, 29);
            this.personasBox.TabIndex = 8;
            // 
            // lblPersonas
            // 
            this.lblPersonas.AutoSize = true;
            this.lblPersonas.ForeColor = System.Drawing.Color.LightGray;
            this.lblPersonas.Location = new System.Drawing.Point(20, 250);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(54, 15);
            this.lblPersonas.TabIndex = 7;
            this.lblPersonas.Text = "Personas";
            // 
            // mesaBox
            // 
            this.mesaBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.mesaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.mesaBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mesaBox.ForeColor = System.Drawing.Color.White;
            this.mesaBox.Items.AddRange(new object[] {
            "Mesa 1",
            "Mesa 2",
            "Mesa 3",
            "Mesa 4",
            "Terraza 1",
            "Barra 1",
            "VIP 1"});
            this.mesaBox.Location = new System.Drawing.Point(20, 330);
            this.mesaBox.Name = "mesaBox";
            this.mesaBox.Size = new System.Drawing.Size(340, 29);
            this.mesaBox.TabIndex = 10;
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.ForeColor = System.Drawing.Color.LightGray;
            this.lblMesa.Location = new System.Drawing.Point(20, 310);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(86, 15);
            this.lblMesa.TabIndex = 9;
            this.lblMesa.Text = "Mesa asignada";
            // 
            // telBox
            // 
            this.telBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.telBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.telBox.ForeColor = System.Drawing.Color.White;
            this.telBox.Location = new System.Drawing.Point(20, 390);
            this.telBox.Name = "telBox";
            this.telBox.Size = new System.Drawing.Size(340, 29);
            this.telBox.TabIndex = 12;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.ForeColor = System.Drawing.Color.LightGray;
            this.lblTel.Location = new System.Drawing.Point(20, 370);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(52, 15);
            this.lblTel.TabIndex = 11;
            this.lblTel.Text = "Teléfono";
            // 
            // estadoBox
            // 
            this.estadoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.estadoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.estadoBox.ForeColor = System.Drawing.Color.White;
            this.estadoBox.Items.AddRange(new object[] {
            "Confirmada",
            "En curso",
            "Cancelada"});
            this.estadoBox.Location = new System.Drawing.Point(20, 450);
            this.estadoBox.Name = "estadoBox";
            this.estadoBox.Size = new System.Drawing.Size(340, 29);
            this.estadoBox.TabIndex = 14;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.ForeColor = System.Drawing.Color.LightGray;
            this.lblEstado.Location = new System.Drawing.Point(20, 430);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(42, 15);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "Estado";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(130, 520);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(53)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.ForeColor = System.Drawing.Color.Black;
            this.btnOk.Location = new System.Drawing.Point(250, 520);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 40);
            this.btnOk.TabIndex = 16;
            this.btnOk.Text = "Guardar";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // ReservaDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(400, 650);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.estadoBox);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.telBox);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.mesaBox);
            this.Controls.Add(this.lblMesa);
            this.Controls.Add(this.personasBox);
            this.Controls.Add(this.lblPersonas);
            this.Controls.Add(this.clienteBox);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.horaBox);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.fechaPicker);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.titleLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReservaDialogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.DateTimePicker fechaPicker;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox horaBox;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox clienteBox;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox personasBox;
        private System.Windows.Forms.Label lblPersonas;
        private System.Windows.Forms.ComboBox mesaBox;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.TextBox telBox;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.ComboBox estadoBox;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}
