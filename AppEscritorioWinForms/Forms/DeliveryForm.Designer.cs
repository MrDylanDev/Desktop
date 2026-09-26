using System.Drawing;
using System.Windows.Forms;

namespace app_escritorio.Forms
{
    partial class DeliveryForm
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
            this.grid = new System.Windows.Forms.DataGridView();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.plataformaBox = new System.Windows.Forms.ComboBox();
            this.estadoBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            this.sidebarControl1 = new app_escritorio.Controls.SidebarControl();
            

            this.Dock = DockStyle.Fill;
            this.BackColor = Color.FromArgb(17, 20, 21);
            this.ForeColor = Color.White;
            this.Padding = new Padding(20);

            var header = new Panel { Dock = DockStyle.Top, Height = 60 };
            
            var lblTitle = new Label { Text = "Delivery", Font = new Font("Segoe UI", 24, FontStyle.Bold), AutoSize = true, Location = new Point(0, 5) };
            var lblSubtitle = new Label { Text = "● Agregador conectado (DEMO)", Font = new Font("Segoe UI", 12), ForeColor = Color.MediumSeaGreen, AutoSize = true, Location = new Point(140, 20) };
            
            var btnSync = new Button { Text = "↻ Sincronizar menú", Size = new Size(160, 40), BackColor = Color.FromArgb(40, 42, 44), FlatStyle = FlatStyle.Flat, Anchor = AnchorStyles.Top | AnchorStyles.Right };
            btnSync.Location = new Point(this.Width - 350, 10);
            btnSync.Click += (s, e) => MessageBox.Show("Menú sincronizado con plataformas (precio/disponibilidad) — DEMO frontend.", "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var btnAdd = new Button { Text = "+ Nuevo pedido", Size = new Size(150, 40), BackColor = Color.FromArgb(255, 107, 53), ForeColor = Color.Black, FlatStyle = FlatStyle.Flat, Anchor = AnchorStyles.Top | AnchorStyles.Right };
            btnAdd.Location = new Point(this.Width - 190, 10);
            btnAdd.Click += this.Nuevo_Click;

            header.Controls.Add(lblTitle);
            header.Controls.Add(lblSubtitle);
            header.Controls.Add(btnSync);
            header.Controls.Add(btnAdd);
            
            header.Resize += (s, e) => 
            {
                btnAdd.Left = header.Width - btnAdd.Width - 20;
                btnSync.Left = btnAdd.Left - btnSync.Width - 10;
            };

            var filters = new Panel { Dock = DockStyle.Top, Height = 50, Padding = new Padding(0, 10, 0, 10) };
            this.searchBox.Width = 250;
            this.searchBox.Location = new Point(0, 10);
            this.searchBox.Font = new Font("Segoe UI", 12);
            this.searchBox.BackColor = Color.FromArgb(40, 42, 44);
            this.searchBox.ForeColor = Color.White;
            this.searchBox.TextChanged += (s, e) => this.ApplyFilter();
            
            this.plataformaBox.Location = new Point(260, 10);
            this.plataformaBox.Width = 150;
            this.plataformaBox.Font = new Font("Segoe UI", 12);
            this.plataformaBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.plataformaBox.BackColor = Color.FromArgb(40, 42, 44);
            this.plataformaBox.ForeColor = Color.White;
            this.plataformaBox.SelectedIndexChanged += (s, e) => this.ApplyFilter();

            this.estadoBox.Location = new Point(420, 10);
            this.estadoBox.Width = 150;
            this.estadoBox.Font = new Font("Segoe UI", 12);
            this.estadoBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.estadoBox.BackColor = Color.FromArgb(40, 42, 44);
            this.estadoBox.ForeColor = Color.White;
            this.estadoBox.SelectedIndexChanged += (s, e) => this.ApplyFilter();

            filters.Controls.Add(this.searchBox);
            filters.Controls.Add(this.plataformaBox);
            filters.Controls.Add(this.estadoBox);

            this.grid.Dock = DockStyle.Fill;
            this.grid.BackgroundColor = Color.FromArgb(29, 32, 34);
            this.grid.ForeColor = Color.Black;
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.ReadOnly = true;
            this.grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.RowHeadersVisible = false;
            this.grid.AutoGenerateColumns = false;
            
            this.grid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "HoraText", HeaderText = "Hora", FillWeight = 10 });
            this.grid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Plataforma", HeaderText = "Plataforma", FillWeight = 15 });
            this.grid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID", FillWeight = 10 });
            this.grid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Cliente", HeaderText = "Cliente", FillWeight = 20 });
            this.grid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Detalle", HeaderText = "Detalle", FillWeight = 30 });
            this.grid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TotalText", HeaderText = "Total", FillWeight = 10 });
            this.grid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Estado", HeaderText = "Estado", FillWeight = 15 });
            
            var editCol = new DataGridViewButtonColumn { HeaderText = "", Text = "Editar", UseColumnTextForButtonValue = true, FillWeight = 8 };
            var delCol = new DataGridViewButtonColumn { HeaderText = "", Text = "×", UseColumnTextForButtonValue = true, FillWeight = 5 };
            var advCol = new DataGridViewButtonColumn { HeaderText = "", DataPropertyName = "AccionAvanzarText", UseColumnTextForButtonValue = false, FillWeight = 15 };
            
            this.grid.Columns.Add(editCol);
            this.grid.Columns.Add(delCol);
            this.grid.Columns.Add(advCol);

            this.grid.CellFormatting += this.Grid_CellFormatting;
            this.grid.CellClick += this.Grid_CellClick;

            this.Controls.Add(this.grid);
            this.Controls.Add(filters);
            this.Controls.Add(header);

            
            
                        
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

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ComboBox plataformaBox;
        private System.Windows.Forms.ComboBox estadoBox;
    }
}



