using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using app_escritorio.Data;
using app_escritorio.Models;
using app_escritorio.UI;
using app_escritorio.Utils;
using app_escritorio.Views.Carta;

namespace app_escritorio.Forms
{
    /// <summary>
    /// Menú digital: carta en tarjetas con foto, estado y etiquetas, filtros rápidos y panel de "Edición Rápida".
    /// Al publicar, la carta se guarda (data\menu.xml) y el POS se actualiza al instante (MenuStore.MenuChanged).
    /// </summary>
    public partial class MenuForm : Form
    {
        private enum StatFilter { Ninguno, Disponibles, Agotados, Chef }

        private MenuItem _editing;
        private bool _isNew, _loading, _dirty;
        private string _editImage;
        private List<InsumoLink> _editInsumos = new List<InsumoLink>();
        private Guid? _categoryFilter;
        private StatFilter _stat = StatFilter.Ninguno;

        public MenuForm()
        {
            InitializeComponent();
            if (UiHelpers.IsDesignTime) return;

            // Las tarjetas de ejemplo solo están para verse en el diseñador
            foreach (Control c in flowDishes.Controls.Cast<Control>().Concat(flowInsumos.Controls.Cast<Control>()).ToList()) c.Dispose();
            cmbCategoria.DisplayMember = "Name";
            BuildCategoryChips();
            RenderDishes();
            var first = OrderedItems().FirstOrDefault();
            if (first != null) LoadEditor(first, false); else ClearEditor();
        }

        private static MenuData Data => MenuStore.Current;

        private static string CategoryName(Guid id) => Data.Categories.FirstOrDefault(c => c.Id == id)?.Name ?? "";

        private static bool IsAgotado(MenuItem i) => !i.IsAvailable || i.Stock == 0;

        private static IEnumerable<MenuItem> OrderedItems() =>
            Data.Items.OrderBy(i => Data.Categories.FindIndex(c => c.Id == i.CategoryId) is int k && k >= 0 ? k : int.MaxValue)
                      .ThenBy(i => i.Position);

        // ===================== Barra superior y categorías =====================

        private void UpdateStats()
        {
            chipDisponibles.Text = Data.Items.Count(i => !IsAgotado(i)) + " Disponibles";
            chipAgotados.Text = Data.Items.Count(IsAgotado) + " Agotados hoy";
            chipChef.Text = Data.Items.Count(i => i.IsSuggestion) + " Sugerencias del Chef";
            chipDisponibles.Selected = _stat == StatFilter.Disponibles;
            chipAgotados.Selected = _stat == StatFilter.Agotados;
            chipChef.Selected = _stat == StatFilter.Chef;
            chipAgotados.Left = chipDisponibles.Right + 10;
            chipChef.Left = chipAgotados.Right + 10;
        }

        private void BuildCategoryChips()
        {
            flowCategorias.SuspendLayout();
            foreach (Control c in flowCategorias.Controls.Cast<Control>().ToList()) c.Dispose();
            flowCategorias.Controls.Clear();
            AddCategoryChip(null, "Todas · " + Data.Items.Count);
            foreach (var cat in Data.Categories)
                AddCategoryChip(cat.Id, cat.Name + " · " + Data.Items.Count(i => i.CategoryId == cat.Id));
            flowCategorias.ResumeLayout(true);
        }

        private void AddCategoryChip(Guid? id, string text)
        {
            var chip = new RChip
            {
                Text = text, Tag = id, AccentColor = Theme.Primary, ChipStyle = ChipStyle.Soft, Clickable = true,
                Selected = _categoryFilter == id, Height = 32
            };
            chip.Click += CategoryChip_Click;
            flowCategorias.Controls.Add(chip);
        }

        private void CategoryChip_Click(object sender, EventArgs e)
        {
            _categoryFilter = (Guid?)((Control)sender).Tag;
            foreach (RChip c in flowCategorias.Controls.OfType<RChip>()) c.Selected = Equals(c.Tag, _categoryFilter);
            RenderDishes();
        }

        private void StatChip_Click(object sender, EventArgs e)
        {
            var wanted = sender == chipDisponibles ? StatFilter.Disponibles : sender == chipAgotados ? StatFilter.Agotados : StatFilter.Chef;
            _stat = _stat == wanted ? StatFilter.Ninguno : wanted;
            RenderDishes();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!UiHelpers.IsDesignTime) RenderDishes();
        }

        // ===================== Tarjetas =====================

        private bool Matches(MenuItem i, string q)
        {
            if (_categoryFilter != null && i.CategoryId != _categoryFilter) return false;
            if (_stat == StatFilter.Disponibles && IsAgotado(i)) return false;
            if (_stat == StatFilter.Agotados && !IsAgotado(i)) return false;
            if (_stat == StatFilter.Chef && !i.IsSuggestion) return false;
            if (q.Length == 0) return true;
            var text = string.Join(" ", new[] { i.Name, i.Description, CategoryName(i.CategoryId) }
                .Concat(i.Tags).Concat(i.DietaryFilters).Concat(i.Insumos.Select(x => x.Nombre)));
            return text.IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        private void RenderDishes()
        {
            string q = txtSearch.Text.Trim();
            flowDishes.SuspendLayout();
            foreach (Control c in flowDishes.Controls.Cast<Control>().ToList()) c.Dispose();
            flowDishes.Controls.Clear();

            foreach (var item in OrderedItems().Where(i => Matches(i, q)))
            {
                var card = new DishCard();
                card.SetItem(item, CategoryName(item.CategoryId));
                card.Selected = ReferenceEquals(item, _editing);
                card.CardClicked += Card_Clicked;
                card.EditClicked += Card_Clicked;
                card.PauseClicked += Card_PauseClicked;
                flowDishes.Controls.Add(card);
            }
            if (flowDishes.Controls.Count == 0)
                flowDishes.Controls.Add(new RLabel
                {
                    Text = "No hay platos que coincidan con el filtro.", TextStyle = TextStyle.Muted,
                    AutoSize = false, Size = new Size(420, 40), TextAlign = ContentAlignment.MiddleLeft
                });
            flowDishes.ResumeLayout(true);
            FitCards();
            UpdateStats();
        }

        private DishCard CardOf(MenuItem item) => flowDishes.Controls.OfType<DishCard>().FirstOrDefault(c => ReferenceEquals(c.Item, item));

        /// <summary>Reparte el ancho: tantas columnas como quepan (tarjetas de 270 a 340 px).</summary>
        private void FitCards()
        {
            int avail = flowDishes.ClientSize.Width - SystemInformation.VerticalScrollBarWidth - 2;
            const int gap = 14;
            int cols = Math.Max(1, (avail + gap) / (290 + gap));
            int w = Math.Max(250, Math.Min(360, (avail - cols * gap) / cols));
            foreach (var card in flowDishes.Controls.OfType<DishCard>()) card.Width = w;
        }

        private void FlowDishes_Resize(object sender, EventArgs e)
        {
            if (!UiHelpers.IsDesignTime) FitCards();
        }

        private void Card_Clicked(object sender, EventArgs e)
        {
            var item = ((DishCard)sender).Item;
            if (!ReferenceEquals(item, _editing)) LoadEditor(item, false);
        }

        /// <summary>"Pausar por falta de stock" / "Reactivar": se publica al instante (el POS lo oculta o lo muestra).</summary>
        private void Card_PauseClicked(object sender, EventArgs e)
        {
            var card = (DishCard)sender;
            var item = card.Item;
            item.IsAvailable = !item.IsAvailable;
            if (item.IsAvailable && item.Stock == 0) item.Stock = -1;
            MenuStore.Publish();
            if (_stat != StatFilter.Ninguno) RenderDishes();
            else { card.SetItem(item, CategoryName(item.CategoryId)); UpdateStats(); }
            if (ReferenceEquals(item, _editing))
            {
                _loading = true;
                swDisponible.Checked = item.IsAvailable;
                if (item.Stock < 0) txtStock.Text = "";
                _loading = false;
            }
            SetStatus(item.IsAvailable ? "▶ " + item.Name + " vuelve a estar en la carta y en el POS" : "⏸ " + item.Name + " pausado: ya no se ofrece en el POS",
                      item.IsAvailable ? Theme.Tertiary : Theme.Secondary);
        }

        // Arrastrar tarjetas para reordenar la carta
        private void FlowDishes_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(typeof(DishCard)) ? DragDropEffects.Move : DragDropEffects.None;
        }

        private void FlowDishes_DragDrop(object sender, DragEventArgs e)
        {
            var dragged = e.Data.GetData(typeof(DishCard)) as DishCard;
            var target = flowDishes.GetChildAtPoint(flowDishes.PointToClient(new Point(e.X, e.Y))) as DishCard;
            if (dragged == null || target == null || target == dragged) return;
            flowDishes.Controls.SetChildIndex(dragged, flowDishes.Controls.GetChildIndex(target));

            // Nuevo orden: tarjetas visibles primero y luego el resto, numerado por categoría
            var order = flowDishes.Controls.OfType<DishCard>().Select(c => c.Item).ToList();
            order.AddRange(OrderedItems().Where(i => !order.Contains(i)).ToList());
            foreach (var group in order.GroupBy(i => i.CategoryId))
            {
                int p = 0;
                foreach (var item in group) item.Position = p++;
            }
            MenuStore.Publish();
            SetStatus("↕ Orden de la carta actualizado", Theme.Tertiary);
        }

        // ===================== Edición rápida =====================

        private bool ConfirmDiscard()
        {
            if (!_dirty) return true;
            return MessageBox.Show("Hay cambios sin publicar en \"" + txtNombre.Text + "\". ¿Descartarlos?", "Menú digital",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void LoadEditor(MenuItem item, bool isNew)
        {
            if (!ConfirmDiscard()) return;
            _loading = true;
            _editing = item;
            _isNew = isNew;
            SetEditorEnabled(true);

            txtNombre.Text = item.Name ?? "";
            cmbCategoria.Items.Clear();
            foreach (var c in Data.Categories) cmbCategoria.Items.Add(c);
            cmbCategoria.SelectedItem = Data.Categories.FirstOrDefault(c => c.Id == item.CategoryId);
            if (cmbCategoria.SelectedIndex < 0 && cmbCategoria.Items.Count > 0) cmbCategoria.SelectedIndex = 0;

            _editImage = item.ImageUrl;
            UpdatePreview();
            swDisponible.Checked = item.IsAvailable;
            txtPrecioSalon.Text = CartaUi.MoneyInput(item.PriceSalon);
            txtPrecioDelivery.Text = CartaUi.MoneyInput(item.PriceDelivery);
            chipCalcDelivery.Text = item.NoCommission ? "Sin comisión" : "+" + item.CommissionPercentage.ToString("0.#") + "% · calcular";
            txtDescripcion.Text = item.Description ?? "";

            tglSinTacc.Selected = item.DietaryFilters.Contains("Sin TACC");
            tglVegetariano.Selected = item.DietaryFilters.Contains("Vegetariano");
            tglPicante.Selected = item.DietaryFilters.Contains("Picante");
            tglSinLactosa.Selected = item.DietaryFilters.Contains("Sin Lactosa");
            tglGluten.Selected = item.DietaryFilters.Contains("Gluten");
            tglLacteos.Selected = item.DietaryFilters.Contains("Lácteos");
            tglChef.Selected = item.IsSuggestion;
            tglMasVendido.Selected = item.Tags.Contains(CartaUi.MasVendido);

            txtStock.Text = item.Stock < 0 ? "" : item.Stock.ToString();
            _editInsumos = item.Insumos.Select(x => new InsumoLink { Nombre = x.Nombre, Cantidad = x.Cantidad, Unidad = x.Unidad }).ToList();
            RenderInsumos();

            btnDuplicar.Enabled = btnEliminar.Enabled = !isNew;
            btnPublicar.Text = isNew ? "⇪  Agregar a la carta" : "⇪  Publicar cambios al instante";
            _dirty = false;
            _loading = false;
            SetStatus(isNew ? "Plato nuevo: publícalo para agregarlo a la carta" : "Sin cambios pendientes", Theme.OnSurfaceVariant);

            foreach (var card in flowDishes.Controls.OfType<DishCard>()) card.Selected = ReferenceEquals(card.Item, item);
            editorPanel.AutoScrollPosition = new Point(0, 0);
        }

        private void ClearEditor()
        {
            _editing = null;
            _dirty = false;
            SetEditorEnabled(false);
            SetStatus("La carta está vacía: crea el primer plato con \"+ Nuevo plato\"", Theme.OnSurfaceVariant);
        }

        private void SetEditorEnabled(bool on)
        {
            foreach (Control c in editorPanel.Controls)
                if (c is RTextBox || c is RComboBox || c is RButton || c is RSwitch || c is RPanel) c.Enabled = on;
        }

        private void UpdatePreview()
        {
            imgPreview.Image = DishImage.LoadCached(_editImage);
            var cat = cmbCategoria.SelectedItem as Category;
            imgPreview.Glyph = CartaUi.GlyphFor(cat?.Name);
        }

        private void RenderInsumos()
        {
            flowInsumos.SuspendLayout();
            foreach (Control c in flowInsumos.Controls.Cast<Control>().ToList()) c.Dispose();
            flowInsumos.Controls.Clear();
            foreach (var link in _editInsumos)
            {
                var row = new InsumoLinkRow { Width = flowInsumos.ClientSize.Width - 4 };
                row.SetLink(link);
                row.RemoveClicked += InsumoRow_RemoveClicked;
                flowInsumos.Controls.Add(row);
            }
            flowInsumos.ResumeLayout(true);
            lblInvCount.Text = _editInsumos.Count == 0 ? "Sin insumos" : _editInsumos.Count == 1 ? "1 insumo vinculado" : _editInsumos.Count + " insumos vinculados";
        }

        private void InsumoRow_RemoveClicked(object sender, EventArgs e)
        {
            _editInsumos.Remove(((InsumoLinkRow)sender).Link);
            RenderInsumos();
            MarkDirty();
        }

        private void MarkDirty()
        {
            if (_loading || _editing == null) return;
            _dirty = true;
            SetStatus("● Cambios sin publicar  (Ctrl+S)", Theme.Secondary);
        }

        private void SetStatus(string text, Color color)
        {
            lblEstado.Text = text;
            lblEstado.ColorOverride = color;
        }

        private void Editor_Changed(object sender, EventArgs e)
        {
            if (UiHelpers.IsDesignTime || _loading) return;
            if (sender == cmbCategoria) UpdatePreview();
            MarkDirty();
        }

        private void Toggle_Click(object sender, EventArgs e)
        {
            var b = (RButton)sender;
            b.Selected = !b.Selected;
            MarkDirty();
        }

        private void BtnCalcDelivery_Click(object sender, EventArgs e)
        {
            if (_editing == null || !CartaUi.TryParseMoney(txtPrecioSalon.Text, out decimal salon)) return;
            decimal pct = _editing.NoCommission ? 0 : _editing.CommissionPercentage;
            txtPrecioDelivery.Text = CartaUi.MoneyInput(CartaUi.DeliveryPrice(salon, pct));
        }

        private void BtnFoto_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog { Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.webp|Todos|*.*", Title = "Foto del plato" })
            {
                if (dlg.ShowDialog(TopLevelControl ?? this) != DialogResult.OK) return;
                _editImage = dlg.FileName;
                UpdatePreview();
                MarkDirty();
            }
        }

        private void BtnVincular_Click(object sender, EventArgs e)
        {
            using (var dlg = new InsumoLinkDialogForm())
            {
                if (dlg.ShowDialog(TopLevelControl ?? this) != DialogResult.OK || dlg.Result == null) return;
                _editInsumos.Add(dlg.Result);
                RenderInsumos();
                MarkDirty();
            }
        }

        private void BtnPublicar_Click(object sender, EventArgs e)
        {
            if (_editing == null) return;
            string name = txtNombre.Text.Trim();
            if (name.Length == 0) { Warn("Escribe el nombre del plato.", txtNombre); return; }
            if (!CartaUi.TryParseMoney(txtPrecioSalon.Text, out decimal salon)) { Warn("Precio de salón inválido. Ejemplo: 48.000", txtPrecioSalon); return; }
            if (!CartaUi.TryParseMoney(txtPrecioDelivery.Text, out decimal delivery)) { Warn("Precio de delivery inválido. Ejemplo: 55.200", txtPrecioDelivery); return; }
            int stock = -1;
            if (txtStock.Text.Trim().Length > 0 && (!int.TryParse(txtStock.Text.Trim(), out stock) || stock < 0))
            { Warn("Porciones inválidas: deja vacío para ilimitado o escribe un número.", txtStock); return; }
            if (!(cmbCategoria.SelectedItem is Category cat)) { Warn("Elige una categoría.", cmbCategoria); return; }

            var item = _editing;
            if (item.CategoryId != cat.Id) item.Position = Data.Items.Count(i => i.CategoryId == cat.Id);
            item.Name = name;
            item.CategoryId = cat.Id;
            item.ImageUrl = _editImage;
            item.IsAvailable = swDisponible.Checked;
            item.PriceSalon = salon;
            item.PriceDelivery = delivery;
            item.Description = txtDescripcion.Text.Trim();
            item.Stock = stock;
            item.IsSuggestion = tglChef.Selected;

            var dietary = new List<string>();
            if (tglSinTacc.Selected) dietary.Add("Sin TACC");
            if (tglVegetariano.Selected) dietary.Add("Vegetariano");
            if (tglPicante.Selected) dietary.Add("Picante");
            if (tglSinLactosa.Selected) dietary.Add("Sin Lactosa");
            if (tglGluten.Selected) dietary.Add("Gluten");
            if (tglLacteos.Selected) dietary.Add("Lácteos");
            item.DietaryFilters = dietary;
            item.Tags.Remove(CartaUi.MasVendido);
            if (tglMasVendido.Selected) item.Tags.Add(CartaUi.MasVendido);
            item.Insumos = _editInsumos.ToList();

            foreach (var c in Data.Categories) c.ItemIds.Remove(item.Id);
            cat.ItemIds.Add(item.Id);
            if (_isNew) Data.Items.Add(item);

            MenuStore.Publish();
            _isNew = false;
            _dirty = false;
            btnDuplicar.Enabled = btnEliminar.Enabled = true;
            btnPublicar.Text = "⇪  Publicar cambios al instante";
            BuildCategoryChips();
            RenderDishes();
            SetStatus("✓ Publicado a las " + DateTime.Now.ToString("HH:mm") + " · el POS ya muestra los cambios", Theme.Tertiary);
        }

        private void Warn(string text, Control focus)
        {
            MessageBox.Show(text, "Menú digital", MessageBoxButtons.OK, MessageBoxIcon.Information);
            focus.Focus();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            if (Data.Categories.Count == 0) { MessageBox.Show("Primero crea una categoría.", "Menú digital"); return; }
            var catId = _categoryFilter ?? Data.Categories[0].Id;
            var item = new MenuItem
            {
                Name = "", CategoryId = catId, Stock = -1, IsAvailable = true,
                Position = Data.Items.Count(i => i.CategoryId == catId)
            };
            LoadEditor(item, true);
            if (!ReferenceEquals(_editing, item)) return;
            txtNombre.Focus();
        }

        private void BtnDuplicar_Click(object sender, EventArgs e)
        {
            if (_editing == null || _isNew || !ConfirmDiscard()) return;
            _dirty = false;
            var src = _editing;
            var copy = new MenuItem
            {
                Name = src.Name + " (copia)", Description = src.Description, CategoryId = src.CategoryId,
                PriceSalon = src.PriceSalon, PriceDelivery = src.PriceDelivery, CommissionPercentage = src.CommissionPercentage,
                NoCommission = src.NoCommission, IsAvailable = src.IsAvailable, IsSuggestion = src.IsSuggestion,
                ImageUrl = src.ImageUrl, Stock = src.Stock, Position = src.Position + 1,
                Tags = src.Tags.ToList(), DietaryFilters = src.DietaryFilters.ToList(),
                Insumos = src.Insumos.Select(x => new InsumoLink { Nombre = x.Nombre, Cantidad = x.Cantidad, Unidad = x.Unidad }).ToList()
            };
            foreach (var i in Data.Items.Where(i => i.CategoryId == src.CategoryId && i.Position > src.Position)) i.Position++;
            Data.Items.Add(copy);
            Data.Categories.FirstOrDefault(c => c.Id == copy.CategoryId)?.ItemIds.Add(copy.Id);
            MenuStore.Publish();
            BuildCategoryChips();
            RenderDishes();
            LoadEditor(copy, false);
            SetStatus("⧉ Copia creada: cámbiale el nombre y publícala", Theme.Tertiary);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (_editing == null || _isNew) return;
            if (MessageBox.Show("¿Eliminar \"" + _editing.Name + "\" de la carta?", "Menú digital", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            var item = _editing;
            Data.Items.Remove(item);
            foreach (var c in Data.Categories) c.ItemIds.Remove(item.Id);
            MenuStore.Publish();
            _dirty = false;
            _editing = null;
            BuildCategoryChips();
            RenderDishes();
            var next = OrderedItems().FirstOrDefault();
            if (next != null) LoadEditor(next, false); else ClearEditor();
            SetStatus("🗑 " + item.Name + " eliminado de la carta", Theme.Secondary);
        }

        private void BtnCategorias_Click(object sender, EventArgs e)
        {
            using (var dlg = new CategoriasDialogForm(Data)) dlg.ShowDialog(TopLevelControl ?? this);
            if (_categoryFilter != null && Data.Categories.All(c => c.Id != _categoryFilter)) _categoryFilter = null;
            MenuStore.Publish();
            BuildCategoryChips();
            RenderDishes();
            if (_editing != null)
            {
                bool dirty = _dirty;
                _loading = true;
                var current = cmbCategoria.SelectedItem;
                cmbCategoria.Items.Clear();
                foreach (var c in Data.Categories) cmbCategoria.Items.Add(c);
                cmbCategoria.SelectedItem = current;
                _loading = false;
                _dirty = dirty;
            }
        }

        private void BtnHistorial_Click(object sender, EventArgs e)
        {
            using (var history = new OrderHistoryForm("data/orders.xml")) history.ShowDialog(TopLevelControl ?? this);
        }

        /// <summary>Atajos: Ctrl+F buscar · Ctrl+N nuevo plato · Ctrl+S publicar.</summary>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Control | Keys.F: txtSearch.Focus(); return true;
                case Keys.Control | Keys.N: BtnNuevo_Click(this, EventArgs.Empty); return true;
                case Keys.Control | Keys.S: BtnPublicar_Click(this, EventArgs.Empty); return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
