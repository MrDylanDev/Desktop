using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_escritorio
{
    public partial class Form1 : Form
    {
        private app_escritorio.Controls.CategoryBar categoryBar;
        private FlowLayoutPanel flowPanel;
        private Panel rightPanel;
        private TextBox txtSearch;
        private app_escritorio.Controls.StatusBar statusBar;
        private string dataFile = "data/menu.xml";
        private app_escritorio.Data.MenuData menuData;
        private Guid? currentSelectedCategoryId = null;
        private app_escritorio.Models.MenuItem _editingItem;

        public Form1()
        {
            InitializeComponent();
            BuildUi();
            this.Load += Form1_Load;
        }

        private void BuildUi()
        {
            this.Text = "Editor de Carta y Pedidos";
            this.BackColor = app_escritorio.Utils.Theme.BackgroundDark;
            this.Size = new Size(1500, 950);
            this.StartPosition = FormStartPosition.CenterScreen;

            // ========== TOOLBAR (Top Level 1) ==========
            var toolBar = new Panel 
            { 
                Dock = DockStyle.Top, 
                Height = 52, 
                BackColor = app_escritorio.Utils.Theme.BackgroundMedium,
                Padding = new Padding(4),
                BorderStyle = BorderStyle.FixedSingle
            };

            var toolFlow = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                WrapContents = false,
                AutoScroll = true
            };

            // Toolbar buttons (misma estructura que las páginas WPF: 36px, un primario, resto secundarios)
            var btnNewItem = CreateToolbarButton("+ Nuevo plato", 150, true);
            btnNewItem.Click += (s, e) => BtnNewItem_Click();

            var btnCategories = CreateToolbarButton("Categorías", 125);
            btnCategories.Click += (s, e) => ManageCategories();

            var btnHistory = CreateToolbarButton("Historial", 130);
            btnHistory.Click += (s, e) => OpenOrderHistory();

            toolFlow.Controls.Add(btnNewItem);
            toolFlow.Controls.Add(btnCategories);
            toolFlow.Controls.Add(btnHistory);

            var spacer = new Label { Width = 30, Height = 40 };
            toolFlow.Controls.Add(spacer);

            toolBar.Controls.Add(toolFlow);

            // ========== TOP BAR (Top Level 2): SEARCH + SAVE ==========
            var topBar = new Panel 
            { 
                Dock = DockStyle.Top, 
                Height = 44, 
                BackColor = app_escritorio.Utils.Theme.BackgroundMedium,
                Padding = new Padding(8, 4, 8, 4)
            };

            txtSearch = new TextBox 
            { 
                Dock = DockStyle.Fill,
                Font = app_escritorio.Utils.Theme.FontSmall,
                BackColor = app_escritorio.Utils.Theme.BackgroundDark,
                ForeColor = app_escritorio.Utils.Theme.TextPrimary,
                Margin = new Padding(5)
            };
            txtSearch.TextChanged += (s, e) => ApplySearch();

            statusBar = new app_escritorio.Controls.StatusBar { Dock = DockStyle.Fill, Width = 430, Height = 34, Padding = new Padding(3, 0, 3, 0) };
            topBar.Controls.Add(statusBar);
            topBar.Controls.Add(txtSearch);

            // ========== CATEGORY BAR ==========
            categoryBar = new app_escritorio.Controls.CategoryBar();
            categoryBar.CategorySelected += CategoryBar_CategorySelected;

            // ========== MAIN FLOW PANEL ==========
            flowPanel = new FlowLayoutPanel 
            { 
                Dock = DockStyle.Fill, 
                AutoScroll = true, 
                WrapContents = true,
                BackColor = app_escritorio.Utils.Theme.BackgroundDark,
                Padding = new Padding(10)
            };
            flowPanel.AllowDrop = true;
            flowPanel.DragEnter += FlowPanel_DragEnter;
            flowPanel.DragDrop += FlowPanel_DragDrop;
            flowPanel.SizeChanged += (s, e) => FitCardsToWidth();

            // ========== RIGHT EDITOR PANEL ==========
            rightPanel = new Panel 
            { 
                Dock = DockStyle.Right, 
                Width = 250, 
                BackColor = app_escritorio.Utils.Theme.BackgroundMedium,
                Padding = new Padding(10),
                AutoScroll = true
            };

            var leftContainer = new Panel { Dock = DockStyle.Fill, BackColor = app_escritorio.Utils.Theme.BackgroundDark };
            leftContainer.Controls.Add(flowPanel);
            leftContainer.Controls.Add(categoryBar);

            var mainLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 1,
                BackColor = app_escritorio.Utils.Theme.BackgroundDark,
                Padding = new Padding(0)
            };
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            mainLayout.Controls.Add(leftContainer, 0, 0);
            mainLayout.Controls.Add(rightPanel, 1, 0);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Width = 250;

            this.Controls.Add(mainLayout);
            this.Controls.Add(topBar);
            this.Controls.Add(toolBar);
        }

        private Button CreateToolbarButton(string text, int width, bool primary = false)
        {
            var back = primary ? app_escritorio.Utils.Theme.ButtonPrimary : app_escritorio.Utils.Theme.BackgroundMedium;
            var fore = primary ? app_escritorio.Utils.Theme.ButtonPrimaryText : System.Drawing.Color.White;
            var button = new Button
            {
                Text = text,
                Width = width,
                Height = 36,
                Font = app_escritorio.Utils.Theme.FontSmall,
                BackColor = back,
                ForeColor = fore,
                FlatStyle = FlatStyle.Flat,
                Margin = new Padding(4)
            };
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseOverBackColor = primary ? app_escritorio.Utils.Theme.ButtonPrimary : app_escritorio.Utils.Theme.BackgroundLight;
            button.Region = new Region(RoundedRect(new Rectangle(0, 0, width, 36), 16));
            return button;
        }

        private static System.Drawing.Drawing2D.GraphicsPath RoundedRect(Rectangle rect, int diameter)
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load menu data
            try
            {
                menuData = app_escritorio.Data.MenuStore.Load(dataFile);
                if ((menuData.Categories == null || menuData.Categories.Count == 0) && (menuData.Items == null || menuData.Items.Count == 0))
                {
                    menuData = app_escritorio.Data.MenuStore.SampleData();
                }
            }
            catch
            {
                menuData = app_escritorio.Data.MenuStore.SampleData();
            }

            if (menuData.Categories == null) menuData.Categories = new List<app_escritorio.Models.Category>();
            if (menuData.Items == null) menuData.Items = new List<app_escritorio.Models.MenuItem>();

            var entradas = menuData.Categories.FirstOrDefault(c => c.Name == "Entradas y Tapas");
            if (entradas != null) entradas.Name = "Entradas";

            if (!menuData.Categories.Any(c => c.Name == "Entradas"))
                menuData.Categories.Add(new app_escritorio.Models.Category { Name = "Entradas", Position = 0 });

            if (!menuData.Categories.Any(c => c.Name == "Bebidas"))
                menuData.Categories.Add(new app_escritorio.Models.Category { Name = "Bebidas", Position = menuData.Categories.Count });

            // Setup category bar
            categoryBar.SetCategories(menuData.Categories);

            // Populate cards
            PopulateCards(null);  // null = show all

            // Panel derecho con estado inicial útil (no vacío)
            ShowEmptyEditor();
        }

        private void CategoryBar_CategorySelected(object sender, app_escritorio.Controls.CategorySelectedEventArgs e)
        {
            currentSelectedCategoryId = e.SelectedCategoryId;
            PopulateCards(e.SelectedCategoryId);
        }

        private void PopulateCards(Guid? categoryId)
        {
            flowPanel.Controls.Clear();

            var itemsToShow = (categoryId == null 
                ? menuData.Items 
                : menuData.Items.Where(i => i.CategoryId == categoryId).ToList())
                .OrderBy(i => i.CategoryId)
                .ThenBy(i => i.Position)
                .ToList();

            foreach (var item in itemsToShow)
            {
                var card = new app_escritorio.Controls.MenuCard();
                card.SetData(item);
                card.EditRequested += Card_EditRequested;
                card.DeleteRequested += Card_DeleteRequested;
                card.AllowDrop = true;
                flowPanel.Controls.Add(card);
            }
            if (statusBar != null) statusBar.SetItems(itemsToShow);
            FitCardsToWidth();
        }

        /// <summary>
        /// Grilla responsiva: calcula cuántas columnas caben y reparte el ancho
        /// para que ninguna tarjeta (ni sus botones) quede cortada por mitad.
        /// </summary>
        private int _lastFitWidth = -1;

        private void FitCardsToWidth()
        {
            if (flowPanel == null || flowPanel.IsDisposed) return;
            int avail = flowPanel.ClientSize.Width - flowPanel.Padding.Horizontal - 20;
            if (avail < 180) avail = 180;
            if (System.Math.Abs(avail - _lastFitWidth) < 4) return;
            _lastFitWidth = avail;
            int cols = System.Math.Max(1, (int)System.Math.Round(avail / 262.0));
            while (cols > 1 && (avail - (cols - 1) * 12) / cols < 180) cols--;
            int w = (avail - (cols - 1) * 12) / cols;
            flowPanel.SuspendLayout();
            foreach (var card in flowPanel.Controls.OfType<app_escritorio.Controls.MenuCard>()) card.SetCardWidth(w);
            flowPanel.ResumeLayout(true);
        }

        private void Card_EditRequested(object sender, EventArgs e)
        {
            var card = sender as app_escritorio.Controls.MenuCard;
            if (card == null) return;
            ShowEditorFor(card.Item, false);
        }

        private void Card_DeleteRequested(object sender, EventArgs e)
        {
            var card = sender as app_escritorio.Controls.MenuCard;
            if (card == null || card.Item == null) return;
            if (MessageBox.Show("¿Eliminar '" + card.Item.Name + "' de la carta?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            menuData.Items.Remove(card.Item);
            foreach (var category in menuData.Categories) category.ItemIds.Remove(card.Item.Id);
            SaveMenu();
            PopulateCards(currentSelectedCategoryId);
            if (ReferenceEquals(_editingItem, card.Item)) ShowEmptyEditor();
        }

        /// <summary>
        /// Estado inicial del panel derecho: guía + resumen + accesos directos,
        /// en vez del hueco vacío hasta el primer Editar.
        /// </summary>
        private void ShowEmptyEditor()
        {
            rightPanel.Controls.Clear();
            _editingItem = null;

            int dishes = menuData != null && menuData.Items != null ? menuData.Items.Count : 0;
            int cats = menuData != null && menuData.Categories != null ? menuData.Categories.Count : 0;
            int avail = 0;
            if (menuData != null && menuData.Items != null)
            {
                foreach (var it in menuData.Items) if (it != null && it.IsAvailable) avail++;
            }

            var btnNew = CreateEditorButton("+ Nuevo plato", 210, app_escritorio.Utils.Theme.AccentSecondary, app_escritorio.Utils.Theme.TertiaryText);
            btnNew.Dock = DockStyle.Top;
            btnNew.Click += (s, e) => BtnNewItem_Click();
            var btnCats = CreateEditorButton("Categorías", 210, app_escritorio.Utils.Theme.BackgroundLight);
            btnCats.Dock = DockStyle.Top;
            btnCats.Click += (s, e) => ManageCategories();
            var stats = new Label
            {
                Text = string.Format("{0} platos · {1} categorías · {2} disponibles", dishes, cats, avail),
                Dock = DockStyle.Top,
                Height = 30,
                ForeColor = app_escritorio.Utils.Theme.TextSecondary,
                Font = app_escritorio.Utils.Theme.FontSmall,
                Margin = new Padding(5, 2, 5, 8)
            };
            var hint = new Label
            {
                Text = "Selecciona un plato de la carta para verlo y editarlo aquí.\n\nTambién puedes crear uno nuevo o administrar las categorías.",
                Dock = DockStyle.Top,
                Height = 110,
                ForeColor = app_escritorio.Utils.Theme.TextSecondary,
                Font = app_escritorio.Utils.Theme.FontSmall,
                Margin = new Padding(5, 2, 5, 8)
            };
            var title = new Label { Text = "Editor", Dock = DockStyle.Top, Height = 42, Font = app_escritorio.Utils.Theme.FontTitle, ForeColor = app_escritorio.Utils.Theme.TextPrimary, Padding = new Padding(4, 10, 4, 4) };

            rightPanel.Controls.Add(btnNew);
            rightPanel.Controls.Add(btnCats);
            rightPanel.Controls.Add(stats);
            rightPanel.Controls.Add(hint);
            rightPanel.Controls.Add(title);
        }

        private void ShowEditorFor(app_escritorio.Models.MenuItem item, bool isNew)
        {
            rightPanel.Controls.Clear();
            _editingItem = isNew ? null : item;
            if (item == null) return;

            var title = new Label { Text = isNew ? "Nuevo plato" : "Editar plato", Dock = DockStyle.Fill, Font = app_escritorio.Utils.Theme.FontTitle, ForeColor = app_escritorio.Utils.Theme.TextPrimary, Padding = new Padding(4, 10, 4, 4), TextAlign = ContentAlignment.MiddleLeft };
            var btnClose = new Button
            {
                Text = "×",
                Dock = DockStyle.Right,
                Width = 44,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                ForeColor = app_escritorio.Utils.Theme.TextSecondary,
                BackColor = app_escritorio.Utils.Theme.BackgroundMedium,
                Margin = new Padding(0)
            };
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Click += (s, e) => ShowEmptyEditor();
            var header = new Panel { Dock = DockStyle.Top, Height = 42, BackColor = app_escritorio.Utils.Theme.BackgroundMedium };
            header.Controls.Add(title);
            header.Controls.Add(btnClose);
            var image = new PictureBox { Dock = DockStyle.Top, Height = 145, SizeMode = PictureBoxSizeMode.Zoom, BackColor = app_escritorio.Utils.Theme.BackgroundDark, Margin = new Padding(5) };
            var btnImage = CreateEditorButton("📷 Elegir foto", 130, app_escritorio.Utils.Theme.BackgroundLight);
            btnImage.Click += (s, e) =>
            {
                using (var dialog = new OpenFileDialog { Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp|Todos|*.*", Title = "Seleccionar foto del plato" })
                {
                    if (dialog.ShowDialog(this) == DialogResult.OK)
                    {
                        item.ImageUrl = dialog.FileName;
                        LoadEditorImage(image, item.ImageUrl);
                    }
                }
            };

            var imagePanel = new Panel { Dock = DockStyle.Top, Height = 185, Padding = new Padding(5), BackColor = app_escritorio.Utils.Theme.BackgroundMedium };
            imagePanel.Controls.Add(btnImage);
            imagePanel.Controls.Add(image);
            btnImage.Dock = DockStyle.Bottom;
            btnImage.Height = 32;

            var lblCategory = CreateEditorLabel("Categoría");
            var categoryBox = new ComboBox { Dock = DockStyle.Top, Height = 28, DropDownStyle = ComboBoxStyle.DropDownList, Font = app_escritorio.Utils.Theme.FontSmall, BackColor = app_escritorio.Utils.Theme.BackgroundDark, ForeColor = app_escritorio.Utils.Theme.TextPrimary, Margin = new Padding(5, 2, 5, 8) };
            foreach (var category in menuData.Categories.OrderBy(c => c.Position)) { categoryBox.Items.Add(category); }
            categoryBox.SelectedItem = menuData.Categories.FirstOrDefault(c => c.Id == item.CategoryId);
            if (categoryBox.SelectedItem == null && categoryBox.Items.Count > 0) categoryBox.SelectedIndex = 0;
            categoryBox.DisplayMember = "Name";

            var lblName = CreateEditorLabel("Nombre");
            var txtName = CreateEditorTextBox(item.Name, 28);
            var lblDesc = CreateEditorLabel("Descripción");
            var txtDesc = CreateEditorTextBox(item.Description, 58);
            txtDesc.Multiline = true;
            var lblTags = CreateEditorLabel("Etiquetas (separadas por coma)");
            var txtTags = CreateEditorTextBox(item.Tags == null ? "" : string.Join(", ", item.Tags), 28);

            var lblPrice = CreateEditorLabel("Precio salón ($)");
            var txtPrice = CreateEditorTextBox(item.PriceSalon.ToString("0.##", System.Globalization.CultureInfo.InvariantCulture), 28);
            var lblDelivery = CreateEditorLabel("Precio delivery ($)");
            var txtDelivery = CreateEditorTextBox(item.PriceDelivery.ToString("0.##", System.Globalization.CultureInfo.InvariantCulture), 28);
            var lblStock = CreateEditorLabel("Stock (-1 = ilimitado)");
            var txtStock = CreateEditorTextBox(item.Stock.ToString(System.Globalization.CultureInfo.InvariantCulture), 28);
            var available = new CheckBox { Text = "Disponible en el menú", Checked = item.IsAvailable, Dock = DockStyle.Top, Height = 30, ForeColor = app_escritorio.Utils.Theme.TextPrimary, Font = app_escritorio.Utils.Theme.FontSmall, Margin = new Padding(5) };

            var btnSave = CreateEditorButton(isNew ? "Agregar a la carta" : "Guardar cambios del plato", 210, app_escritorio.Utils.Theme.AccentSecondary, app_escritorio.Utils.Theme.TertiaryText);
            btnSave.Click += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtName.Text)) { MessageBox.Show("Escribe un nombre para el plato.", "Falta información"); txtName.Focus(); return; }
                decimal priceSalon, priceDelivery;
                int stock;
                if (!TryParseMoney(txtPrice.Text, out priceSalon)) { MessageBox.Show("Precio de salón inválido. Ejemplo: 20000", "Falta información"); txtPrice.Focus(); return; }
                if (!TryParseMoney(txtDelivery.Text, out priceDelivery)) { MessageBox.Show("Precio de delivery inválido. Ejemplo: 23000", "Falta información"); txtDelivery.Focus(); return; }
                if (!int.TryParse((txtStock.Text ?? "").Trim(), out stock) || stock < -1) { MessageBox.Show("Stock inválido. Usa -1 para ilimitado.", "Falta información"); txtStock.Focus(); return; }
                var selectedCategory = categoryBox.SelectedItem as app_escritorio.Models.Category;
                item.Name = txtName.Text.Trim();
                item.Description = txtDesc.Text.Trim();
                item.CategoryId = selectedCategory == null ? item.CategoryId : selectedCategory.Id;
                item.PriceSalon = priceSalon;
                item.PriceDelivery = priceDelivery;
                item.Stock = stock;
                item.IsAvailable = available.Checked;
                item.Tags = (txtTags.Text ?? "").Split(',').Select(t => t.Trim()).Where(t => t.Length > 0).ToList();
                if (item.Variants == null) item.Variants = new List<app_escritorio.Models.MenuVariant>();
                if (item.Tags == null) item.Tags = new List<string>();
                if (item.DietaryFilters == null) item.DietaryFilters = new List<string>();
                if (isNew) menuData.Items.Add(item);
                SaveMenu();
                categoryBar.SetCategories(menuData.Categories);
                PopulateCards(currentSelectedCategoryId);
            };
            var btnDelete = CreateEditorButton("Eliminar plato", 210, app_escritorio.Utils.Theme.DangerBackground, app_escritorio.Utils.Theme.StatusUnavailable);
            btnDelete.Visible = !isNew;
            btnDelete.Click += (s, e) =>
            {
                if (MessageBox.Show("¿Eliminar este plato de la carta?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
                menuData.Items.Remove(item);
                foreach (var category in menuData.Categories) category.ItemIds.Remove(item.Id);
                SaveMenu();
                PopulateCards(currentSelectedCategoryId);
                ShowEmptyEditor();
            };
            var actions = new FlowLayoutPanel
            {
                Dock = DockStyle.Bottom,
                Height = 84,
                Width = 210,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                AutoScroll = false,
                Padding = new Padding(3)
            };
            actions.Controls.Add(btnSave);
            actions.Controls.Add(btnDelete);

            rightPanel.Controls.Add(actions);
            rightPanel.Controls.Add(available);
            rightPanel.Controls.Add(txtStock);
            rightPanel.Controls.Add(lblStock);
            rightPanel.Controls.Add(txtDelivery);
            rightPanel.Controls.Add(lblDelivery);
            rightPanel.Controls.Add(txtPrice);
            rightPanel.Controls.Add(lblPrice);
            rightPanel.Controls.Add(txtTags);
            rightPanel.Controls.Add(lblTags);
            rightPanel.Controls.Add(txtDesc);
            rightPanel.Controls.Add(lblDesc);
            rightPanel.Controls.Add(txtName);
            rightPanel.Controls.Add(lblName);
            rightPanel.Controls.Add(categoryBox);
            rightPanel.Controls.Add(lblCategory);
            rightPanel.Controls.Add(imagePanel);
            rightPanel.Controls.Add(header);
            LoadEditorImage(image, item.ImageUrl);
        }

        private static Label CreateEditorLabel(string text)
        {
            return new Label { Text = text, Dock = DockStyle.Top, Height = 20, ForeColor = app_escritorio.Utils.Theme.TextSecondary, Font = app_escritorio.Utils.Theme.FontSmall, Margin = new Padding(5, 2, 5, 0) };
        }

        private static TextBox CreateEditorTextBox(string text, int height)
        {
            return new TextBox { Text = text ?? "", Dock = DockStyle.Top, Height = height, Font = app_escritorio.Utils.Theme.FontSmall, BackColor = app_escritorio.Utils.Theme.BackgroundDark, ForeColor = app_escritorio.Utils.Theme.TextPrimary, Margin = new Padding(5, 2, 5, 5) };
        }

        private static bool TryParseMoney(string raw, out decimal value)
        {
            value = 0;
            string t = (raw ?? "").Trim().Replace("$", "").Replace(" ", "").Replace(",", ".");
            return decimal.TryParse(t, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out value) && value >= 0;
        }

        private static Button CreateEditorButton(string text, int width, Color color, Color? foreColor = null)
        {
            var button = new Button { Text = text, Width = width, Height = 34, BackColor = color, ForeColor = foreColor ?? Color.White, FlatStyle = FlatStyle.Flat, Font = app_escritorio.Utils.Theme.FontSmall, Margin = new Padding(3) };
            button.FlatAppearance.BorderSize = 0;
            return button;
        }

        private static void LoadEditorImage(PictureBox picture, string path)
        {
            picture.Image = null;
            try
            {
                if (!string.IsNullOrEmpty(path) && File.Exists(path)) using (var source = Image.FromFile(path)) picture.Image = new Bitmap(source);
            }
            catch { picture.Image = null; }
        }

        private void SaveMenu()
        {
            try
            {
                app_escritorio.Data.MenuStore.Save(dataFile, menuData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplySearch()
        {
            var q = txtSearch.Text?.ToLower() ?? "";
            foreach (app_escritorio.Controls.MenuCard card in flowPanel.Controls.OfType<app_escritorio.Controls.MenuCard>())
            {
                if (card.Item == null)
                {
                    card.Visible = true;
                    continue;
                }

                var name = card.Item.Name ?? "";
                var desc = card.Item.Description ?? "";
                card.Visible = string.IsNullOrEmpty(q) || name.ToLower().Contains(q) || desc.ToLower().Contains(q);
            }
        }

        private void FlowPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(nameof(app_escritorio.Controls.MenuCard)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void FlowPanel_DragDrop(object sender, DragEventArgs e)
        {
            var clientPoint = flowPanel.PointToClient(new Point(e.X, e.Y));
            var dragged = e.Data.GetData(nameof(app_escritorio.Controls.MenuCard)) as app_escritorio.Controls.MenuCard;
            if (dragged == null) return;

            // Find index at drop position
            int insertIndex = flowPanel.Controls.Count;
            for (int i = 0; i < flowPanel.Controls.Count; i++)
            {
                var ctrl = flowPanel.Controls[i];
                if (clientPoint.X < ctrl.Bounds.Right && clientPoint.Y < ctrl.Bounds.Bottom)
                {
                    insertIndex = i;
                    break;
                }
            }

            flowPanel.Controls.SetChildIndex(dragged, insertIndex);
            flowPanel.Invalidate();

            // Update ordering
            UpdateMenuOrderFromUI();
            SaveMenu();
        }

        private void UpdateMenuOrderFromUI()
        {
            var visibleCards = flowPanel.Controls.OfType<app_escritorio.Controls.MenuCard>().Where(c => c.Visible && c.Item != null).ToList();
            var categoryId = currentSelectedCategoryId ?? (visibleCards.Count > 0 ? visibleCards[0].Item.CategoryId : (Guid?)null);
            var categoryItems = categoryId == null
                ? menuData.Items.OrderBy(i => i.CategoryId).ThenBy(i => i.Position).ToList()
                : menuData.Items.Where(i => i.CategoryId == categoryId).OrderBy(i => i.Position).ToList();
            if (categoryId != null)
            {
                categoryItems = new List<app_escritorio.Models.MenuItem>();
                foreach (var card in visibleCards) if (!categoryItems.Any(i => i.Id == card.Item.Id)) categoryItems.Add(card.Item);
                foreach (var item in menuData.Items.Where(i => i.CategoryId == categoryId && !categoryItems.Any(c => c.Id == i.Id))) categoryItems.Add(item);
                for (int i = 0; i < categoryItems.Count; i++) categoryItems[i].Position = i;
            }
            else
            {
                for (int i = 0; i < categoryItems.Count; i++) categoryItems[i].Position = i;
            }
        }

        private void OpenOrderHistory()
        {
            using (var historyForm = new app_escritorio.Forms.OrderHistoryForm("data/orders.xml"))
            {
                historyForm.TopMost = true;
                historyForm.ShowDialog(this);
                historyForm.TopMost = false;
            }
        }

        // ========== TOOLBAR BUTTON HANDLERS ==========
        private void BtnNewItem_Click()
        {
            if (menuData == null) return;
            if (menuData.Categories.Count == 0) { MessageBox.Show("Primero crea una categoría.", "Nuevo plato", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            var item = new app_escritorio.Models.MenuItem
            {
                Name = "",
                CategoryId = currentSelectedCategoryId ?? menuData.Categories.OrderBy(c => c.Position).First().Id,
                PriceSalon = 0,
                PriceDelivery = 0,
                Stock = -1,
                IsAvailable = true,
                Position = menuData.Items.Count(i => i.CategoryId == (currentSelectedCategoryId ?? menuData.Categories.OrderBy(c => c.Position).First().Id)),
                Tags = new List<string>(),
                Variants = new List<app_escritorio.Models.MenuVariant>()
            };
            // No se agrega ni se guarda hasta pulsar "Agregar a la carta"
            ShowEditorFor(item, true);
        }

        private void ManageCategories()
        {
            if (menuData == null) return;
            using (var dialog = new Form { Text = "Administrar categorías", Width = 430, Height = 380, StartPosition = FormStartPosition.CenterParent, BackColor = app_escritorio.Utils.Theme.BackgroundMedium, ShowInTaskbar = false })
            {
                var list = new ListBox { Left = 15, Top = 15, Width = 285, Height = 280, BackColor = app_escritorio.Utils.Theme.BackgroundDark, ForeColor = app_escritorio.Utils.Theme.TextPrimary, Font = app_escritorio.Utils.Theme.FontSmall };
                var input = new TextBox { Left = 15, Top = 305, Width = 285, Height = 28, BackColor = app_escritorio.Utils.Theme.BackgroundDark, ForeColor = app_escritorio.Utils.Theme.TextPrimary };
                var add = new Button { Text = "Agregar", Left = 310, Top = 15, Width = 95, Height = 30, BackColor = app_escritorio.Utils.Theme.AccentSecondary, ForeColor = app_escritorio.Utils.Theme.TertiaryText, FlatStyle = FlatStyle.Flat };
                var remove = new Button { Text = "Eliminar", Left = 310, Top = 55, Width = 95, Height = 30, BackColor = app_escritorio.Utils.Theme.DangerBackground, ForeColor = app_escritorio.Utils.Theme.StatusUnavailable, FlatStyle = FlatStyle.Flat };
                var close = new Button { Text = "Listo", Left = 310, Top = 305, Width = 95, Height = 30, BackColor = app_escritorio.Utils.Theme.AccentPrimary, ForeColor = Color.White, FlatStyle = FlatStyle.Flat, DialogResult = DialogResult.OK };
                add.Click += (s, e) => { var name = input.Text.Trim(); if (name.Length == 0) return; var category = new app_escritorio.Models.Category { Name = name, Position = menuData.Categories.Count }; menuData.Categories.Add(category); list.Items.Add(category); input.Clear(); input.Focus(); };
                remove.Click += (s, e) => { var category = list.SelectedItem as app_escritorio.Models.Category; if (category == null || MessageBox.Show("¿Eliminar la categoría? Los platos no se eliminarán.", "Categorías", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return; menuData.Categories.Remove(category); list.Items.Remove(category); currentSelectedCategoryId = null; };
                dialog.Controls.Add(list); dialog.Controls.Add(input); dialog.Controls.Add(add); dialog.Controls.Add(remove); dialog.Controls.Add(close);
                dialog.Shown += (s, e) => list.Items.AddRange(menuData.Categories.Cast<object>().ToArray());
                if (dialog.ShowDialog(this) == DialogResult.OK) { categoryBar.SetCategories(menuData.Categories); SaveMenu(); PopulateCards(currentSelectedCategoryId); }
            }
        }
    }
}
