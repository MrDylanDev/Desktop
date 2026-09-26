using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace app_escritorio.Forms
{
    partial class MesasForm
    {
        private IContainer components = null;
        private FlowLayoutPanel tablesPanel;
        private ComboBox sectorBox;
        private Label detailName;
        private Label detailStatus;
        private Label detailInfo;
        private Label detailItems;
        private Label detailTotal;
        private Button btnOpenPos;

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
            leftPanel = new Panel();
            tablesPanel = new FlowLayoutPanel();
            headerLeft = new Panel();
            lblTitle = new Label();
            btnNew = new Button();
            sectorBox = new ComboBox();
            rightPanel = new Panel();
            lblDetailTitle = new Label();
            detailName = new Label();
            detailStatus = new Label();
            detailInfo = new Label();
            detailItems = new Label();
            lblTotalText = new Label();
            detailTotal = new Label();
            btnOpenPos = new Button();
            leftPanel.SuspendLayout();
            this.sidebarControl1 = new app_escritorio.Controls.SidebarControl();
            headerLeft.SuspendLayout();
            rightPanel.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(tablesPanel);
            leftPanel.Controls.Add(headerLeft);
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(200, 100);
            leftPanel.TabIndex = 0;
            // 
            // tablesPanel
            // 
            tablesPanel.Location = new Point(0, 0);
            tablesPanel.Name = "tablesPanel";
            tablesPanel.Size = new Size(200, 100);
            tablesPanel.TabIndex = 0;
            // 
            // headerLeft
            // 
            headerLeft.Controls.Add(lblTitle);
            headerLeft.Controls.Add(btnNew);
            headerLeft.Controls.Add(sectorBox);
            headerLeft.Location = new Point(0, 0);
            headerLeft.Name = "headerLeft";
            headerLeft.Size = new Size(200, 100);
            headerLeft.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(100, 23);
            lblTitle.TabIndex = 0;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(0, 0);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 1;
            btnNew.Click += NewTable_Click;
            // 
            // sectorBox
            // 
            sectorBox.Items.AddRange(new object[] { "Todos los salones", "Principal", "Terraza", "Barra", "VIP" });
            sectorBox.Location = new Point(0, 0);
            sectorBox.Name = "sectorBox";
            sectorBox.Size = new Size(121, 23);
            sectorBox.TabIndex = 2;
            sectorBox.SelectedIndexChanged += SectorBox_SelectedIndexChanged;
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(lblDetailTitle);
            rightPanel.Controls.Add(detailName);
            rightPanel.Controls.Add(detailStatus);
            rightPanel.Controls.Add(detailInfo);
            rightPanel.Controls.Add(detailItems);
            rightPanel.Controls.Add(lblTotalText);
            rightPanel.Controls.Add(detailTotal);
            rightPanel.Controls.Add(btnOpenPos);
            rightPanel.Location = new Point(0, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(200, 100);
            rightPanel.TabIndex = 1;
            // 
            // lblDetailTitle
            // 
            lblDetailTitle.Location = new Point(0, 0);
            lblDetailTitle.Name = "lblDetailTitle";
            lblDetailTitle.Size = new Size(100, 23);
            lblDetailTitle.TabIndex = 0;
            // 
            // detailName
            // 
            detailName.Location = new Point(0, 0);
            detailName.Name = "detailName";
            detailName.Size = new Size(100, 23);
            detailName.TabIndex = 1;
            // 
            // detailStatus
            // 
            detailStatus.Location = new Point(0, 0);
            detailStatus.Name = "detailStatus";
            detailStatus.Size = new Size(100, 23);
            detailStatus.TabIndex = 2;
            // 
            // detailInfo
            // 
            detailInfo.Location = new Point(0, 0);
            detailInfo.Name = "detailInfo";
            detailInfo.Size = new Size(100, 23);
            detailInfo.TabIndex = 3;
            // 
            // detailItems
            // 
            detailItems.Location = new Point(0, 0);
            detailItems.Name = "detailItems";
            detailItems.Size = new Size(100, 23);
            detailItems.TabIndex = 4;
            // 
            // lblTotalText
            // 
            lblTotalText.Location = new Point(0, 0);
            lblTotalText.Name = "lblTotalText";
            lblTotalText.Size = new Size(100, 23);
            lblTotalText.TabIndex = 5;
            // 
            // detailTotal
            // 
            detailTotal.Location = new Point(0, 0);
            detailTotal.Name = "detailTotal";
            detailTotal.Size = new Size(100, 23);
            detailTotal.TabIndex = 6;
            // 
            // btnOpenPos
            // 
            btnOpenPos.Location = new Point(0, 0);
            btnOpenPos.Name = "btnOpenPos";
            btnOpenPos.Size = new Size(75, 23);
            btnOpenPos.TabIndex = 7;
            btnOpenPos.Click += OpenSelectedPos_Click;
            // 
            // MesasForm
            // 
            BackColor = Color.FromArgb(17, 20, 21);
            ClientSize = new Size(998, 360);
            Controls.Add(leftPanel);
            Controls.Add(rightPanel);
            ForeColor = Color.White;
            Name = "MesasForm";
            leftPanel.ResumeLayout(false);
            headerLeft.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
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
            ResumeLayout(false);
        }

        private Panel leftPanel;
        private Panel headerLeft;
        private Label lblTitle;
        private Button btnNew;
        private Panel rightPanel;
        private Label lblDetailTitle;
        private Label lblTotalText;
        private app_escritorio.Controls.SidebarControl sidebarControl1;
    }
}





