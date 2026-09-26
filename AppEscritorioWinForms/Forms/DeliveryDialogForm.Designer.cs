using System;
using System.Drawing;
using System.Windows.Forms;

namespace app_escritorio.Forms
{
    partial class DeliveryDialogForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.lblPlat = new System.Windows.Forms.Label();
            this.plataformaBox = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.fechaPicker = new System.Windows.Forms.DateTimePicker();
            this.lblHora = new System.Windows.Forms.Label();
            this.horaBox = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.clienteBox = new System.Windows.Forms.TextBox();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.detalleBox = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.estadoBox = new System.Windows.Forms.ComboBox();
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
            this.titleLabel.Text = "Nuevo pedido";
            // 
            // lblPlat
            // 
            this.lblPlat.AutoSize = true;
            this.lblPlat.ForeColor = System.Drawing.Color.LightGray;
            this.lblPlat.Location = new System.Drawing.Point(20, 70);
            this.lblPlat.Name = "lblPlat";
            this.lblPlat.Size = new System.Drawing.Size(62, 13);
            this.lblPlat.TabIndex = 1;
            this.lblPlat.Text = "Plataforma";
            // 
            // plataformaBox
            // 
            this.plataformaBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.plataformaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.plataformaBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.plataformaBox.ForeColor = System.Drawing.Color.White;
            this.plataformaBox.FormattingEnabled = true;
            this.plataformaBox.Items.AddRange(new object[] {
            "Rappi",
            "Uber Eats",
            "DiDi Food"});
            this.plataformaBox.Location = new System.Drawing.Point(20, 90);
            this.plataformaBox.Name = "plataformaBox";
            this.plataformaBox.Size = new System.Drawing.Size(360, 29);
            this.plataformaBox.TabIndex = 2;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.Color.LightGray;
            this.lblId.Location = new System.Drawing.Point(20, 130);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(72, 13);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "ID del pedido";
            // 
            // idBox
            // 
            this.idBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.idBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.idBox.ForeColor = System.Drawing.Color.White;
            this.idBox.Location = new System.Drawing.Point(20, 150);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(360, 29);
            this.idBox.TabIndex = 4;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.ForeColor = System.Drawing.Color.LightGray;
            this.lblFecha.Location = new System.Drawing.Point(20, 190);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha";
            // 
            // fechaPicker
            // 
            this.fechaPicker.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fechaPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaPicker.Location = new System.Drawing.Point(20, 210);
            this.fechaPicker.Name = "fechaPicker";
            this.fechaPicker.Size = new System.Drawing.Size(360, 29);
            this.fechaPicker.TabIndex = 6;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.ForeColor = System.Drawing.Color.LightGray;
            this.lblHora.Location = new System.Drawing.Point(20, 250);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(72, 13);
            this.lblHora.TabIndex = 7;
            this.lblHora.Text = "Hora (HH:mm)";
            // 
            // horaBox
            // 
            this.horaBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.horaBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.horaBox.ForeColor = System.Drawing.Color.White;
            this.horaBox.Location = new System.Drawing.Point(20, 270);
            this.horaBox.Name = "horaBox";
            this.horaBox.Size = new System.Drawing.Size(360, 29);
            this.horaBox.TabIndex = 8;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.ForeColor = System.Drawing.Color.LightGray;
            this.lblCliente.Location = new System.Drawing.Point(20, 310);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(46, 13);
            this.lblCliente.TabIndex = 9;
            this.lblCliente.Text = "Cliente *";
            // 
            // clienteBox
            // 
            this.clienteBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.clienteBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.clienteBox.ForeColor = System.Drawing.Color.White;
            this.clienteBox.Location = new System.Drawing.Point(20, 330);
            this.clienteBox.Name = "clienteBox";
            this.clienteBox.Size = new System.Drawing.Size(360, 29);
            this.clienteBox.TabIndex = 10;
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.ForeColor = System.Drawing.Color.LightGray;
            this.lblDetalle.Location = new System.Drawing.Point(20, 370);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(95, 13);
            this.lblDetalle.TabIndex = 11;
            this.lblDetalle.Text = "Detalle del pedido *";
            // 
            // detalleBox
            // 
            this.detalleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.detalleBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.detalleBox.ForeColor = System.Drawing.Color.White;
            this.detalleBox.Location = new System.Drawing.Point(20, 390);
            this.detalleBox.Multiline = true;
            this.detalleBox.Name = "detalleBox";
            this.detalleBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.detalleBox.Size = new System.Drawing.Size(360, 60);
            this.detalleBox.TabIndex = 12;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.Color.LightGray;
            this.lblTotal.Location = new System.Drawing.Point(20, 460);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(61, 13);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total (COP)";
            // 
            // totalBox
            // 
            this.totalBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.totalBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.totalBox.ForeColor = System.Drawing.Color.White;
            this.totalBox.Location = new System.Drawing.Point(20, 480);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(360, 29);
            this.totalBox.TabIndex = 14;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.ForeColor = System.Drawing.Color.LightGray;
            this.lblEstado.Location = new System.Drawing.Point(20, 520);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 15;
            this.lblEstado.Text = "Estado";
            // 
            // estadoBox
            // 
            this.estadoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.estadoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.estadoBox.ForeColor = System.Drawing.Color.White;
            this.estadoBox.FormattingEnabled = true;
            this.estadoBox.Items.AddRange(new object[] {
            "Nuevo",
            "En preparación",
            "Listo para rider",
            "Entregado"});
            this.estadoBox.Location = new System.Drawing.Point(20, 540);
            this.estadoBox.Name = "estadoBox";
            this.estadoBox.Size = new System.Drawing.Size(360, 29);
            this.estadoBox.TabIndex = 16;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(160, 600);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(53)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.ForeColor = System.Drawing.Color.Black;
            this.btnOk.Location = new System.Drawing.Point(280, 600);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 40);
            this.btnOk.TabIndex = 18;
            this.btnOk.Text = "Guardar";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // DeliveryDialogForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(420, 720);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.lblPlat);
            this.Controls.Add(this.plataformaBox);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.fechaPicker);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.horaBox);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.clienteBox);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.detalleBox);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.estadoBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeliveryDialogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo pedido";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label lblPlat;
        private System.Windows.Forms.ComboBox plataformaBox;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker fechaPicker;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox horaBox;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox clienteBox;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.TextBox detalleBox;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox estadoBox;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}
