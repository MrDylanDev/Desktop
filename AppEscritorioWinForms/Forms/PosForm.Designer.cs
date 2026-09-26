namespace app_escritorio.Forms
{
    partial class PosForm
    {
        private System.ComponentModel.IContainer components = null;
        private app_escritorio.Controls.SidebarControl sidebarControl1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.leftPanel = new System.Windows.Forms.Panel();
            this.productsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.headerLeft = new System.Windows.Forms.Panel();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.ticketGrid = new System.Windows.Forms.DataGridView();
            this.footerRight = new System.Windows.Forms.Panel();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.taxSelector = new System.Windows.Forms.ComboBox();
            this.headerRight = new System.Windows.Forms.Panel();
            this.lblMesa = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.headerLeft.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketGrid)).BeginInit();
            this.footerRight.SuspendLayout();
            this.headerRight.SuspendLayout();
            this.SuspendLayout();
            this.sidebarControl1 = new app_escritorio.Controls.SidebarControl();
            
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.productsPanel);
            this.leftPanel.Controls.Add(this.headerLeft);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(250, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Padding = new System.Windows.Forms.Padding(10);
            this.leftPanel.Size = new System.Drawing.Size(930, 720);
            this.leftPanel.TabIndex = 0;
            // 
            // productsPanel
            // 
            this.productsPanel.AutoScroll = true;
            this.productsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsPanel.Location = new System.Drawing.Point(260, 70);
            this.productsPanel.Name = "productsPanel";
            this.productsPanel.Size = new System.Drawing.Size(910, 640);
            this.productsPanel.TabIndex = 1;
            // 
            // headerLeft
            // 
            this.headerLeft.Controls.Add(this.categoryBox);
            this.headerLeft.Controls.Add(this.searchBox);
            this.headerLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerLeft.Location = new System.Drawing.Point(260, 10);
            this.headerLeft.Name = "headerLeft";
            this.headerLeft.Size = new System.Drawing.Size(910, 60);
            this.headerLeft.TabIndex = 0;
            // 
            // categoryBox
            // 
            this.categoryBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.categoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoryBox.ForeColor = System.Drawing.Color.White;
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Items.AddRange(new object[] {
            "Todos",
            "Pizzas y pastas",
            "Carnes y parrilla",
            "Hamburguesas",
            "Bebidas",
            "Postres y café"});
            this.categoryBox.Location = new System.Drawing.Point(260, 15);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(200, 36);
            this.categoryBox.TabIndex = 1;
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBox.ForeColor = System.Drawing.Color.White;
            this.searchBox.Location = new System.Drawing.Point(250, 15);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(250, 34);
            this.searchBox.TabIndex = 0;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.rightPanel.Controls.Add(this.ticketGrid);
            this.rightPanel.Controls.Add(this.footerRight);
            this.rightPanel.Controls.Add(this.headerRight);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(930, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Padding = new System.Windows.Forms.Padding(10);
            this.rightPanel.Size = new System.Drawing.Size(350, 720);
            this.rightPanel.TabIndex = 1;
            // 
            // ticketGrid
            // 
            this.ticketGrid.AllowUserToAddRows = false;
            this.ticketGrid.AllowUserToDeleteRows = false;
            this.ticketGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ticketGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.ticketGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ticketGrid.Location = new System.Drawing.Point(260, 70);
            this.ticketGrid.Name = "ticketGrid";
            this.ticketGrid.ReadOnly = true;
            this.ticketGrid.RowHeadersVisible = false;
            this.ticketGrid.RowHeadersWidth = 51;
            this.ticketGrid.RowTemplate.Height = 29;
            this.ticketGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ticketGrid.Size = new System.Drawing.Size(330, 460);
            this.ticketGrid.TabIndex = 1;
            // 
            // footerRight
            // 
            this.footerRight.Controls.Add(this.btnCheckout);
            this.footerRight.Controls.Add(this.lblTotal);
            this.footerRight.Controls.Add(this.lblTax);
            this.footerRight.Controls.Add(this.lblSubtotal);
            this.footerRight.Controls.Add(this.taxSelector);
            this.footerRight.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerRight.Location = new System.Drawing.Point(260, 530);
            this.footerRight.Name = "footerRight";
            this.footerRight.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.footerRight.Size = new System.Drawing.Size(330, 180);
            this.footerRight.TabIndex = 2;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(53)))));
            this.btnCheckout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheckout.ForeColor = System.Drawing.Color.Black;
            this.btnCheckout.Location = new System.Drawing.Point(250, 130);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(330, 50);
            this.btnCheckout.TabIndex = 4;
            this.btnCheckout.Text = "COBRAR";
            this.btnCheckout.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(53)))));
            this.lblTotal.Location = new System.Drawing.Point(250, 86);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(330, 40);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total: $0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTax
            // 
            this.lblTax.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTax.ForeColor = System.Drawing.Color.LightGray;
            this.lblTax.Location = new System.Drawing.Point(250, 61);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(330, 25);
            this.lblTax.TabIndex = 2;
            this.lblTax.Text = "Impuesto: $0";
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSubtotal.ForeColor = System.Drawing.Color.LightGray;
            this.lblSubtotal.Location = new System.Drawing.Point(250, 36);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(330, 25);
            this.lblSubtotal.TabIndex = 1;
            this.lblSubtotal.Text = "Subtotal: $0";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taxSelector
            // 
            this.taxSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.taxSelector.FormattingEnabled = true;
            this.taxSelector.Items.AddRange(new object[] {
            "Exento — 0%",
            "INC — 8%",
            "IVA — 19%"});
            this.taxSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.taxSelector.Name = "taxSelector";
            this.taxSelector.Size = new System.Drawing.Size(330, 28);
            this.taxSelector.TabIndex = 0;
            // 
            // headerRight
            // 
            this.headerRight.Controls.Add(this.lblMesa);
            this.headerRight.Controls.Add(this.lblTitle);
            this.headerRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerRight.Location = new System.Drawing.Point(260, 10);
            this.headerRight.Name = "headerRight";
            this.headerRight.Size = new System.Drawing.Size(330, 60);
            this.headerRight.TabIndex = 0;
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.ForeColor = System.Drawing.Color.LightGray;
            this.lblMesa.Location = new System.Drawing.Point(250, 40);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(155, 20);
            this.lblMesa.TabIndex = 1;
            this.lblMesa.Text = "Mesa no seleccionada";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(250, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(193, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Pedido actual";
            // 
            // PosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.rightPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "PosView";
            this.ClientSize = new System.Drawing.Size(1550, 900);
            this.leftPanel.ResumeLayout(false);
            this.headerLeft.ResumeLayout(false);
            this.headerLeft.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ticketGrid)).EndInit();
            this.footerRight.ResumeLayout(false);
            this.headerRight.ResumeLayout(false);
            this.headerRight.PerformLayout();
            
            
                        
            this.Controls.Add(this.sidebarControl1);
            // 
            // sidebarControl1
            // 
            this.sidebarControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.sidebarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarControl1.Location = new System.Drawing.Point(0, 0);
            this.sidebarControl1.Name = "sidebarControl1";
            this.sidebarControl1.Size = new System.Drawing.Size(250, 900);
            this.sidebarControl1.TabIndex = 100;
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.FlowLayoutPanel productsPanel;
        private System.Windows.Forms.Panel headerLeft;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.DataGridView ticketGrid;
        private System.Windows.Forms.Panel footerRight;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.ComboBox taxSelector;
        private System.Windows.Forms.Panel headerRight;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.Label lblTitle;
    }
}



