using System;
using System.Drawing;
using System.Windows.Forms;
using app_escritorio.Utils;

namespace app_escritorio.Forms
{
    partial class OrderHistoryForm
    {
        private System.ComponentModel.IContainer components = null;
        private ListView list;
        private Label summary;
        private Panel header;
        private Panel footer;
        private Button refresh;
        private Button close;

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
            this.header = new System.Windows.Forms.Panel();
            this.summary = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.ListView();
            this.footer = new System.Windows.Forms.Panel();
            this.refresh = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Height = 68;
            this.header.BackColor = app_escritorio.Utils.Theme.BackgroundMedium;
            this.header.Padding = new System.Windows.Forms.Padding(14);
            this.header.Controls.Add(this.summary);
            // 
            // summary
            // 
            this.summary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summary.Text = "";
            this.summary.Font = app_escritorio.Utils.Theme.FontTitle;
            this.summary.ForeColor = app_escritorio.Utils.Theme.TextPrimary;
            this.summary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // list
            // 
            this.list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list.View = System.Windows.Forms.View.Details;
            this.list.FullRowSelect = true;
            this.list.GridLines = true;
            this.list.BackColor = app_escritorio.Utils.Theme.BackgroundDark;
            this.list.ForeColor = app_escritorio.Utils.Theme.TextPrimary;
            this.list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list.Columns.Add("Fecha", 145);
            this.list.Columns.Add("Cliente", 180);
            this.list.Columns.Add("Mesa", 70);
            this.list.Columns.Add("Estado", 110);
            this.list.Columns.Add("Total", 100);
            this.list.Columns.Add("Productos", 280);
            // 
            // footer
            // 
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Height = 62;
            this.footer.BackColor = app_escritorio.Utils.Theme.BackgroundMedium;
            this.footer.Padding = new System.Windows.Forms.Padding(10);
            this.footer.Resize += new System.EventHandler(this.Footer_Resize);
            this.footer.Controls.Add(this.close);
            this.footer.Controls.Add(this.refresh);
            // 
            // refresh
            // 
            this.refresh.Text = "Actualizar";
            this.refresh.Width = 110;
            this.refresh.Height = 38;
            this.refresh.BackColor = app_escritorio.Utils.Theme.BackgroundLight;
            this.refresh.ForeColor = System.Drawing.Color.White;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = app_escritorio.Utils.Theme.FontSmall;
            this.refresh.FlatAppearance.BorderSize = 0;
            this.refresh.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // close
            // 
            this.close.Text = "Cerrar";
            this.close.Width = 110;
            this.close.Height = 38;
            this.close.BackColor = app_escritorio.Utils.Theme.AccentPrimary;
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = app_escritorio.Utils.Theme.FontSmall;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // OrderHistoryForm
            // 
            this.Text = "Historial de pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Size = new System.Drawing.Size(1050, 650);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.BackColor = app_escritorio.Utils.Theme.BackgroundDark;
            this.ForeColor = app_escritorio.Utils.Theme.TextPrimary;
            this.ShowInTaskbar = false;
            this.Controls.Add(this.list);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.header);
            this.ResumeLayout(false);
        }
    }
}
