using System.Drawing;
using System.Windows.Forms;

namespace app_escritorio.Forms
{
    partial class ReservasForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private app_escritorio.Controls.SidebarControl sidebarControl1;

        private MonthCalendar calendar;
        private DataGridView grid;
        private TextBox searchBox;
        private ComboBox estadoBox;
        private Label lblFecha;
        private Panel header;
        private Label lblTitle;
        private Button btnAdd;
        private TableLayoutPanel mainPanel;
        private Panel leftPanel;
        private Label lblCal;
        private Panel rightPanel;
        private Panel filters;
        private DataGridViewTextBoxColumn horaTextCol;
        private DataGridViewTextBoxColumn clienteCol;
        private DataGridViewTextBoxColumn personasTextCol;
        private DataGridViewTextBoxColumn mesaCol;
        private DataGridViewTextBoxColumn estadoCol;
        private DataGridViewTextBoxColumn telefonoCol;
        private DataGridViewButtonColumn editCol;
        private DataGridViewButtonColumn delCol;

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
            this.header = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.lblCal = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.grid = new System.Windows.Forms.DataGridView();
            this.horaTextCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personasTextCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.filters = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.estadoBox = new System.Windows.Forms.ComboBox();
            
            this.header.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.filters.SuspendLayout();
            this.SuspendLayout();
            this.sidebarControl1 = new app_escritorio.Controls.SidebarControl();
            
            
            // 
            // header
            // 
            this.header.Controls.Add(this.lblTitle);
            this.header.Controls.Add(this.lblFecha);
            this.header.Controls.Add(this.btnAdd);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Height = 60;
            this.header.Resize += new System.EventHandler(this.Header_Resize);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(250, 5);
            this.lblTitle.Text = "Reservas";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblFecha.ForeColor = System.Drawing.Color.LightGray;
            this.lblFecha.Location = new System.Drawing.Point(420, 20);
            this.lblFecha.Text = "Hoy";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(53)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(500, 10);
            this.btnAdd.Size = new System.Drawing.Size(160, 40);
            this.btnAdd.Text = "+ Nueva reserva";
            this.btnAdd.Click += new System.EventHandler(this.Add_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 2;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Controls.Add(this.leftPanel, 0, 0);
            this.mainPanel.Controls.Add(this.rightPanel, 1, 0);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.RowCount = 1;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.calendar);
            this.leftPanel.Controls.Add(this.lblCal);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            // 
            // calendar
            // 
            this.calendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.calendar.MaxSelectionCount = 1;
            this.calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_DateChanged);
            // 
            // lblCal
            // 
            this.lblCal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCal.Height = 30;
            this.lblCal.Text = "Calendario";
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.grid);
            this.rightPanel.Controls.Add(this.filters);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AutoGenerateColumns = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.horaTextCol,
            this.clienteCol,
            this.personasTextCol,
            this.mesaCol,
            this.estadoCol,
            this.telefonoCol,
            this.editCol,
            this.delCol});
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.ForeColor = System.Drawing.Color.Black;
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellClick);
            this.grid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Grid_CellFormatting);
            // 
            // horaTextCol
            // 
            this.horaTextCol.DataPropertyName = "HoraText";
            this.horaTextCol.FillWeight = 10F;
            this.horaTextCol.HeaderText = "Hora";
            // 
            // clienteCol
            // 
            this.clienteCol.DataPropertyName = "Cliente";
            this.clienteCol.FillWeight = 25F;
            this.clienteCol.HeaderText = "Cliente";
            // 
            // personasTextCol
            // 
            this.personasTextCol.DataPropertyName = "PersonasText";
            this.personasTextCol.FillWeight = 10F;
            this.personasTextCol.HeaderText = "Pers.";
            // 
            // mesaCol
            // 
            this.mesaCol.DataPropertyName = "Mesa";
            this.mesaCol.FillWeight = 15F;
            this.mesaCol.HeaderText = "Mesa";
            // 
            // estadoCol
            // 
            this.estadoCol.DataPropertyName = "Estado";
            this.estadoCol.FillWeight = 15F;
            this.estadoCol.HeaderText = "Estado";
            // 
            // telefonoCol
            // 
            this.telefonoCol.DataPropertyName = "Telefono";
            this.telefonoCol.FillWeight = 15F;
            this.telefonoCol.HeaderText = "Tel.";
            // 
            // editCol
            // 
            this.editCol.FillWeight = 10F;
            this.editCol.HeaderText = "";
            this.editCol.Text = "Editar";
            this.editCol.UseColumnTextForButtonValue = true;
            // 
            // delCol
            // 
            this.delCol.FillWeight = 5F;
            this.delCol.HeaderText = "";
            this.delCol.Text = "×";
            this.delCol.UseColumnTextForButtonValue = true;
            // 
            // filters
            // 
            this.filters.Controls.Add(this.searchBox);
            this.filters.Controls.Add(this.estadoBox);
            this.filters.Dock = System.Windows.Forms.DockStyle.Top;
            this.filters.Height = 50;
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.searchBox.ForeColor = System.Drawing.Color.White;
            this.searchBox.Location = new System.Drawing.Point(250, 5);
            this.searchBox.Width = 250;
            this.searchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // estadoBox
            // 
            this.estadoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.estadoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.estadoBox.ForeColor = System.Drawing.Color.White;
            this.estadoBox.Location = new System.Drawing.Point(260, 5);
            this.estadoBox.Width = 180;
            this.estadoBox.SelectedIndexChanged += new System.EventHandler(this.EstadoBox_SelectedIndexChanged);
            // 
            // ReservasView
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.header);
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ForeColor = System.Drawing.Color.White;
            this.Padding = new System.Windows.Forms.Padding(20);
            
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.filters.ResumeLayout(false);
            this.filters.PerformLayout();
            
            
                        
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

        #endregion
    }
}



