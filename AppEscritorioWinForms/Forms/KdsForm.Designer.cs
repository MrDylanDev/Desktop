namespace app_escritorio.Forms
{
    partial class KdsForm
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
            if (disposing) _timer?.Dispose();
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
            this.lblPendingCount = new System.Windows.Forms.Label();
            this.stationBox = new System.Windows.Forms.ComboBox();
            this.lblClock = new System.Windows.Forms.Label();
            this.tablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.pnlNuevo = new System.Windows.Forms.Panel();
            this.headerNuevo = new System.Windows.Forms.Panel();
            this.lblTitleNuevo = new System.Windows.Forms.Label();
            this.lblNuevoCount = new System.Windows.Forms.Label();
            this.listNuevo = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlPrep = new System.Windows.Forms.Panel();
            this.headerPrep = new System.Windows.Forms.Panel();
            this.lblTitlePrep = new System.Windows.Forms.Label();
            this.lblPrepCount = new System.Windows.Forms.Label();
            this.listPrep = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlListo = new System.Windows.Forms.Panel();
            this.headerListo = new System.Windows.Forms.Panel();
            this.lblTitleListo = new System.Windows.Forms.Label();
            this.lblListoCount = new System.Windows.Forms.Label();
            this.listListo = new System.Windows.Forms.FlowLayoutPanel();
            
            this.header.SuspendLayout();
            this.tablePanel.SuspendLayout();
            
            this.pnlNuevo.SuspendLayout();
            this.headerNuevo.SuspendLayout();
            
            this.pnlPrep.SuspendLayout();
            this.headerPrep.SuspendLayout();
            
            this.pnlListo.SuspendLayout();
            this.headerListo.SuspendLayout();
            
            this.SuspendLayout();
            this.sidebarControl1 = new app_escritorio.Controls.SidebarControl();
            
            
            // 
            // header
            // 
            this.header.Controls.Add(this.lblTitle);
            this.header.Controls.Add(this.lblPendingCount);
            this.header.Controls.Add(this.stationBox);
            this.header.Controls.Add(this.lblClock);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Height = 60;
            this.header.Name = "header";
            this.header.Resize += new System.EventHandler(this.Header_Resize);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(260, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Cocina KDS";
            // 
            // lblPendingCount
            // 
            this.lblPendingCount.AutoSize = true;
            this.lblPendingCount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPendingCount.ForeColor = System.Drawing.Color.LightGray;
            this.lblPendingCount.Location = new System.Drawing.Point(470, 20);
            this.lblPendingCount.Name = "lblPendingCount";
            this.lblPendingCount.Text = "0 pendientes";
            // 
            // stationBox
            // 
            this.stationBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.stationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stationBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.stationBox.ForeColor = System.Drawing.Color.White;
            this.stationBox.Location = new System.Drawing.Point(360, 20);
            this.stationBox.Name = "stationBox";
            this.stationBox.Width = 180;
            // 
            // lblClock
            // 
            this.lblClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.lblClock.Name = "lblClock";
            this.lblClock.Text = "00:00:00";
            // 
            // tablePanel
            // 
            this.tablePanel.ColumnCount = 3;
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tablePanel.Controls.Add(this.pnlNuevo, 0, 0);
            this.tablePanel.Controls.Add(this.pnlPrep, 1, 0);
            this.tablePanel.Controls.Add(this.pnlListo, 2, 0);
            this.tablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.RowCount = 1;
            // 
            // pnlNuevo
            // 
            this.pnlNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.pnlNuevo.Controls.Add(this.listNuevo);
            this.pnlNuevo.Controls.Add(this.headerNuevo);
            this.pnlNuevo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNuevo.Margin = new System.Windows.Forms.Padding(10);
            this.pnlNuevo.Padding = new System.Windows.Forms.Padding(10);
            this.pnlNuevo.Name = "pnlNuevo";
            // 
            // headerNuevo
            // 
            this.headerNuevo.Controls.Add(this.lblTitleNuevo);
            this.headerNuevo.Controls.Add(this.lblNuevoCount);
            this.headerNuevo.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerNuevo.Height = 40;
            this.headerNuevo.Name = "headerNuevo";
            this.headerNuevo.Resize += new System.EventHandler(this.HeaderNuevo_Resize);
            // 
            // lblTitleNuevo
            // 
            this.lblTitleNuevo.AutoSize = true;
            this.lblTitleNuevo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitleNuevo.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblTitleNuevo.Location = new System.Drawing.Point(260, 5);
            this.lblTitleNuevo.Name = "lblTitleNuevo";
            this.lblTitleNuevo.Text = "Nuevo";
            // 
            // lblNuevoCount
            // 
            this.lblNuevoCount.AutoSize = true;
            this.lblNuevoCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNuevoCount.Location = new System.Drawing.Point(250, 5);
            this.lblNuevoCount.Name = "lblNuevoCount";
            this.lblNuevoCount.Text = "0";
            // 
            // listNuevo
            // 
            this.listNuevo.AutoScroll = true;
            this.listNuevo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listNuevo.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.listNuevo.Name = "listNuevo";
            this.listNuevo.WrapContents = false;
            this.listNuevo.Resize += new System.EventHandler(this.List_Resize);
            // 
            // pnlPrep
            // 
            this.pnlPrep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.pnlPrep.Controls.Add(this.listPrep);
            this.pnlPrep.Controls.Add(this.headerPrep);
            this.pnlPrep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrep.Margin = new System.Windows.Forms.Padding(10);
            this.pnlPrep.Padding = new System.Windows.Forms.Padding(10);
            this.pnlPrep.Name = "pnlPrep";
            // 
            // headerPrep
            // 
            this.headerPrep.Controls.Add(this.lblTitlePrep);
            this.headerPrep.Controls.Add(this.lblPrepCount);
            this.headerPrep.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPrep.Height = 40;
            this.headerPrep.Name = "headerPrep";
            this.headerPrep.Resize += new System.EventHandler(this.HeaderPrep_Resize);
            // 
            // lblTitlePrep
            // 
            this.lblTitlePrep.AutoSize = true;
            this.lblTitlePrep.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitlePrep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(53)))));
            this.lblTitlePrep.Location = new System.Drawing.Point(260, 5);
            this.lblTitlePrep.Name = "lblTitlePrep";
            this.lblTitlePrep.Text = "En preparación";
            // 
            // lblPrepCount
            // 
            this.lblPrepCount.AutoSize = true;
            this.lblPrepCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPrepCount.Location = new System.Drawing.Point(250, 5);
            this.lblPrepCount.Name = "lblPrepCount";
            this.lblPrepCount.Text = "0";
            // 
            // listPrep
            // 
            this.listPrep.AutoScroll = true;
            this.listPrep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPrep.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.listPrep.Name = "listPrep";
            this.listPrep.WrapContents = false;
            this.listPrep.Resize += new System.EventHandler(this.List_Resize);
            // 
            // pnlListo
            // 
            this.pnlListo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.pnlListo.Controls.Add(this.listListo);
            this.pnlListo.Controls.Add(this.headerListo);
            this.pnlListo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListo.Margin = new System.Windows.Forms.Padding(10);
            this.pnlListo.Padding = new System.Windows.Forms.Padding(10);
            this.pnlListo.Name = "pnlListo";
            // 
            // headerListo
            // 
            this.headerListo.Controls.Add(this.lblTitleListo);
            this.headerListo.Controls.Add(this.lblListoCount);
            this.headerListo.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerListo.Height = 40;
            this.headerListo.Name = "headerListo";
            this.headerListo.Resize += new System.EventHandler(this.HeaderListo_Resize);
            // 
            // lblTitleListo
            // 
            this.lblTitleListo.AutoSize = true;
            this.lblTitleListo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitleListo.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblTitleListo.Location = new System.Drawing.Point(260, 5);
            this.lblTitleListo.Name = "lblTitleListo";
            this.lblTitleListo.Text = "Listo";
            // 
            // lblListoCount
            // 
            this.lblListoCount.AutoSize = true;
            this.lblListoCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblListoCount.Location = new System.Drawing.Point(250, 5);
            this.lblListoCount.Name = "lblListoCount";
            this.lblListoCount.Text = "0";
            // 
            // listListo
            // 
            this.listListo.AutoScroll = true;
            this.listListo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listListo.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.listListo.Name = "listListo";
            this.listListo.WrapContents = false;
            this.listListo.Resize += new System.EventHandler(this.List_Resize);
            // 
            // KdsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.header);
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "KdsView";
            this.ClientSize = new System.Drawing.Size(1550, 900);
            
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.tablePanel.ResumeLayout(false);
            
            this.pnlNuevo.ResumeLayout(false);
            this.headerNuevo.ResumeLayout(false);
            this.headerNuevo.PerformLayout();
            
            this.pnlPrep.ResumeLayout(false);
            this.headerPrep.ResumeLayout(false);
            this.headerPrep.PerformLayout();
            
            this.pnlListo.ResumeLayout(false);
            this.headerListo.ResumeLayout(false);
            this.headerListo.PerformLayout();
            
            
            
                        
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

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tablePanel;

        private System.Windows.Forms.Panel pnlNuevo;
        private System.Windows.Forms.Panel headerNuevo;
        private System.Windows.Forms.Label lblTitleNuevo;

        private System.Windows.Forms.Panel pnlPrep;
        private System.Windows.Forms.Panel headerPrep;
        private System.Windows.Forms.Label lblTitlePrep;

        private System.Windows.Forms.Panel pnlListo;
        private System.Windows.Forms.Panel headerListo;
        private System.Windows.Forms.Label lblTitleListo;
        
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Label lblPendingCount;
        private System.Windows.Forms.ComboBox stationBox;
        private System.Windows.Forms.FlowLayoutPanel listNuevo;
        private System.Windows.Forms.FlowLayoutPanel listPrep;
        private System.Windows.Forms.FlowLayoutPanel listListo;
        private System.Windows.Forms.Label lblNuevoCount;
        private System.Windows.Forms.Label lblPrepCount;
        private System.Windows.Forms.Label lblListoCount;
    }
}



