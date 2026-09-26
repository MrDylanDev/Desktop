namespace app_escritorio
{
    partial class Form1
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            toolBar = new Panel();
            toolFlow = new FlowLayoutPanel();
            btnNewItem = new Button();
            btnCategories = new Button();
            btnHistory = new Button();
            spacer = new Label();
            topBar = new Panel();
            statusBar = new app_escritorio.Controls.StatusBar();
            txtSearch = new TextBox();
            mainLayout = new TableLayoutPanel();
            leftContainer = new Panel();
            flowPanel = new FlowLayoutPanel();
            categoryBar = new app_escritorio.Controls.CategoryBar();
            rightPanel = new Panel();
            toolBar.SuspendLayout();
            this.sidebarControl1 = new app_escritorio.Controls.SidebarControl();
            
            toolFlow.SuspendLayout();
            
            topBar.SuspendLayout();
            
            mainLayout.SuspendLayout();
            
            leftContainer.SuspendLayout();
            
SuspendLayout();
            
            // 
            // toolBar
            // 
            toolBar.BackColor = Color.FromArgb(45, 45, 48);
            toolBar.BorderStyle = BorderStyle.FixedSingle;
            toolBar.Controls.Add(toolFlow);
            toolBar.Dock = DockStyle.Top;
            toolBar.Location = new Point(0, 0);
            toolBar.Margin = new Padding(3, 2, 3, 2);
            toolBar.Name = "toolBar";
            toolBar.Padding = new Padding(4, 3, 4, 3);
            toolBar.Size = new Size(1199, 40);
            toolBar.TabIndex = 0;
            // 
            // toolFlow
            // 
            toolFlow.AutoScroll = true;
            toolFlow.Controls.Add(btnNewItem);
            toolFlow.Controls.Add(btnCategories);
            toolFlow.Controls.Add(btnHistory);
            toolFlow.Controls.Add(spacer);
            toolFlow.Dock = DockStyle.Fill;
            toolFlow.Location = new Point(4, 3);
            toolFlow.Margin = new Padding(3, 2, 3, 2);
            toolFlow.Name = "toolFlow";
            toolFlow.Size = new Size(1189, 32);
            toolFlow.TabIndex = 0;
            toolFlow.WrapContents = false;
            // 
            // btnNewItem
            // 
            btnNewItem.BackColor = Color.FromArgb(255, 107, 53);
            btnNewItem.FlatAppearance.BorderSize = 0;
            btnNewItem.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 107, 53);
            btnNewItem.FlatStyle = FlatStyle.Flat;
            btnNewItem.Font = new Font("Segoe UI", 10F);
            btnNewItem.ForeColor = Color.White;
            btnNewItem.Location = new Point(4, 3);
            btnNewItem.Margin = new Padding(4, 3, 4, 3);
            btnNewItem.Name = "btnNewItem";
            btnNewItem.Size = new Size(131, 27);
            btnNewItem.TabIndex = 0;
            btnNewItem.Text = "+ Nuevo plato";
            btnNewItem.UseVisualStyleBackColor = false;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = Color.FromArgb(45, 45, 48);
            btnCategories.FlatAppearance.BorderSize = 0;
            btnCategories.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 65);
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Segoe UI", 10F);
            btnCategories.ForeColor = Color.White;
            btnCategories.Location = new Point(143, 3);
            btnCategories.Margin = new Padding(4, 3, 4, 3);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(109, 27);
            btnCategories.TabIndex = 1;
            btnCategories.Text = "Categorías";
            btnCategories.UseVisualStyleBackColor = false;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.FromArgb(45, 45, 48);
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 65);
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Segoe UI", 10F);
            btnHistory.ForeColor = Color.White;
            btnHistory.Location = new Point(260, 3);
            btnHistory.Margin = new Padding(4, 3, 4, 3);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(114, 27);
            btnHistory.TabIndex = 2;
            btnHistory.Text = "Historial";
            btnHistory.UseVisualStyleBackColor = false;
            // 
            // spacer
            // 
            spacer.Location = new Point(381, 0);
            spacer.Name = "spacer";
            spacer.Size = new Size(26, 30);
            spacer.TabIndex = 3;
            // 
            // topBar
            // 
            topBar.BackColor = Color.FromArgb(45, 45, 48);
            topBar.Controls.Add(statusBar);
            topBar.Controls.Add(txtSearch);
            topBar.Dock = DockStyle.Top;
            topBar.Location = new Point(0, 40);
            topBar.Margin = new Padding(3, 2, 3, 2);
            topBar.Name = "topBar";
            topBar.Padding = new Padding(7, 3, 7, 3);
            topBar.Size = new Size(1199, 33);
            topBar.TabIndex = 1;
            // 
            // statusBar
            // 
            statusBar.BackColor = Color.FromArgb(17, 20, 21);
            statusBar.Dock = DockStyle.Left;
            statusBar.ForeColor = Color.FromArgb(225, 226, 228);
            statusBar.Location = new Point(7, 3);
            statusBar.Margin = new Padding(3, 2, 3, 2);
            statusBar.Name = "statusBar";
            statusBar.Padding = new Padding(3, 0, 3, 0);
            statusBar.Size = new Size(376, 27);
            statusBar.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(30, 30, 30);
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.ForeColor = Color.White;
            txtSearch.Location = new Point(7, 3);
            txtSearch.Margin = new Padding(4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(1185, 25);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // mainLayout
            // 
            mainLayout.BackColor = Color.FromArgb(30, 30, 30);
            mainLayout.ColumnCount = 2;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 219F));
            mainLayout.Controls.Add(leftContainer, 0, 0);
            mainLayout.Controls.Add(rightPanel, 1, 0);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 73);
            mainLayout.Margin = new Padding(0);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 1;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.Size = new Size(1199, 489);
            mainLayout.TabIndex = 2;
            // 
            // leftContainer
            // 
            leftContainer.BackColor = Color.FromArgb(30, 30, 30);
            leftContainer.Controls.Add(flowPanel);
            leftContainer.Controls.Add(categoryBar);
            leftContainer.Dock = DockStyle.Fill;
            leftContainer.Location = new Point(3, 2);
            leftContainer.Margin = new Padding(3, 2, 3, 2);
            leftContainer.Name = "leftContainer";
            leftContainer.Size = new Size(974, 485);
            leftContainer.TabIndex = 0;
            // 
            // flowPanel
            // 
            flowPanel.AllowDrop = true;
            flowPanel.AutoScroll = true;
            flowPanel.BackColor = Color.FromArgb(30, 30, 30);
            flowPanel.Dock = DockStyle.Fill;
            flowPanel.Location = new Point(0, 45);
            flowPanel.Margin = new Padding(3, 2, 3, 2);
            flowPanel.Name = "flowPanel";
            flowPanel.Padding = new Padding(9, 8, 9, 8);
            flowPanel.Size = new Size(974, 440);
            flowPanel.TabIndex = 1;
            flowPanel.SizeChanged += FlowPanel_SizeChanged;
            flowPanel.DragDrop += FlowPanel_DragDrop;
            flowPanel.DragEnter += FlowPanel_DragEnter;
            // 
            // categoryBar
            // 
            categoryBar.BackColor = Color.FromArgb(17, 20, 21);
            categoryBar.Dock = DockStyle.Top;
            categoryBar.ForeColor = Color.FromArgb(225, 226, 228);
            categoryBar.Location = new Point(0, 0);
            categoryBar.Margin = new Padding(3, 2, 3, 2);
            categoryBar.Name = "categoryBar";
            categoryBar.Padding = new Padding(9, 2, 9, 2);
            categoryBar.Size = new Size(974, 45);
            categoryBar.TabIndex = 0;
            // 
            // rightPanel
            // 
            rightPanel.AutoScroll = true;
            rightPanel.BackColor = Color.FromArgb(45, 45, 48);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(983, 2);
            rightPanel.Margin = new Padding(3, 2, 3, 2);
            rightPanel.Name = "rightPanel";
            rightPanel.Padding = new Padding(9, 8, 9, 8);
            rightPanel.Size = new Size(213, 485);
            rightPanel.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1199, 562);
            Controls.Add(mainLayout);
            Controls.Add(topBar);
            Controls.Add(toolBar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editor de Carta y Pedidos";
            Load += Form1_Load;
            toolBar.ResumeLayout(false);
            toolFlow.ResumeLayout(false);
            topBar.ResumeLayout(false);
            topBar.PerformLayout();
            mainLayout.ResumeLayout(false);
            leftContainer.ResumeLayout(false);
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

        #endregion

        private System.Windows.Forms.Panel toolBar;
        private System.Windows.Forms.FlowLayoutPanel toolFlow;
        private System.Windows.Forms.Button btnNewItem;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Label spacer;
        private System.Windows.Forms.Panel topBar;
        private app_escritorio.Controls.StatusBar statusBar;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Panel leftContainer;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private app_escritorio.Controls.CategoryBar categoryBar;
        private System.Windows.Forms.Panel rightPanel;
    }
}



