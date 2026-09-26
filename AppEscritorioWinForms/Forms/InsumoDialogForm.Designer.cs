namespace app_escritorio.Forms
{
    partial class InsumoDialogForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.stockBox = new System.Windows.Forms.TextBox();
            this.unitBox = new System.Windows.Forms.ComboBox();
            this.minBox = new System.Windows.Forms.TextBox();
            this.costBox = new System.Windows.Forms.TextBox();
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
            this.titleLabel.Size = new System.Drawing.Size(168, 30);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Nuevo insumo";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.LightGray;
            this.lblName.Location = new System.Drawing.Point(20, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nombre *";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.nameBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nameBox.ForeColor = System.Drawing.Color.White;
            this.nameBox.Location = new System.Drawing.Point(20, 90);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(280, 29);
            this.nameBox.TabIndex = 2;
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.ForeColor = System.Drawing.Color.LightGray;
            this.lblCat.Location = new System.Drawing.Point(20, 130);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(54, 13);
            this.lblCat.TabIndex = 3;
            this.lblCat.Text = "Categoría";
            // 
            // categoryBox
            // 
            this.categoryBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.categoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.categoryBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.categoryBox.ForeColor = System.Drawing.Color.White;
            this.categoryBox.Items.AddRange(new object[] {
            "Carnes",
            "Verduras",
            "Lácteos",
            "Bebidas",
            "Secos"});
            this.categoryBox.Location = new System.Drawing.Point(20, 150);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(280, 29);
            this.categoryBox.TabIndex = 4;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.ForeColor = System.Drawing.Color.LightGray;
            this.lblStock.Location = new System.Drawing.Point(20, 190);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(66, 13);
            this.lblStock.TabIndex = 5;
            this.lblStock.Text = "Stock actual";
            // 
            // stockBox
            // 
            this.stockBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.stockBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.stockBox.ForeColor = System.Drawing.Color.White;
            this.stockBox.Location = new System.Drawing.Point(20, 210);
            this.stockBox.Name = "stockBox";
            this.stockBox.Size = new System.Drawing.Size(280, 29);
            this.stockBox.TabIndex = 6;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.ForeColor = System.Drawing.Color.LightGray;
            this.lblUnit.Location = new System.Drawing.Point(20, 250);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(41, 13);
            this.lblUnit.TabIndex = 7;
            this.lblUnit.Text = "Unidad";
            // 
            // unitBox
            // 
            this.unitBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.unitBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.unitBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.unitBox.ForeColor = System.Drawing.Color.White;
            this.unitBox.Items.AddRange(new object[] {
            "kg",
            "L",
            "und",
            "g"});
            this.unitBox.Location = new System.Drawing.Point(20, 270);
            this.unitBox.Name = "unitBox";
            this.unitBox.Size = new System.Drawing.Size(280, 29);
            this.unitBox.TabIndex = 8;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.ForeColor = System.Drawing.Color.LightGray;
            this.lblMin.Location = new System.Drawing.Point(20, 310);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(70, 13);
            this.lblMin.TabIndex = 9;
            this.lblMin.Text = "Mínimo alerta";
            // 
            // minBox
            // 
            this.minBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.minBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.minBox.ForeColor = System.Drawing.Color.White;
            this.minBox.Location = new System.Drawing.Point(20, 330);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(280, 29);
            this.minBox.TabIndex = 10;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.ForeColor = System.Drawing.Color.LightGray;
            this.lblCost.Location = new System.Drawing.Point(20, 370);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(74, 13);
            this.lblCost.TabIndex = 11;
            this.lblCost.Text = "Costo unitario";
            // 
            // costBox
            // 
            this.costBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.costBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.costBox.ForeColor = System.Drawing.Color.White;
            this.costBox.Location = new System.Drawing.Point(20, 390);
            this.costBox.Name = "costBox";
            this.costBox.Size = new System.Drawing.Size(280, 29);
            this.costBox.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(80, 430);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(53)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.ForeColor = System.Drawing.Color.Black;
            this.btnOk.Location = new System.Drawing.Point(200, 430);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 40);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "Guardar";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // InsumoDialogForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.Size = new System.Drawing.Size(350, 520);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.costBox);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.minBox);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.unitBox);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.stockBox);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.titleLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InsumoDialogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo insumo";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.TextBox stockBox;
        private System.Windows.Forms.ComboBox unitBox;
        private System.Windows.Forms.TextBox minBox;
        private System.Windows.Forms.TextBox costBox;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}
