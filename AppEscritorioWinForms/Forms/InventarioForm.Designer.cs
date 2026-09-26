using System.Drawing;
using System.Windows.Forms;

namespace app_escritorio.Forms
{
    partial class InventarioForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private app_escritorio.Controls.SidebarControl sidebarControl1;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sidebarControl1 = new app_escritorio.Controls.SidebarControl();
            this.SuspendLayout();
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.FromArgb(17, 20, 21);
            this.ForeColor = Color.White;
            this.Padding = new Padding(20);

            var header = new Panel { Dock = DockStyle.Top, Height = 60 };
            
            var lblTitle = new Label { Text = "Inventario", Font = new Font("Segoe UI", 24, FontStyle.Bold), AutoSize = true, Location = new Point(0, 5) };
            
            this.lblAlerts = new Label { Text = "0 alertas stock bajo", Font = new Font("Segoe UI", 12, FontStyle.Bold), ForeColor = Color.IndianRed, AutoSize = true, Location = new Point(170, 20) };
            
            var btnAdd = new Button { Text = "+ Nuevo insumo", Size = new Size(150, 40), BackColor = Color.FromArgb(255, 107, 53), ForeColor = Color.Black, FlatStyle = FlatStyle.Flat, Anchor = AnchorStyles.Top | AnchorStyles.Right };
            btnAdd.Location = new Point(this.Width - 190, 10);
            btnAdd.Click += this.Add_Click;

            header.Controls.Add(lblTitle);
            header.Controls.Add(this.lblAlerts);
            header.Controls.Add(btnAdd);
            header.Resize += (s, e) => btnAdd.Left = header.Width - btnAdd.Width - 20;

            var filters = new Panel { Dock = DockStyle.Top, Height = 50, Padding = new Padding(0, 10, 0, 10) };
            this.searchBox = new TextBox { Width = 250, Location = new Point(0, 10), Font = new Font("Segoe UI", 12), BackColor = Color.FromArgb(40, 42, 44), ForeColor = Color.White };
            this.searchBox.TextChanged += (s, e) => this.ApplyFilter();
            
            this.categoryBox = new ComboBox { Location = new Point(260, 10), Width = 180, Font = new Font("Segoe UI", 12), DropDownStyle = ComboBoxStyle.DropDownList, BackColor = Color.FromArgb(40, 42, 44), ForeColor = Color.White };
            this.categoryBox.SelectedIndexChanged += (s, e) => this.ApplyFilter();

            this.lowCheck = new CheckBox { Text = "Solo stock bajo", Location = new Point(460, 12), AutoSize = true, ForeColor = Color.LightGray };
            this.lowCheck.CheckedChanged += (s, e) => this.ApplyFilter();

            filters.Controls.Add(this.searchBox);
            filters.Controls.Add(this.categoryBox);
            filters.Controls.Add(this.lowCheck);

            this.grid = new DataGridView
            {
                Dock = DockStyle.Fill,
                BackgroundColor = Color.FromArgb(29, 32, 34),
                ForeColor = Color.Black,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                RowHeadersVisible = false,
                AutoGenerateColumns = false
            };
            
            this.grid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Name", HeaderText = "Insumo", FillWeight = 30 });
            this.grid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Category", HeaderText = "Categoría", FillWeight = 15 });
            this.grid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StockText", HeaderText = "Stock", FillWeight = 15 });
            this.grid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MinText", HeaderText = "Mínimo", FillWeight = 15 });
            this.grid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Estado", HeaderText = "Estado", FillWeight = 10 });
            this.grid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CostText", HeaderText = "Costo", FillWeight = 15 });
            
            var editCol = new DataGridViewButtonColumn { HeaderText = "", Text = "Ajustar", UseColumnTextForButtonValue = true, FillWeight = 10 };
            var delCol = new DataGridViewButtonColumn { HeaderText = "", Text = "×", UseColumnTextForButtonValue = true, FillWeight = 5 };
            
            this.grid.Columns.Add(editCol);
            this.grid.Columns.Add(delCol);

            this.grid.CellFormatting += this.Grid_CellFormatting;
            this.grid.CellClick += this.Grid_CellClick;

            this.Controls.Add(this.grid);
            this.Controls.Add(filters);
            this.Controls.Add(header);
            this.Controls.Add(this.sidebarControl1);
            // sidebarControl1
            this.sidebarControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.sidebarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarControl1.Location = new System.Drawing.Point(0, 0);
            this.sidebarControl1.Name = "sidebarControl1";
            this.sidebarControl1.Size = new System.Drawing.Size(250, 900);
            this.sidebarControl1.TabIndex = 100;
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.CheckBox lowCheck;
        private System.Windows.Forms.Label lblAlerts;
    }
}





