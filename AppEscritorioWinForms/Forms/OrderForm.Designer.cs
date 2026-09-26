namespace app_escritorio.Forms
{
    partial class OrderForm
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
            productsPanel = new FlowLayoutPanel();
            orderLines = new ListView();
            quantityInput = new NumericUpDown();
            totalLabel = new Label();
            customerInput = new TextBox();
            tableInput = new TextBox();
            statusInput = new ComboBox();
            header = new Panel();
            search = new TextBox();
            title = new Label();
            leftPanel = new Panel();
            rightPanel = new Panel();
            orderLayout = new TableLayoutPanel();
            totalPanel = new Panel();
            actions = new FlowLayoutPanel();
            quantityLabel = new Label();
            addButton = new Button();
            removeButton = new Button();
            bottomActions = new FlowLayoutPanel();
            confirmButton = new Button();
            cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)quantityInput).BeginInit();
            header.SuspendLayout();
            leftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            orderLayout.SuspendLayout();
            totalPanel.SuspendLayout();
            actions.SuspendLayout();
            bottomActions.SuspendLayout();
            SuspendLayout();
            // 
            // productsPanel
            // 
            productsPanel.AutoScroll = true;
            productsPanel.BackColor = Color.FromArgb(17, 20, 21);
            productsPanel.Dock = DockStyle.Fill;
            productsPanel.Location = new Point(10, 10);
            productsPanel.Name = "productsPanel";
            productsPanel.Size = new Size(880, 649);
            productsPanel.TabIndex = 0;
            // 
            // orderLines
            // 
            orderLines.BackColor = Color.FromArgb(17, 20, 21);
            orderLines.Dock = DockStyle.Fill;
            orderLines.ForeColor = Color.FromArgb(225, 226, 228);
            orderLines.FullRowSelect = true;
            orderLines.GridLines = true;
            orderLines.Location = new Point(3, 3);
            orderLines.Name = "orderLines";
            orderLines.Size = new Size(444, 465);
            orderLines.TabIndex = 0;
            orderLines.UseCompatibleStateImageBehavior = false;
            orderLines.View = View.Details;
            orderLines.DoubleClick += OrderLines_DoubleClick;
            // 
            // quantityInput
            // 
            quantityInput.BackColor = Color.FromArgb(17, 20, 21);
            quantityInput.Font = new Font("Segoe UI", 8F);
            quantityInput.ForeColor = Color.FromArgb(225, 226, 228);
            quantityInput.Location = new Point(88, 10);
            quantityInput.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            quantityInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            quantityInput.Name = "quantityInput";
            quantityInput.Size = new Size(70, 22);
            quantityInput.TabIndex = 1;
            quantityInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // totalLabel
            // 
            totalLabel.Dock = DockStyle.Fill;
            totalLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            totalLabel.ForeColor = Color.FromArgb(225, 226, 228);
            totalLabel.Location = new Point(10, 10);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(424, 36);
            totalLabel.TabIndex = 0;
            totalLabel.Text = "Total: $0.00";
            totalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // customerInput
            // 
            customerInput.BackColor = Color.FromArgb(17, 20, 21);
            customerInput.Font = new Font("Segoe UI", 8F);
            customerInput.ForeColor = Color.FromArgb(225, 226, 228);
            customerInput.Location = new Point(0, 0);
            customerInput.Margin = new Padding(8, 8, 4, 4);
            customerInput.Name = "customerInput";
            customerInput.Size = new Size(150, 22);
            customerInput.TabIndex = 3;
            // 
            // tableInput
            // 
            tableInput.BackColor = Color.FromArgb(17, 20, 21);
            tableInput.Font = new Font("Segoe UI", 8F);
            tableInput.ForeColor = Color.FromArgb(225, 226, 228);
            tableInput.Location = new Point(0, 0);
            tableInput.Margin = new Padding(4, 8, 4, 4);
            tableInput.Name = "tableInput";
            tableInput.Size = new Size(100, 22);
            tableInput.TabIndex = 2;
            // 
            // statusInput
            // 
            statusInput.BackColor = Color.FromArgb(17, 20, 21);
            statusInput.DropDownStyle = ComboBoxStyle.DropDownList;
            statusInput.Font = new Font("Segoe UI", 8F);
            statusInput.ForeColor = Color.FromArgb(225, 226, 228);
            statusInput.Items.AddRange(new object[] { "Pendiente", "En curso", "Listo", "Entregado" });
            statusInput.Location = new Point(0, 0);
            statusInput.Margin = new Padding(4, 8, 8, 4);
            statusInput.Name = "statusInput";
            statusInput.Size = new Size(125, 21);
            statusInput.TabIndex = 1;
            // 
            // header
            // 
            header.BackColor = Color.FromArgb(29, 32, 34);
            header.Controls.Add(search);
            header.Controls.Add(statusInput);
            header.Controls.Add(tableInput);
            header.Controls.Add(customerInput);
            header.Controls.Add(title);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Padding = new Padding(12);
            header.Size = new Size(1370, 80);
            header.TabIndex = 2;
            // 
            // search
            // 
            search.BackColor = Color.FromArgb(17, 20, 21);
            search.Dock = DockStyle.Fill;
            search.Font = new Font("Segoe UI", 8F);
            search.ForeColor = Color.FromArgb(225, 226, 228);
            search.Location = new Point(232, 12);
            search.Margin = new Padding(8);
            search.Name = "search";
            search.Size = new Size(1126, 22);
            search.TabIndex = 0;
            search.TextChanged += search_TextChanged;
            // 
            // title
            // 
            title.Dock = DockStyle.Left;
            title.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            title.ForeColor = Color.FromArgb(225, 226, 228);
            title.Location = new Point(12, 12);
            title.Name = "title";
            title.Size = new Size(220, 56);
            title.TabIndex = 4;
            title.Text = "Crear pedido";
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.FromArgb(17, 20, 21);
            leftPanel.Controls.Add(productsPanel);
            leftPanel.Dock = DockStyle.Fill;
            leftPanel.Location = new Point(0, 80);
            leftPanel.Name = "leftPanel";
            leftPanel.Padding = new Padding(10);
            leftPanel.Size = new Size(900, 669);
            leftPanel.TabIndex = 0;
            // 
            // rightPanel
            // 
            rightPanel.BackColor = Color.FromArgb(29, 32, 34);
            rightPanel.Controls.Add(orderLayout);
            rightPanel.Dock = DockStyle.Right;
            rightPanel.Location = new Point(900, 80);
            rightPanel.Name = "rightPanel";
            rightPanel.Padding = new Padding(10);
            rightPanel.Size = new Size(470, 669);
            rightPanel.TabIndex = 1;
            // 
            // orderLayout
            // 
            orderLayout.BackColor = Color.FromArgb(29, 32, 34);
            orderLayout.ColumnCount = 1;
            orderLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            orderLayout.Controls.Add(orderLines, 0, 0);
            orderLayout.Controls.Add(totalPanel, 0, 1);
            orderLayout.Controls.Add(actions, 0, 2);
            orderLayout.Controls.Add(bottomActions, 0, 3);
            orderLayout.Dock = DockStyle.Fill;
            orderLayout.Location = new Point(10, 10);
            orderLayout.Name = "orderLayout";
            orderLayout.RowCount = 4;
            orderLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            orderLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            orderLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            orderLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            orderLayout.Size = new Size(450, 649);
            orderLayout.TabIndex = 0;
            // 
            // totalPanel
            // 
            totalPanel.BackColor = Color.FromArgb(40, 42, 44);
            totalPanel.Controls.Add(totalLabel);
            totalPanel.Dock = DockStyle.Bottom;
            totalPanel.Location = new Point(3, 474);
            totalPanel.Name = "totalPanel";
            totalPanel.Padding = new Padding(10);
            totalPanel.Size = new Size(444, 56);
            totalPanel.TabIndex = 1;
            // 
            // actions
            // 
            actions.BackColor = Color.FromArgb(40, 42, 44);
            actions.Controls.Add(quantityLabel);
            actions.Controls.Add(quantityInput);
            actions.Controls.Add(addButton);
            actions.Controls.Add(removeButton);
            actions.Dock = DockStyle.Bottom;
            actions.Location = new Point(3, 536);
            actions.Name = "actions";
            actions.Padding = new Padding(4, 7, 4, 4);
            actions.Size = new Size(444, 48);
            actions.TabIndex = 2;
            actions.WrapContents = false;
            // 
            // quantityLabel
            // 
            quantityLabel.ForeColor = Color.FromArgb(225, 191, 181);
            quantityLabel.Location = new Point(7, 7);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(75, 23);
            quantityLabel.TabIndex = 0;
            quantityLabel.Text = "Cantidad";
            quantityLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(78, 222, 163);
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(165, 11);
            addButton.Margin = new Padding(4);
            addButton.Name = "addButton";
            addButton.Size = new Size(105, 42);
            addButton.TabIndex = 2;
            addButton.Text = "Agregar";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // removeButton
            // 
            removeButton.BackColor = Color.FromArgb(89, 65, 58);
            removeButton.FlatStyle = FlatStyle.Flat;
            removeButton.ForeColor = Color.White;
            removeButton.Location = new Point(278, 11);
            removeButton.Margin = new Padding(4);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(105, 42);
            removeButton.TabIndex = 3;
            removeButton.Text = "Quitar";
            removeButton.UseVisualStyleBackColor = false;
            removeButton.Click += removeButton_Click;
            // 
            // bottomActions
            // 
            bottomActions.BackColor = Color.FromArgb(29, 32, 34);
            bottomActions.Controls.Add(confirmButton);
            bottomActions.Controls.Add(cancelButton);
            bottomActions.Dock = DockStyle.Bottom;
            bottomActions.FlowDirection = FlowDirection.RightToLeft;
            bottomActions.Location = new Point(3, 590);
            bottomActions.Name = "bottomActions";
            bottomActions.Padding = new Padding(8, 10, 8, 8);
            bottomActions.Size = new Size(444, 56);
            bottomActions.TabIndex = 3;
            bottomActions.WrapContents = false;
            // 
            // confirmButton
            // 
            confirmButton.BackColor = Color.FromArgb(240, 101, 54);
            confirmButton.FlatStyle = FlatStyle.Flat;
            confirmButton.ForeColor = Color.White;
            confirmButton.Location = new Point(204, 14);
            confirmButton.Margin = new Padding(4);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(220, 42);
            confirmButton.TabIndex = 0;
            confirmButton.Text = "Confirmar pedido";
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += confirmButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.FromArgb(89, 65, 58);
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(76, 14);
            cancelButton.Margin = new Padding(4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(120, 42);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancelar";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // OrderForm
            // 
            BackColor = Color.FromArgb(17, 20, 21);
            ClientSize = new Size(1370, 749);
            Controls.Add(leftPanel);
            Controls.Add(rightPanel);
            Controls.Add(header);
            ForeColor = Color.FromArgb(225, 226, 228);
            MinimumSize = new Size(1100, 700);
            Name = "OrderForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Crear pedido";
            ((System.ComponentModel.ISupportInitialize)quantityInput).EndInit();
            header.ResumeLayout(false);
            header.PerformLayout();
            leftPanel.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            orderLayout.ResumeLayout(false);
            totalPanel.ResumeLayout(false);
            actions.ResumeLayout(false);
            bottomActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel productsPanel;
        private System.Windows.Forms.ListView orderLines;
        private System.Windows.Forms.NumericUpDown quantityInput;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox customerInput;
        private System.Windows.Forms.TextBox tableInput;
        private System.Windows.Forms.ComboBox statusInput;
        private Panel header;
        private TextBox search;
        private Label title;
        private Panel leftPanel;
        private Panel rightPanel;
        private TableLayoutPanel orderLayout;
        private Panel totalPanel;
        private FlowLayoutPanel actions;
        private Label quantityLabel;
        private Button addButton;
        private Button removeButton;
        private FlowLayoutPanel bottomActions;
        private Button confirmButton;
        private Button cancelButton;
    }
}
